using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Profilometer_Keyence.Datas;
using System.Runtime.InteropServices;
using System.Threading;

namespace Profilometer_Keyence
{
    public partial class Form1 : Form
    {

        #region Enum

        /// <summary>
        /// Send command definition
        /// </summary>
        /// <remark>Defined for separate return code distinction</remark>
        public enum SendCommand
        {
            /// <summary>None</summary>
            None,
            /// <summary>Restart</summary>
            RebootController,
            /// <summary>Trigger</summary>
            Trigger,
            /// <summary>Start measurement</summary>
            StartMeasure,
            /// <summary>Stop measurement</summary>
            StopMeasure,
            /// <summary>Auto zero</summary>
            AutoZero,
            /// <summary>Timing</summary>
            Timing,
            /// <summary>Reset</summary>
            Reset,
            /// <summary>Program switch</summary>
            ChangeActiveProgram,
            /// <summary>Get measurement results</summary>
            GetMeasurementValue,

            /// <summary>Get profiles</summary>
            GetProfile,
            /// <summary>Get batch profiles (operation mode "high-speed (profile only)")</summary>
            GetBatchProfile,
            /// <summary>Get profiles (operation mode "advanced (with OUT measurement)")</summary>
            GetProfileAdvance,
            /// <summary>Get batch profiles (operation mode "advanced (with OUT measurement)").</summary>
            GetBatchProfileAdvance,

            /// <summary>Start storage</summary>
            StartStorage,
            /// <summary>Stop storage</summary>
            StopStorage,
            /// <summary>Get storage status</summary>
            GetStorageStatus,
            /// <summary>Manual storage request</summary>
            RequestStorage,
            /// <summary>Get storage data</summary>
            GetStorageData,
            /// <summary>Get profile storage data</summary>
            GetStorageProfile,
            /// <summary>Get batch profile storage data.</summary>
            GetStorageBatchProfile,

            /// <summary>Initialize USB high-speed data communication</summary>
            HighSpeedDataUsbCommunicationInitalize,
            /// <summary>Initialize Ethernet high-speed data communication</summary>
            HighSpeedDataEthernetCommunicationInitalize,
            /// <summary>Request preparation before starting high-speed data communication</summary>
            PreStartHighSpeedDataCommunication,
            /// <summary>Start high-speed data communication</summary>
            StartHighSpeedDataCommunication,
        }

        #endregion

        #region Field

        private LJV7IF_ETHERNET_CONFIG _ethernetConfig;
        private List<MeasureData> _measureDatas;
        private int _currentDeviceId;
        private SendCommand _sendCommand;
        private HighSpeedDataCallBack _callback;
        private HighSpeedDataCallBack _callbackOnlyCount;

        private LJV7IF_PROFILE_INFO[] _profileInfo;
        private DeviceData[] _deviceData;
        private Label[] _deviceStatusLabels;
        private Label[] _receivedProfileCountLabels;

        private object lockFile = new object();
        private ThreadStart threadStart;
        private Thread thread;

        #endregion
        
        private DialogResult dialogResult;
        private string filePath;

        private void OnFocusIPAddress1(object Sender, EventArgs e)
        {
            if (Sender.Equals(textbox_ipaddress1))
            {
                textbox_ipaddress1.Text = "";
            }
            if (Sender.Equals(textbox_ipaddress2))
            {
                textbox_ipaddress2.Text = "";
            }
            if (Sender.Equals(textbox_ipaddress3))
            {
                textbox_ipaddress3.Text = "";
            }
            if (Sender.Equals(textbox_ipaddress4))
            {
                textbox_ipaddress4.Text = "";
            }
            if (Sender.Equals(textbox_hsport))
            {
                textbox_hsport.Text = "";
            }
            if (Sender.Equals(textbox_frequency))
            {
                textbox_frequency.Text = "";
            }
            if (Sender.Equals(textbox_stprofile))
            {
                textbox_stprofile.Text = "";
            }

        }
        private void OnLostFocusIPAddress1(object Sender, EventArgs e)
        {
            if (Sender.Equals(textbox_ipaddress1))
            {
                if (textbox_ipaddress1.Text.Equals(""))
                {
                    textbox_ipaddress1.Text = "192";
                }
                else if (Convert.ToInt32(textbox_ipaddress1.Text) > 255)
                {
                    textbox_ipaddress1.Text = "192";
                }
            }
            if (Sender.Equals(textbox_ipaddress2))
            {
                if (textbox_ipaddress2.Text.Equals(""))
                {
                    textbox_ipaddress2.Text = "168";
                }
                else if (Convert.ToInt32(textbox_ipaddress2.Text) > 255)
                {
                    textbox_ipaddress2.Text = "168";
                }
            }
            if (Sender.Equals(textbox_ipaddress3))
            {
                if (textbox_ipaddress3.Text.Equals(""))
                {
                    textbox_ipaddress3.Text = "1";
                }
                else if (Convert.ToInt32(textbox_ipaddress3.Text) > 255)
                {
                    textbox_ipaddress3.Text = "1";
                }
            }
            if (Sender.Equals(textbox_ipaddress4))
            {
                if (textbox_ipaddress4.Text.Equals(""))
                {
                    textbox_ipaddress4.Text = "1";
                }
                else if (Convert.ToInt32(textbox_ipaddress4.Text) > 255)
                {
                    textbox_ipaddress4.Text = "1";
                }
            }
            if (Sender.Equals(textbox_hsport))
            {
                if (textbox_hsport.Text.Equals(""))
                {
                    textbox_hsport.Text = "9003";
                }
                else if (Convert.ToInt32(textbox_hsport.Text) > 65535)
                {
                    textbox_hsport.Text = "9003";
                }
            }
            if (Sender.Equals(textbox_frequency))
            {
                if (textbox_frequency.Text.Equals(""))
                {
                    textbox_frequency.Text = "10";
                }
                else if (Convert.ToInt32(textbox_frequency.Text) > 1000)
                {
                    textbox_frequency.Text = "10";
                }
            }
            if (Sender.Equals(textbox_stprofile))
            {
                if (textbox_stprofile.Text.Equals(""))
                {
                    textbox_stprofile.Text = "2";
                }
                else if (Convert.ToInt32(textbox_stprofile.Text) > 1000)
                {
                    textbox_stprofile.Text = "2";
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            textbox_frequency.Text = "10";
            textbox_hsport.Text = "9003";
            textbox_ipaddress1.Text = "192";
            textbox_ipaddress2.Text = "168";
            textbox_ipaddress3.Text = "1";
            textbox_ipaddress4.Text = "1";
            textbox_stprofile.Text = "2";
            textbox_ipaddress1.GotFocus += OnFocusIPAddress1;
            textbox_ipaddress1.LostFocus += OnLostFocusIPAddress1;
            textbox_ipaddress2.GotFocus += OnFocusIPAddress1;
            textbox_ipaddress2.LostFocus += OnLostFocusIPAddress1;
            textbox_ipaddress3.GotFocus += OnFocusIPAddress1;
            textbox_ipaddress3.LostFocus += OnLostFocusIPAddress1;
            textbox_ipaddress4.GotFocus += OnFocusIPAddress1;
            textbox_ipaddress4.LostFocus += OnLostFocusIPAddress1;
            textbox_hsport.GotFocus += OnFocusIPAddress1;
            textbox_hsport.LostFocus += OnLostFocusIPAddress1;
            textbox_frequency.GotFocus += OnFocusIPAddress1;
            textbox_frequency.LostFocus += OnLostFocusIPAddress1;
            textbox_stprofile.GotFocus += OnFocusIPAddress1;
            textbox_stprofile.LostFocus += OnLostFocusIPAddress1;
            _callback = new HighSpeedDataCallBack(ReceiveHighSpeedData);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textbox_filename.Enabled = false;
        }
        private void button_browse_Click(object sender, EventArgs e)
        {
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Log files (*.log)|*.log";
            dialogResult=saveFileDialog1.ShowDialog();
            if (dialogResult.Equals(DialogResult.OK))
            {
                filePath=saveFileDialog1.FileName;
                string[] s = filePath.Split('\\');
                textbox_filename.Text = s[s.Length-1];
            }
        }
        private void button_connect_Click(object sender, EventArgs e)
        {
                if (textbox_filename.Text.Trim().Equals(string.Empty))
                {
                    textBox_status.AppendText("Choose File to add Sensor Data...\n");
                    return;
                }
                Rc rc2;
                NativeMethods.LJV7IF_StopHighSpeedDataCommunication(Define.DEVICE_ID);
                NativeMethods.LJV7IF_HighSpeedDataCommunicationFinalize(Define.DEVICE_ID);
                ThreadSafeBuffer.Clear(Define.DEVICE_ID);
                LJV7IF_HIGH_SPEED_PRE_START_REQ req = new LJV7IF_HIGH_SPEED_PRE_START_REQ();
                try
                {
                    _ethernetConfig.abyIpAddress = new byte[] {
						Convert.ToByte(textbox_ipaddress1.Text),
						Convert.ToByte(textbox_ipaddress2.Text),
						Convert.ToByte(textbox_ipaddress3.Text),
						Convert.ToByte(textbox_ipaddress4.Text)
					};
                    rc2 = (Rc)NativeMethods.LJV7IF_HighSpeedDataEthernetCommunicationInitalize(Define.DEVICE_ID, ref _ethernetConfig,
                        Convert.ToUInt16(textbox_hsport.Text), _callback, Convert.ToUInt32(textbox_frequency.Text), (uint)Define.DEVICE_ID);
                    if (rc2 != Rc.Ok)
                        textBox_status.AppendText("High Speed Data Communication Initialize Failed...\n");
                        return;
                    req.bySendPos = Convert.ToByte(textbox_stprofile.Text);
                }
                catch (FormatException ex)
                {
                    textBox_status.Text = ex.ToString()+"\n";
                    return;
                }
                catch (OverflowException ex)
                {
                    textBox_status.Text = ex.ToString() + "\n";
                    return;
                }
                LJV7IF_PROFILE_INFO profileInfo = new LJV7IF_PROFILE_INFO();
                rc2 = (Rc)NativeMethods.LJV7IF_PreStartHighSpeedDataCommunication(Define.DEVICE_ID, ref req, ref profileInfo);
                if (rc2 != Rc.Ok) return;

                rc2 = (Rc)NativeMethods.LJV7IF_StartHighSpeedDataCommunication(Define.DEVICE_ID);
                if (rc2 != Rc.Ok) return;
                highSpeedTimer.Start();
       }
        private void highSpeedTimer_Tick(object sender, EventArgs e)
         {
            uint notify = 0;
			int batcnNo = 0;
			List<int[]> data = ThreadSafeBuffer.Get(Define.DEVICE_ID, out notify, out batcnNo);
            StringBuilder builder = new StringBuilder();
			foreach (int[] profile in data)
			{
                for (int i = 0; i < profile.Length; i++)
                {
                    builder.Append(profile[i]+" ");
                }
                builder.Append("\n");
			}
            thread = new Thread(()=>WriteToFile(filePath,builder.ToString()));
			if ((notify & 0xFFFF) != 0)
			{
				highSpeedTimer.Stop();
			}
			if ((notify & 0x10000) != 0)
			{
                //do Nothing
			}
        }
        public static void ReceiveHighSpeedData(IntPtr buffer, uint size, uint count, uint notify, uint user)
		{
			
			uint profileSize = (uint)(size / Marshal.SizeOf(typeof(int)));
			List<int[]> receiveBuffer = new List<int[]>();
			int[] bufferArray = new int[profileSize * count];
			Marshal.Copy(buffer, bufferArray, 0, (int)(profileSize * count));

			for (int i = 0; i < count; i++)
			{
				int[] oneProfile = new int[profileSize];
				Array.Copy(bufferArray, i * profileSize, oneProfile, 0, profileSize);
				receiveBuffer.Add(oneProfile);
			}

			ThreadSafeBuffer.Add((int)user, receiveBuffer, notify);
		}
        private void button_disconnect_Click(object sender, EventArgs e)
        {
                highSpeedTimer.Stop();
                Rc rc = (Rc)NativeMethods.LJV7IF_StopHighSpeedDataCommunication(Define.DEVICE_ID);
                if (rc==Rc.Ok)
                {
                    rc = (Rc)NativeMethods.LJV7IF_HighSpeedDataCommunicationFinalize(Define.DEVICE_ID);
                    if (rc != Rc.Ok)
                    {
                        textBox_status.Text = "Cannot Finalize High Speed Data Communication...";
                        return;
                    }
                }
         }
        private void WriteToFile(string filePath,string data)
        {
            
            using (StreamWriter writer = new StreamWriter(filePath,true))
            {
                lock (lockFile)
                {
                    try
                    {
                        writer.WriteLine(data);
                        writer.Flush();
                        writer.Close();
                    }
                    catch (Exception ex)
                    {
                        textBox_status.Text = ex.ToString();
                    }
                    finally
                    {
                        if (writer != null)
                        {
                            writer.Close();
                        }
                    }
                }
            }
        }
    }
}
