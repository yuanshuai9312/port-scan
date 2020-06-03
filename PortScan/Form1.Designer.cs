namespace PortScan
{
    partial class PortScan
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox_IP = new System.Windows.Forms.CheckBox();
            this.textBox_IP2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_IP1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_port = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_port2 = new System.Windows.Forms.TextBox();
            this.textBox_port1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBox_showopenport = new System.Windows.Forms.CheckBox();
            this.button_end = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_IP
            // 
            this.checkBox_IP.AutoSize = true;
            this.checkBox_IP.Location = new System.Drawing.Point(525, 26);
            this.checkBox_IP.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_IP.Name = "checkBox_IP";
            this.checkBox_IP.Size = new System.Drawing.Size(119, 19);
            this.checkBox_IP.TabIndex = 4;
            this.checkBox_IP.Text = "扫描单个主机";
            this.checkBox_IP.UseVisualStyleBackColor = true;
            this.checkBox_IP.CheckedChanged += new System.EventHandler(this.checkBox_IP_CheckedChanged);
            // 
            // textBox_IP2
            // 
            this.textBox_IP2.Location = new System.Drawing.Point(279, 21);
            this.textBox_IP2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_IP2.Name = "textBox_IP2";
            this.textBox_IP2.Size = new System.Drawing.Size(200, 22);
            this.textBox_IP2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "-->";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_IP);
            this.groupBox1.Controls.Add(this.textBox_IP2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_IP1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(672, 52);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP";
            // 
            // textBox_IP1
            // 
            this.textBox_IP1.Location = new System.Drawing.Point(69, 21);
            this.textBox_IP1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_IP1.Name = "textBox_IP1";
            this.textBox_IP1.Size = new System.Drawing.Size(169, 22);
            this.textBox_IP1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // checkBox_port
            // 
            this.checkBox_port.AutoSize = true;
            this.checkBox_port.Location = new System.Drawing.Point(525, 32);
            this.checkBox_port.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_port.Name = "checkBox_port";
            this.checkBox_port.Size = new System.Drawing.Size(119, 19);
            this.checkBox_port.TabIndex = 3;
            this.checkBox_port.Text = "扫描单个端口";
            this.checkBox_port.UseVisualStyleBackColor = true;
            this.checkBox_port.CheckedChanged += new System.EventHandler(this.checkBox_port_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.checkBox_port);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_port2);
            this.groupBox2.Controls.Add(this.textBox_port1);
            this.groupBox2.Location = new System.Drawing.Point(16, 75);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(672, 64);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "扫描端口列表";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "端口";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "-->";
            // 
            // textBox_port2
            // 
            this.textBox_port2.Location = new System.Drawing.Point(279, 24);
            this.textBox_port2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_port2.Name = "textBox_port2";
            this.textBox_port2.Size = new System.Drawing.Size(200, 22);
            this.textBox_port2.TabIndex = 1;
            // 
            // textBox_port1
            // 
            this.textBox_port1.Location = new System.Drawing.Point(69, 24);
            this.textBox_port1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_port1.Name = "textBox_port1";
            this.textBox_port1.Size = new System.Drawing.Size(169, 22);
            this.textBox_port1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.richTextBox1);
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Controls.Add(this.checkBox_showopenport);
            this.groupBox4.Location = new System.Drawing.Point(16, 259);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(672, 441);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "扫描结果";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(8, 24);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(652, 83);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(8, 145);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(652, 274);
            this.listBox1.TabIndex = 11;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // checkBox_showopenport
            // 
            this.checkBox_showopenport.AutoSize = true;
            this.checkBox_showopenport.Location = new System.Drawing.Point(8, 115);
            this.checkBox_showopenport.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_showopenport.Name = "checkBox_showopenport";
            this.checkBox_showopenport.Size = new System.Drawing.Size(134, 19);
            this.checkBox_showopenport.TabIndex = 8;
            this.checkBox_showopenport.Text = "只显示开放端口";
            this.checkBox_showopenport.UseVisualStyleBackColor = true;
            // 
            // button_end
            // 
            this.button_end.Location = new System.Drawing.Point(392, 219);
            this.button_end.Margin = new System.Windows.Forms.Padding(4);
            this.button_end.Name = "button_end";
            this.button_end.Size = new System.Drawing.Size(104, 32);
            this.button_end.TabIndex = 12;
            this.button_end.Text = "停止";
            this.button_end.UseVisualStyleBackColor = true;
            this.button_end.Click += new System.EventHandler(this.button_end_Click);
            // 
            // button_start
            // 
            this.button_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_start.Location = new System.Drawing.Point(197, 219);
            this.button_start.Margin = new System.Windows.Forms.Padding(4);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(104, 32);
            this.button_start.TabIndex = 11;
            this.button_start.Text = "开始";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // PortScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(693, 745);
            this.Controls.Add(this.button_end);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PortScan";
            this.Text = "PortScan";
            this.Load += new System.EventHandler(this.PortScan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_IP;
        private System.Windows.Forms.TextBox textBox_IP2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_IP1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_port;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_port2;
        private System.Windows.Forms.TextBox textBox_port1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox checkBox_showopenport;
        private System.Windows.Forms.Button button_end;
        private System.Windows.Forms.Button button_start;
    }
}

