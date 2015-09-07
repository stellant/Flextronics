namespace Barcode_Keyence
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
            this.groupBox_readertype = new System.Windows.Forms.GroupBox();
            this.comboBox_readertype = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button_close = new System.Windows.Forms.Button();
            this.button_connect = new System.Windows.Forms.Button();
            this.groupBox_frequency = new System.Windows.Forms.GroupBox();
            this.textBox_frequency = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton_demand = new System.Windows.Forms.RadioButton();
            this.radioButton_polling = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_dataport = new System.Windows.Forms.TextBox();
            this.textBox_communicationport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ipaddress4 = new System.Windows.Forms.TextBox();
            this.textBox_ipaddress3 = new System.Windows.Forms.TextBox();
            this.textBox_ipaddress2 = new System.Windows.Forms.TextBox();
            this.textBox_ipaddress1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_status = new System.Windows.Forms.TextBox();
            this.barcodeReaderControl1 = new Keyence.AutoID.BarcodeReaderControl();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox_readertype.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox_frequency.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox_readertype);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox_frequency);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(13, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 92);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose";
            // 
            // groupBox_readertype
            // 
            this.groupBox_readertype.Controls.Add(this.comboBox_readertype);
            this.groupBox_readertype.Controls.Add(this.label4);
            this.groupBox_readertype.Location = new System.Drawing.Point(130, 14);
            this.groupBox_readertype.Name = "groupBox_readertype";
            this.groupBox_readertype.Size = new System.Drawing.Size(162, 72);
            this.groupBox_readertype.TabIndex = 11;
            this.groupBox_readertype.TabStop = false;
            // 
            // comboBox_readertype
            // 
            this.comboBox_readertype.FormattingEnabled = true;
            this.comboBox_readertype.Location = new System.Drawing.Point(8, 42);
            this.comboBox_readertype.Name = "comboBox_readertype";
            this.comboBox_readertype.Size = new System.Drawing.Size(147, 21);
            this.comboBox_readertype.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Choose Reader Type";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button_close);
            this.groupBox5.Controls.Add(this.button_connect);
            this.groupBox5.Location = new System.Drawing.Point(299, 14);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(114, 71);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(7, 41);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(96, 23);
            this.button_close.TabIndex = 1;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(7, 16);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(96, 23);
            this.button_connect.TabIndex = 0;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // groupBox_frequency
            // 
            this.groupBox_frequency.Controls.Add(this.textBox_frequency);
            this.groupBox_frequency.Controls.Add(this.label3);
            this.groupBox_frequency.Location = new System.Drawing.Point(130, 14);
            this.groupBox_frequency.Name = "groupBox_frequency";
            this.groupBox_frequency.Size = new System.Drawing.Size(162, 72);
            this.groupBox_frequency.TabIndex = 1;
            this.groupBox_frequency.TabStop = false;
            // 
            // textBox_frequency
            // 
            this.textBox_frequency.Location = new System.Drawing.Point(9, 42);
            this.textBox_frequency.Multiline = true;
            this.textBox_frequency.Name = "textBox_frequency";
            this.textBox_frequency.Size = new System.Drawing.Size(147, 20);
            this.textBox_frequency.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Enter Frequency";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton_demand);
            this.groupBox3.Controls.Add(this.radioButton_polling);
            this.groupBox3.Location = new System.Drawing.Point(7, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(117, 72);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // radioButton_demand
            // 
            this.radioButton_demand.AutoSize = true;
            this.radioButton_demand.Location = new System.Drawing.Point(9, 45);
            this.radioButton_demand.Name = "radioButton_demand";
            this.radioButton_demand.Size = new System.Drawing.Size(73, 17);
            this.radioButton_demand.TabIndex = 1;
            this.radioButton_demand.TabStop = true;
            this.radioButton_demand.Text = "On Polling";
            this.radioButton_demand.UseVisualStyleBackColor = true;
            this.radioButton_demand.CheckedChanged += new System.EventHandler(this.radioButton_liveview_CheckedChanged);
            // 
            // radioButton_polling
            // 
            this.radioButton_polling.AutoSize = true;
            this.radioButton_polling.Location = new System.Drawing.Point(9, 19);
            this.radioButton_polling.Name = "radioButton_polling";
            this.radioButton_polling.Size = new System.Drawing.Size(82, 17);
            this.radioButton_polling.TabIndex = 0;
            this.radioButton_polling.TabStop = true;
            this.radioButton_polling.Text = "On Demand";
            this.radioButton_polling.UseVisualStyleBackColor = true;
            this.radioButton_polling.CheckedChanged += new System.EventHandler(this.radioButton_demand_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_dataport);
            this.groupBox2.Controls.Add(this.textBox_communicationport);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_ipaddress4);
            this.groupBox2.Controls.Add(this.textBox_ipaddress3);
            this.groupBox2.Controls.Add(this.textBox_ipaddress2);
            this.groupBox2.Controls.Add(this.textBox_ipaddress1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 84);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // textBox_dataport
            // 
            this.textBox_dataport.Location = new System.Drawing.Point(332, 47);
            this.textBox_dataport.Multiline = true;
            this.textBox_dataport.Name = "textBox_dataport";
            this.textBox_dataport.Size = new System.Drawing.Size(70, 20);
            this.textBox_dataport.TabIndex = 16;
            // 
            // textBox_communicationport
            // 
            this.textBox_communicationport.Location = new System.Drawing.Point(240, 47);
            this.textBox_communicationport.Multiline = true;
            this.textBox_communicationport.Name = "textBox_communicationport";
            this.textBox_communicationport.Size = new System.Drawing.Size(70, 20);
            this.textBox_communicationport.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Enter Communication and Data Port";
            // 
            // textBox_ipaddress4
            // 
            this.textBox_ipaddress4.Location = new System.Drawing.Point(141, 47);
            this.textBox_ipaddress4.Multiline = true;
            this.textBox_ipaddress4.Name = "textBox_ipaddress4";
            this.textBox_ipaddress4.Size = new System.Drawing.Size(37, 20);
            this.textBox_ipaddress4.TabIndex = 13;
            // 
            // textBox_ipaddress3
            // 
            this.textBox_ipaddress3.Location = new System.Drawing.Point(98, 47);
            this.textBox_ipaddress3.Multiline = true;
            this.textBox_ipaddress3.Name = "textBox_ipaddress3";
            this.textBox_ipaddress3.Size = new System.Drawing.Size(37, 20);
            this.textBox_ipaddress3.TabIndex = 12;
            // 
            // textBox_ipaddress2
            // 
            this.textBox_ipaddress2.Location = new System.Drawing.Point(55, 47);
            this.textBox_ipaddress2.Multiline = true;
            this.textBox_ipaddress2.Name = "textBox_ipaddress2";
            this.textBox_ipaddress2.Size = new System.Drawing.Size(37, 20);
            this.textBox_ipaddress2.TabIndex = 11;
            // 
            // textBox_ipaddress1
            // 
            this.textBox_ipaddress1.Location = new System.Drawing.Point(12, 47);
            this.textBox_ipaddress1.Multiline = true;
            this.textBox_ipaddress1.Name = "textBox_ipaddress1";
            this.textBox_ipaddress1.Size = new System.Drawing.Size(37, 20);
            this.textBox_ipaddress1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter IP Address";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_status);
            this.groupBox4.Location = new System.Drawing.Point(13, 194);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(292, 106);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // textBox_status
            // 
            this.textBox_status.Location = new System.Drawing.Point(7, 17);
            this.textBox_status.Multiline = true;
            this.textBox_status.Name = "textBox_status";
            this.textBox_status.Size = new System.Drawing.Size(278, 81);
            this.textBox_status.TabIndex = 0;
            // 
            // barcodeReaderControl1
            // 
            this.barcodeReaderControl1.BackColor = System.Drawing.Color.Black;
            this.barcodeReaderControl1.Location = new System.Drawing.Point(8, 17);
            this.barcodeReaderControl1.Name = "barcodeReaderControl1";
            this.barcodeReaderControl1.Size = new System.Drawing.Size(110, 81);
            this.barcodeReaderControl1.TabIndex = 12;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.barcodeReaderControl1);
            this.groupBox6.Location = new System.Drawing.Point(311, 194);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(124, 106);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 312);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox_readertype.ResumeLayout(false);
            this.groupBox_readertype.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox_frequency.ResumeLayout(false);
            this.groupBox_frequency.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_frequency;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton_demand;
        private System.Windows.Forms.RadioButton radioButton_polling;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_dataport;
        private System.Windows.Forms.TextBox textBox_communicationport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ipaddress4;
        private System.Windows.Forms.TextBox textBox_ipaddress3;
        private System.Windows.Forms.TextBox textBox_ipaddress2;
        private System.Windows.Forms.TextBox textBox_ipaddress1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.GroupBox groupBox_readertype;
        private System.Windows.Forms.ComboBox comboBox_readertype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_frequency;
        private System.Windows.Forms.Label label3;
        private Keyence.AutoID.BarcodeReaderControl barcodeReaderControl1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_status;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

    }
}

