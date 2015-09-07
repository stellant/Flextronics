using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Keyence.AutoID;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Barcode_Keyence
{
    public partial class Form1 : Form
    {
        private byte ipaddress1;
        private byte ipaddress2;
        private byte ipaddress3;
        private byte ipaddress4;
        private int commandport;
        private int dataport;
        private int frequency;
        private int readertype;
        private byte[] ipaddress;
        private IPAddress ip;
        private Socket command, data;
        private IPEndPoint commandEndPoint, dataEndPoint;
        private ThreadStart threadStart;
        private Thread thread;
        private StreamWriter streamWriter;
        private BarcodeData barcodeData;
        private List<BarcodeData> barcodeList;
        private int count = 0;
        private DialogResult dialogResult;
        private string filePath;
        public Form1()
        {
            InitializeComponent();
        }

        private StreamWriter getWriter(string filePath)
        {
            if (streamWriter == null)
            {
                streamWriter = new StreamWriter(filePath,true);
            }
            return streamWriter;
        }
        private void OnFocusCommunicationPort(object Sender,EventArgs e)
        {
            textBox_communicationport.Text = "";
        }
        private void OnLostFocusCommunicationPort(object Sender, EventArgs e)
        {
            if (textBox_communicationport.Text.Equals(""))
            {
                textBox_communicationport.Text = "9003";
            }
        }
        private void OnFocusDataPort(object Sender, EventArgs e)
        {
            textBox_dataport.Text = "";
        }
        private void OnLostFocusDataPort(object Sender, EventArgs e)
        {
            if (textBox_dataport.Text.Equals(""))
            {
                textBox_dataport.Text = "9004";
            }
        }
        private void OnFocusFrequency(object Sender, EventArgs e)
        {
            textBox_frequency.Text = "";
        }
        private void OnLostFocusFrequency(object Sender, EventArgs e)
        {
            if (textBox_frequency.Text.Equals(""))
            {
                textBox_frequency.Text = "1";
            }
        }
        private void OnFocusIPAddress1(object Sender, EventArgs e)
        {
            textBox_ipaddress1.Text = "";
        }
        private void OnLostFocusIPAddress1(object Sender, EventArgs e)
        {
            if (textBox_ipaddress1.Text.Equals(""))
            {
                textBox_ipaddress1.Text = "192";
            }
            else if (Convert.ToInt32(textBox_ipaddress1.Text) > 255)
            {
                textBox_ipaddress1.Text = "192";
            }
        }
        private void OnFocusIPAddress2(object Sender, EventArgs e)
        {
            textBox_ipaddress2.Text = "";
        }
        private void OnLostFocusIPAddress2(object Sender, EventArgs e)
        {
            if (textBox_ipaddress2.Text.Equals(""))
            {
                textBox_ipaddress2.Text = "168";
            }
            else if (Convert.ToInt32(textBox_ipaddress2.Text) > 255)
            {
                textBox_ipaddress2.Text = "168";
            }
        }
        private void OnFocusIPAddress3(object Sender, EventArgs e)
        {
            textBox_ipaddress3.Text = "";
        }
        private void OnLostFocusIPAddress3(object Sender, EventArgs e)
        {
            if (textBox_ipaddress3.Text.Equals(""))
            {
                textBox_ipaddress3.Text = "1";
            }
            else if (Convert.ToInt32(textBox_ipaddress3.Text) > 255)
            {
                textBox_ipaddress3.Text = "1";
            }
        }
        private void OnFocusIPAddress4(object Sender, EventArgs e)
        {
            textBox_ipaddress4.Text = "";
        }
        private void OnLostFocusIPAddress4(object Sender, EventArgs e)
        {
            if (textBox_ipaddress4.Text.Equals(""))
            {
                textBox_ipaddress4.Text = "1";
            }
            else if(Convert.ToInt32(textBox_ipaddress4.Text)>255)
            {
                textBox_ipaddress4.Text = "1";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox_frequency.Visible = false;
            groupBox_readertype.Visible = false;
            radioButton_polling.Checked = true;
            radioButton_demand.Checked = false;
            comboBox_readertype.Items.Add(ReaderType.SR_700.ToString());
            comboBox_readertype.Items.Add(ReaderType.SR_750.ToString());
            comboBox_readertype.Items.Add(ReaderType.SR_1000.ToString());
            comboBox_readertype.Items.Add(ReaderType.SR_D100.ToString());
            comboBox_readertype.SelectedIndex = 1;
            textBox_ipaddress1.Text = "192";
            textBox_ipaddress2.Text = "168";
            textBox_ipaddress3.Text = "1";
            textBox_ipaddress4.Text = "1";
            textBox_communicationport.Text = "9003";
            textBox_dataport.Text = "9004";
            textBox_frequency.Text = "1";
            textBox_communicationport.GotFocus += OnFocusCommunicationPort;
            textBox_communicationport.LostFocus += OnLostFocusCommunicationPort;
            textBox_dataport.GotFocus += OnFocusDataPort;
            textBox_dataport.LostFocus += OnLostFocusDataPort;
            textBox_frequency.GotFocus += OnFocusFrequency;
            textBox_frequency.LostFocus += OnLostFocusFrequency;
            textBox_ipaddress1.GotFocus += OnFocusIPAddress1;
            textBox_ipaddress1.LostFocus += OnLostFocusIPAddress1;
            textBox_ipaddress2.GotFocus += OnFocusIPAddress2;
            textBox_ipaddress2.LostFocus += OnLostFocusIPAddress2;
            textBox_ipaddress3.GotFocus += OnFocusIPAddress3;
            textBox_ipaddress3.LostFocus += OnLostFocusIPAddress3;
            textBox_ipaddress4.GotFocus += OnFocusIPAddress4;
            textBox_ipaddress4.LostFocus += OnLostFocusIPAddress4;
        }

        private void radioButton_demand_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_polling.Checked == true)
            {
                groupBox_frequency.Visible = true;
                groupBox_readertype.Visible = false;
            }
            else if (radioButton_polling.Checked == false)
            {
                groupBox_frequency.Visible = false;
                groupBox_readertype.Visible = true;
            }
        }

        private void radioButton_liveview_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_demand.Checked == true)
            {
                groupBox_readertype.Visible = true;
            }
            else if (radioButton_demand.Checked == false)
            {
                groupBox_readertype.Visible = true;
            }
        }

        public Socket getData()
        {
            return data;
        }
        public TextBox getTextBoxStatus()
        {
            return textBox_status;
        }
        private void button_connect_Click(object sender, EventArgs e)
        {
            dialogResult = new DialogResult();
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog().Equals(DialogResult.OK))
            {
                filePath = saveFileDialog1.FileName;
                textBox_status.Text = "Data will be written to "+filePath+"     \n";
                if (radioButton_polling.Checked == true)
                {
                    try
                    {
                        ipaddress = new byte[4];
                        ipaddress[0] = Convert.ToByte(textBox_ipaddress1.Text.Trim());
                        ipaddress[1] = Convert.ToByte(textBox_ipaddress2.Text.Trim());
                        ipaddress[2] = Convert.ToByte(textBox_ipaddress3.Text.Trim());
                        ipaddress[3] = Convert.ToByte(textBox_ipaddress4.Text.Trim());
                        commandport = Convert.ToInt32(textBox_communicationport.Text.Trim());
                        dataport = Convert.ToInt32(textBox_dataport.Text.Trim());
                        frequency = Convert.ToInt32(textBox_frequency.Text.Trim());
                        ip = new IPAddress(ipaddress);
                        commandEndPoint = new IPEndPoint(ip, commandport);
                        dataEndPoint = new IPEndPoint(ip, dataport);
                        if (command != null)
                        {
                            command.Close();
                        }
                        if (data != null)
                        {
                            data.Close();
                        }
                        command = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        try
                        {
                            textBox_status.AppendText("Command Socket Connecting...\n");
                            button_connect.Enabled = false;
                            command.Connect(commandEndPoint);
                            button_connect.Enabled = true;
                            textBox_status.AppendText("Command Socket Connected...\n");
                        }
                        catch (SocketException ex)
                        {
                            textBox_status.AppendText(ex.ToString() + "\n");
                            button_connect.Enabled = true;
                            return;
                        }
                        data = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        try
                        {
                            textBox_status.AppendText("Data Socket Connecting...\n");
                            button_connect.Enabled = false;
                            data.Connect(dataEndPoint);
                            button_connect.Enabled = true;
                            textBox_status.AppendText("Data Socket Connected...\n");
                        }
                        catch (SocketException ex)
                        {
                            textBox_status.AppendText(ex.ToString() + "\n");
                            button_connect.Enabled = false;
                            return;
                        }
                        timer1.Interval = frequency;
                        timer1.Start();
                    }
                    catch (Exception ex)
                    {
                        textBox_status.AppendText(ex.ToString() + "\n");
                        button_connect.Enabled = true;
                        command = null;
                        data = null;
                        return;
                    }
                }
                if (radioButton_demand.Checked == true)
                {
                    try
                    {
                        ipaddress = new byte[4];
                        ipaddress[0] = Convert.ToByte(textBox_ipaddress1.Text.Trim());
                        ipaddress[1] = Convert.ToByte(textBox_ipaddress2.Text.Trim());
                        ipaddress[2] = Convert.ToByte(textBox_ipaddress3.Text.Trim());
                        ipaddress[3] = Convert.ToByte(textBox_ipaddress4.Text.Trim());
                        commandport = Convert.ToInt32(textBox_communicationport.Text.Trim());
                        dataport = Convert.ToInt32(textBox_dataport.Text.Trim());
                        ip = new IPAddress(ipaddress);
                        this.barcodeReaderControl1.IpAddress = ip.ToString();
                        this.barcodeReaderControl1.Ether.CommandPort = commandport;
                        this.barcodeReaderControl1.Ether.DataPort = dataport;
                        this.barcodeReaderControl1.Comm.Interface = Interface.Ethernet;
                        if (comboBox_readertype.SelectedItem.ToString().Equals(ReaderType.SR_750.ToString()))
                        {
                            this.barcodeReaderControl1.ReaderType = ReaderType.SR_750;
                        }
                        else if (comboBox_readertype.SelectedItem.ToString().Equals(ReaderType.SR_700.ToString()))
                        {
                            this.barcodeReaderControl1.ReaderType = ReaderType.SR_700;
                        }
                        else if (comboBox_readertype.SelectedItem.ToString().Equals(ReaderType.SR_1000.ToString()))
                        {
                            this.barcodeReaderControl1.ReaderType = ReaderType.SR_1000;
                        }
                        else if (comboBox_readertype.SelectedItem.ToString().Equals(ReaderType.SR_D100.ToString()))
                        {
                            this.barcodeReaderControl1.ReaderType = ReaderType.SR_D100;
                        }
                        else
                        {
                            this.barcodeReaderControl1.ReaderType = ReaderType.SR_750;
                        }
                        textBox_status.AppendText("Socket Connecting...\n");
                        this.barcodeReaderControl1.Connect();
                        textBox_status.AppendText("Socket Connected...\n");
                        this.barcodeReaderControl1.OnDataReceived += dataReceived;
                        textBox_status.AppendText("Live View Starting...\n");
                        this.barcodeReaderControl1.StartLiveView();
                        textBox_status.AppendText("Live View Started...\n");
                    }
                    catch (SocketException ex)
                    {
                        textBox_status.AppendText(ex.ToString() + "\n");
                    }
                    catch (Exception ex)
                    {
                        textBox_status.AppendText(ex.ToString() + "\n");
                    }
                }
            }
            else
            {
                return;
            }
            
            

                
            
        }

        private void dataReceived(object sender,OnDataReceivedEventArgs e)
        {
            try
            {
                barcodeData = new BarcodeData();
                barcodeData.DataBytes = e.data;
                getWriter(filePath).WriteLine(barcodeData.ToString() + " " + new DateTime());
                getWriter(filePath).Flush();
                textBox_status.AppendText(barcodeData.ToString());
            }
            catch (Exception ex)
            {
                textBox_status.AppendText(ex.ToString() + "\n");
            }
            finally
            {
                getWriter(filePath).Close();
            }
        }
        private void button_close_Click(object sender, EventArgs e)
        {
                if (radioButton_polling.Checked == true)
                {
                    try
                    {
                        if (command != null)
                        {
                            command.Close();
                            commandEndPoint = null;
                            command = null;
                            textBox_status.AppendText("Command Socket Closed...\n");
                        }
                        if (data != null)
                        {
                            data.Close();
                            dataEndPoint = null;
                            data = null;
                            textBox_status.AppendText("Data Socket Closed...\n");
                        }
                        if (thread != null)
                        {
                            thread.Interrupt();
                        }
                        if (streamWriter != null)
                        {
                            streamWriter.Close();
                        }
                    }
                    catch (SocketException ex)
                    {
                        textBox_status.AppendText(ex.ToString() + "\n");
                    }
                    catch (ThreadInterruptedException ex)
                    {
                        textBox_status.AppendText(ex.ToString() + "\n");
                    }
                    catch (Exception ex)
                    {
                        textBox_status.AppendText(ex.ToString() + "\n");
                    }
                }
                if (radioButton_demand.Checked == true)
                {
                    try
                    {
                        this.barcodeReaderControl1.OnDataReceived -= dataReceived;
                        this.barcodeReaderControl1.StopLiveView();
                        this.barcodeReaderControl1.Disconnect();
                        textBox_status.AppendText("Socked Closed...\n");
                    }
                    catch (Exception ex)
                    {
                        textBox_status.AppendText(ex.ToString() + "\n");
                    }
                }
            
        }
        private BarcodeData readDataDemand()
        {
            BarcodeData bCode = new BarcodeData();
            Byte[] dataByte = new Byte[10240];
            int size = 0;
            while (true)
            {
                try
                {
                    if (data != null)
                    {
                        size = data.Receive(dataByte);
                        if (size > 0)
                        {
                            bCode.DataBytes = dataByte;    
                        }
                    }
                }
                catch (SocketException ex)
                {
                    textBox_status.AppendText(ex.ToString() + "\n");
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                getWriter(filePath).WriteLine(readDataDemand().ToString() + " " + DateTime.Now.ToString());
                getWriter(filePath).Flush();
                textBox_status.AppendText(readDataDemand().ToString());
            }
            catch (Exception ex)
            {
                textBox_status.AppendText(ex.ToString() + "\n");
                timer1.Stop();
            }
            finally
            {
                getWriter(filePath).Close();
            }
        }
    }
}
