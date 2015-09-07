namespace Profilometer_Keyence
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textbox_hsport = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_ipaddress4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_ipaddress3 = new System.Windows.Forms.TextBox();
            this.textbox_ipaddress1 = new System.Windows.Forms.TextBox();
            this.textbox_ipaddress2 = new System.Windows.Forms.TextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.button_browse = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textbox_filename = new System.Windows.Forms.TextBox();
            this.textbox_stprofile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox_frequency = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_status = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.highSpeedTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_browse);
            this.groupBox1.Controls.Add(this.textbox_hsport);
            this.groupBox1.Controls.Add(this.textbox_filename);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textbox_ipaddress4);
            this.groupBox1.Controls.Add(this.textbox_stprofile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textbox_ipaddress3);
            this.groupBox1.Controls.Add(this.textbox_frequency);
            this.groupBox1.Controls.Add(this.textbox_ipaddress1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textbox_ipaddress2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ethernet Settings";
            // 
            // textbox_hsport
            // 
            this.textbox_hsport.Location = new System.Drawing.Point(122, 56);
            this.textbox_hsport.Multiline = true;
            this.textbox_hsport.Name = "textbox_hsport";
            this.textbox_hsport.Size = new System.Drawing.Size(86, 20);
            this.textbox_hsport.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Port";
            // 
            // textbox_ipaddress4
            // 
            this.textbox_ipaddress4.Location = new System.Drawing.Point(262, 26);
            this.textbox_ipaddress4.Multiline = true;
            this.textbox_ipaddress4.Name = "textbox_ipaddress4";
            this.textbox_ipaddress4.Size = new System.Drawing.Size(40, 20);
            this.textbox_ipaddress4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP Address";
            // 
            // textbox_ipaddress3
            // 
            this.textbox_ipaddress3.Location = new System.Drawing.Point(216, 26);
            this.textbox_ipaddress3.Multiline = true;
            this.textbox_ipaddress3.Name = "textbox_ipaddress3";
            this.textbox_ipaddress3.Size = new System.Drawing.Size(40, 20);
            this.textbox_ipaddress3.TabIndex = 6;
            // 
            // textbox_ipaddress1
            // 
            this.textbox_ipaddress1.Location = new System.Drawing.Point(122, 26);
            this.textbox_ipaddress1.Multiline = true;
            this.textbox_ipaddress1.Name = "textbox_ipaddress1";
            this.textbox_ipaddress1.Size = new System.Drawing.Size(40, 20);
            this.textbox_ipaddress1.TabIndex = 4;
            // 
            // textbox_ipaddress2
            // 
            this.textbox_ipaddress2.Location = new System.Drawing.Point(170, 26);
            this.textbox_ipaddress2.Multiline = true;
            this.textbox_ipaddress2.Name = "textbox_ipaddress2";
            this.textbox_ipaddress2.Size = new System.Drawing.Size(40, 20);
            this.textbox_ipaddress2.TabIndex = 5;
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(15, 19);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(97, 30);
            this.button_connect.TabIndex = 1;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // button_disconnect
            // 
            this.button_disconnect.Location = new System.Drawing.Point(15, 55);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(97, 31);
            this.button_disconnect.TabIndex = 2;
            this.button_disconnect.Text = "Disconnect";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // button_browse
            // 
            this.button_browse.Location = new System.Drawing.Point(603, 87);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(32, 23);
            this.button_browse.TabIndex = 4;
            this.button_browse.Text = "...";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "File Name";
            // 
            // textbox_filename
            // 
            this.textbox_filename.Location = new System.Drawing.Point(455, 90);
            this.textbox_filename.Name = "textbox_filename";
            this.textbox_filename.Size = new System.Drawing.Size(142, 20);
            this.textbox_filename.TabIndex = 5;
            // 
            // textbox_stprofile
            // 
            this.textbox_stprofile.Location = new System.Drawing.Point(455, 59);
            this.textbox_stprofile.Multiline = true;
            this.textbox_stprofile.Name = "textbox_stprofile";
            this.textbox_stprofile.Size = new System.Drawing.Size(86, 20);
            this.textbox_stprofile.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Start Profile";
            // 
            // textbox_frequency
            // 
            this.textbox_frequency.Location = new System.Drawing.Point(455, 29);
            this.textbox_frequency.Multiline = true;
            this.textbox_frequency.Name = "textbox_frequency";
            this.textbox_frequency.Size = new System.Drawing.Size(86, 20);
            this.textbox_frequency.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Frequency";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_status);
            this.groupBox3.Location = new System.Drawing.Point(12, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(517, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // textBox_status
            // 
            this.textBox_status.Location = new System.Drawing.Point(6, 19);
            this.textBox_status.Multiline = true;
            this.textBox_status.Name = "textBox_status";
            this.textBox_status.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_status.Size = new System.Drawing.Size(502, 75);
            this.textBox_status.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_connect);
            this.groupBox4.Controls.Add(this.button_disconnect);
            this.groupBox4.Location = new System.Drawing.Point(535, 136);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(123, 100);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // highSpeedTimer
            // 
            this.highSpeedTimer.Interval = 200;
            this.highSpeedTimer.Tick += new System.EventHandler(this.highSpeedTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 246);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profilometer - Keyence";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textbox_hsport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_ipaddress4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_ipaddress3;
        private System.Windows.Forms.TextBox textbox_ipaddress1;
        private System.Windows.Forms.TextBox textbox_ipaddress2;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.TextBox textbox_stprofile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbox_frequency;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbox_filename;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_status;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer highSpeedTimer;
    }
}

