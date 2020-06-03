using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text.RegularExpressions;



namespace PortScan
{
    public partial class PortScan : Form
    {
        /*用来接受控件中值的变量*/
        private string ipStart;
        private string ipEnd;
        private int portStart;
        private int portEnd;
        private int numThread=20;//默认为20；
        private int overTime;
        private Thread t;//定义一个线程
        private Thread scanthread;
        private bool[] done = new bool[65536];  
        private bool ok;
        private int num = 1;//扫描次数
        /*点击后的IP与端口*/
        private string clickIP;
        private int clickPort;
        //private int port;
    

        List<string> str;
        /*用来记录扫描结果并填充进DataGridView控件*/


        public PortScan()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void PortScan_Load(object sender, EventArgs e)
        {
            /*如果控件中值均不为空，将值赋给变量*/
            if (textBox_IP1.Text!= "")
            {
                ipStart = textBox_IP1.Text;
            }
            if(textBox_port1.Text!="")
            {
                portStart = int.Parse(textBox_port1.Text);//注意类型转换
            }

          

            if (checkBox_IP.Checked)
            {
                textBox_IP1.ReadOnly = true;
            }

            if (checkBox_port.Checked)
            {
                textBox_port2.ReadOnly = true;
            }

            //textBox5.Text = "10";

            ///*设置超时时限最小为10s，最大为30s*/
            //trackBar1.Minimum = 10;
            //trackBar1.Maximum = 30;
            //overTime = trackBar1.Value;
            overTime = 15;

            //清除Lisview中的数据
            listBox1.Items.Add("IP地址                   " + "    端口       " + "      端口状态 " + "        服务");
            listBox1.Items.Add("");
        

           
       
        }

       

        /*开始*/
        private void button_start_Click(object sender, EventArgs e)
        {
            /*改变开始、停止按钮状态*/
            button_end.Enabled = true;

            richTextBox1.Clear();

            listBox1.Items.Clear();
            listBox1.Items.Add("IP地址                   " + "    端口       " + "      端口状态 " + "        服务");
            listBox1.Items.Add("");
        

          if(checkBox_IP.Checked)
          {
              textBox_IP2.Text = textBox_IP1.Text;
          }
          if (checkBox_port.Checked)
          {
              textBox_port2.Text = textBox_port1.Text;
          }

           richTextBox1.Text = "开始\n";
            //匹配正确的IP地址
            Regex rgx = new Regex(@"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$");

            if (rgx.IsMatch(textBox_IP1.Text) && rgx.IsMatch(textBox_IP2.Text))//匹配正确IP
            {
                if(textBox_port1.Text=="")
                {
                    MessageBox.Show("请输入端口号！");
                }
                else
                {
                    portStart = Int32.Parse(textBox_port1.Text);
                    portEnd = Int32.Parse(textBox_port2.Text);

               }
               
            }
            else
            {
                MessageBox.Show("请填写正确IP");
                return;
            }

         
            if (portEnd < portStart)
            {
                MessageBox.Show("请填写正确端口范围");
                return;
            }
            ok = true;
            Thread waitT = new Thread(new ThreadStart(wait));
            waitT.Start();//等待所有线程执行完毕在写入textbox中
           
        }

        public void wait()
        {
            int startIp = Int32.Parse(textBox_IP1.Text.Split('.')[3]);
            int endIp = Int32.Parse(textBox_IP2.Text.Split('.')[3]);
            
            string ip = textBox_IP1.Text.Split('.')[0] + "." + textBox_IP1.Text.Split('.')[1] + "." + textBox_IP1.Text.Split('.')[2] + ".";

            
            for (int q = startIp; q <= endIp && ok == true; q++)
            {
                     
                //---------------------ping
                Ping ping = new Ping();
                PingReply reply = ping.Send(IPAddress.Parse(ip + q), 15);
                if (reply.Status == IPStatus.Success)   //PingReply.Status 属性获取发送 Internet 控制消息协议 (ICMP) 回送请求并接收相应 ICMP 回送答复消息的尝试的状态。
                {
                    richTextBox1.Text += ip + q + " Ping时间" + reply.RoundtripTime + "毫秒\n";
                    IPHostEntry host = Dns.GetHostEntry(ip + q);  //Dns 类提供简单的域名解析功能
                    richTextBox1.Text += "主机名为 " + host.HostName + "\n";
                }
                else
                {
                    listBox1.Items.Add(ip + q + "                 " + "-" + "            " + "-" + "   " + "                - 不可达\n");
                    richTextBox1.Text += ip + q + "不可达\n";
                    continue;
                }
                
                
               
               
             
                //---------------------end
                Thread[] tharr ;
                if (numThread < (portEnd - portStart + 1))
                {
                    tharr= new Thread[portEnd - portStart + 1];
                }
                else
                {
                    tharr = new Thread[numThread];
                }
                str = new List<string>();

                for (int cishu = 1; cishu <= num;cishu++ )
                {
                    for (int i = portStart; i <= portEnd; i++)
                    {
                        Thread thread = new Thread(new ParameterizedThreadStart(Scan));
                        thread.Start(new IPEndPoint(IPAddress.Parse(ip + q), i));//每扫描一个端口创建一个线程

                        richTextBox1.Text += i + " 端口扫描中---\n";

                        tharr[i - portStart] = thread;


                        string s = State(i);
                        if (checkBox_showopenport.Checked)
                        {
                            if (s == "Open")
                            {

                                listBox1.Items.Add("|" + ip + q + "||                /" + i + "//           " + s + "   " + "          " + Service(i));
                            }
                        }
                        else
                        {
                            if (s == "Open")
                            {

                                listBox1.Items.Add("|" + ip + q + "||                /" + i + "//            " + s + "   " + "         " + Service(i));
                            }
                            else
                            {
                                listBox1.Items.Add("|" + ip + q + "||                /" + i + "//            " + s + "   " + "          ");
                            }
                        }

                    }
                }

                bool iscon = true;//第一个线程等待时间
                for (int i = 0; i < tharr.Length; i++)
                {
                    if (tharr[i] == null)
                        continue;
                    while (tharr[i].IsAlive && iscon)//端口超时设置时间(目前200毫秒),一直等待此ip所有线程执行完毕才扫描下个ip
                    {
                        Thread.Sleep(200);
                        iscon = false;//第一个线程给200ms等待时间，其他线程由于同步执行的，所以没等待时间了,如果线程还没执行完，说明此端口不可达。
                    }
                }
                str.Sort();
               richTextBox1.Text += "开放端口： ";
                for (int k = 0; k < str.Count; k++)
                   richTextBox1.Text += str[k]+"  ";
               richTextBox1.Text += "\n";
            }
            if (ok == true)
            {
                MessageBox.Show("扫描完成");

            }
            else
            {
                MessageBox.Show("扫描终止");
            }

            
        }
        public string State(int i)
        {
               str.Sort();
                for (int k = 0; k < str.Count; k++)
                {
                    string s = str[k];
                    if(Convert.ToString(i)==s)
                        return "Open";
                }
                   return "Closed";
        }
        public string Service(int i)
        {
            switch (i)
            {

                case 80:
                    return "HTTP协议代理服务";
                case 135:
                    return "DCE endpoint resolutionnetbios-ns";
                case 445:
                    return "安全服务";
                case 1025:
                    return "NetSpy.698(YAI)";
                
                
                case 8080:
                    return "HTTP协议代理服务";
                    
                case 8081:
                    return "HTTP协议代理服务";
                   
                case 3128:
                    return "HTTP协议代理服务";
             
                case 9080:
                    return "HTTP协议代理服务";
                
                case 1080:
                    return "SOCKS代理协议服务";
                    
                case 21:
                    return "FTP(文件传输)协议代理服务";
                    
                case 23:
                    return "Telnet(远程登录)协议代理服务";
               
                case 443:
                    return "HTTPS协议代理服务";
                   
                case 69:
                    return "TFTP协议代理服务";
                   
                case 22:
                    return "SSH、SCP、端口重定向协议代理服务";
                   
                case 25:
                    return "SMTP协议代理服务";
                  
                case 110:
                    return "POP3协议代理服务";
                default:
                    return "Unknow Servies";
        
              

            }
        }

        public void Scan(object Point)
        {
            IPEndPoint IPPoint = (IPEndPoint)Point;
            try
            {
                TcpClient tcp = new TcpClient();
                tcp.Connect(IPPoint);
                if (tcp.Connected)
                    str.Add(Convert.ToString( IPPoint.Port));
           }
            catch
            {
                ;
            }
        }


      
            
      
        /*停止*/
        private void button_end_Click(object sender, EventArgs e)
        {
            button_start.Enabled = true;
            button_end.Enabled = false;

            ok = false;


        }
       
        /*“只显示开放端口”按钮被选定*/
      

        //private void trackBar1_Scroll(object sender, EventArgs e)
        //{
        //    /*将textbox中值与trackbar中值联系起来*/
        //    textBox6.Text = this.trackBar1.Value.ToString();
        //}

       

        private void checkBox_IP_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox_IP2.Visible == true)
            {
                textBox_IP2.Visible = false;
                label2.Text = "";
            }
            else
            {
                textBox_IP2.Visible = true;
                textBox_IP1.Text = textBox_IP2.Text="";
                label2.Text = "-";
            }
                
        }

        private void checkBox_port_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox_port2.Visible == true)
            {
                textBox_port2.Visible = false;
                label3.Text = "";
            }
            else
            {
                textBox_port2.Visible = true;
                textBox_port1.Text = textBox_port2.Text = "";
                label3.Text = "-";
            }
               
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        //    if (listBox1.SelectedItems != null && listBox1.SelectedItems.Count > 0)
        //    {
        //        clickIP =  listBox1.SelectedItems[0].ToString();
        //        clickPort = Int32.Parse(listBox1.SelectedItems[1].ToString());
                

               
        //        //try   
        //        //{   
        //        //    TcpClient   tcpClient   =   new   TcpClient(clickIP,clickPort); 
                   

        //    }

        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems != null && listBox1.SelectedItems.Count > 0)
            {
                string zongstr = listBox1.SelectedItems[0].ToString();
                string str1 = "|";
                string str2 = "||";
                string str3 = "/";
                string str4 = "//";
                int start1 = zongstr.IndexOf(str1);
                int end1 = zongstr.IndexOf(str2);

                int start2 = zongstr.IndexOf(str3);
                int end2 = zongstr.IndexOf(str4);
                clickIP =zongstr.Substring(start1+1,end1-start1-1);
                clickPort = Int32.Parse( zongstr.Substring(start2 + 1, end2 - start2 - 1));
                       
                
                // FormChatClient f2 = new FormChatClient(clickIP);



            }
            else
            {
                MessageBox.Show("请选择要连接的服务器!");
            }

        }

       

       
       
       
       

    
    }
}
