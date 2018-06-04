using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Concurrent;
using System.Threading;

namespace Rs232app
{
    public enum States : int
    {
        None, Begin, Length, Command, Data, ChecksumOne, ChecksumTwo
    }

    public enum Send : int
    {
        Reset, Dl, Phy
    }

    public partial class Form1 : Form
    {
        private SerialPort serialPort = new SerialPort();
        private Boolean isConnected = false;
        private ConcurrentQueue<char> serialDataQueue = new ConcurrentQueue<char>();
        private Boolean isStatusReceived = false;

        public Form1()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;

            PortCombo.Items.AddRange(SerialPort.GetPortNames());
            PortCombo.SelectedIndex = PortCombo.Items.Count - 1;

            BaudCombo.Items.Add(57600);
            BaudCombo.SelectedIndex = BaudCombo.Items.Count - 1;

            DataCombo.Items.Add(8);
            DataCombo.SelectedIndex = BaudCombo.Items.Count - 1;

            ParityCombo.Items.Add(Parity.None);
            ParityCombo.SelectedIndex = BaudCombo.Items.Count - 1;

            StopCombo.Items.Add(StopBits.One);
            StopCombo.SelectedIndex = BaudCombo.Items.Count - 1;

            FlowCombo.Items.Add(Handshake.None);
            FlowCombo.SelectedIndex = BaudCombo.Items.Count - 1;

            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            ConnectButton.BackColor = Color.Red;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            OutputText.Clear();

            if (isConnected)
            {
                serialPort.Close();
                ConnectButton.Text = "Connect";
                ConnectButton.BackColor = Color.Red;
                isConnected = false;
                OutputGroup.Enabled = false;
                ResetGroup.Enabled = false;
                ModemGroup.Enabled = false;
            }
            else
            {
                serialPort.PortName = PortCombo.Text;
                serialPort.BaudRate = Convert.ToInt32(BaudCombo.Text);
                serialPort.DataBits = Convert.ToInt32(DataCombo.Text);
                serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), ParityCombo.Text);
                serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), StopCombo.Text);
                serialPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), FlowCombo.Text);

                serialPort.ReadTimeout = 200;
                serialPort.WriteTimeout = 200;

                serialPort.RtsEnable = false;
                serialPort.DtrEnable = true;

                serialPort.Open();

                ConnectButton.Text = "Disconnect";
                ConnectButton.BackColor = Color.Green;
                isConnected = true;
                OutputGroup.Enabled = true;
                ResetGroup.Enabled = true;
                ModemGroup.Enabled = true;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            SendData(Send.Reset);
        }

        private void DlRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (DlRadio.Checked)
            {
                PhyRadio.Checked = false;
                SendData(Send.Dl);
            }
        }

        private void PhyRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (PhyRadio.Checked)
            {
                DlRadio.Checked = false;
                SendData(Send.Phy);
            }
        }

        private void DataReceivedHandler(
                    object sender,
                    SerialDataReceivedEventArgs e)
        {
            int bytesAvailable = serialPort.BytesToRead;

            char[] recBuf = new char[bytesAvailable];

            try
            {
                serialPort.Read(recBuf, 0, bytesAvailable);

                for (int index = 0; index < bytesAvailable; index++)
                {
                    serialDataQueue.Enqueue(recBuf[index]);
                }

            }
            catch (TimeoutException) { }
            ReadSearialDataQueue();
        }

        private void ReadSearialDataQueue()
        {
            String hexValue = String.Empty;
            States status = States.None;
            List<UInt16> frameBytesCheckList = new List<UInt16>();
            List<UInt16> recBytesCheckList = new List<UInt16>();
            Frame frame = new Frame();
            UInt16 dataLeng = 0;

            String frameBegin = String.Empty;
            String frameLength = String.Empty;
            String frameCommand = String.Empty;
            String frameCheckOne = String.Empty;
            String frameCheckTwo = String.Empty;

            int counter = 0;

            try
            {
                while (serialDataQueue.TryDequeue(out char ch))
                {
                    UInt16 V = Convert.ToUInt16(ch);
                    hexValue = String.Format("{0:x2}", V);

                    if (status == States.None && hexValue == "3f")
                    {
                        isStatusReceived = true;
                    }

                    if (status == States.None && (hexValue == "02" || hexValue == "03"))
                    {
                        frameBytesCheckList.Clear();
                        recBytesCheckList.Clear();
                        counter = 0;
                        dataLeng = 0;

                        frameBegin = String.Empty;
                        frameLength = String.Empty;
                        frameCommand = String.Empty;
                        frameCheckOne = String.Empty;
                        frameCheckTwo = String.Empty;

                        status = States.Begin;
                        frameBegin = hexValue;
                        serialPort.Write(new byte[] { 0x06 }, 0, 1);

                        continue;
                    }

                    if (status == States.Begin)
                    {
                        status = States.Length;
                        dataLeng = V;
                        frameLength = hexValue;
                        frameBytesCheckList.Add(V);

                        continue;
                    }

                    if (status == States.Length)
                    {
                        status = States.Command;
                        frameCommand = hexValue;
                        frameBytesCheckList.Add(V);

                        continue;
                    }

                    if (status == States.Command)
                    {
                        if (dataLeng != 0 && dataLeng != counter)
                        {
                            frameBytesCheckList.Add(V);
                            counter++;
                        }
                        else
                        {
                            status = States.Data;
                        }
                    }

                    if (status == States.Data)
                    {
                        status = States.ChecksumOne;
                        frameCheckOne = hexValue;
                        recBytesCheckList.Add(V);

                        continue;
                    }

                    if (status == States.ChecksumOne)
                    {
                        status = States.ChecksumTwo;
                        frameCheckTwo = hexValue;
                        recBytesCheckList.Add(V);

                        continue;
                    }

                    if (status == States.ChecksumTwo)
                    {
                        Int32 frameSum = CheckSum(frameBytesCheckList);
                        Int32 recSum = CheckSum(recBytesCheckList);

                        if (frameSum == recSum)
                        {
                            status = (int)States.None;

                            frame.Begin = frameBegin;
                            frame.Length = frameLength;
                            frame.Command = frameCommand;
                            frame.DataList = frameBytesCheckList;
                            frame.CheckSumOne = frameCheckOne;
                            frame.CheckSumTwo = frameCheckTwo;

                            this.OutputText.AppendText(frame.PrintFrame());
                        }
                        else
                        {
                            status = (int)States.None;
                        }
                        break;
                    }
                }

                OutputText.Text += "\n\n";

            }
            catch (Exception e) { e.GetBaseException(); }
        }

        private Int32 CheckSum(List<UInt16> checkSum)
        {
            Int32 returnValue = 0;

            foreach (UInt16 value in checkSum)
            {
                returnValue += value;
            }

            return returnValue;
        }

        private void SendData(Send send)
        {
            serialPort.DtrEnable = true;
            serialPort.RtsEnable = true;
            Thread.Sleep(15);

            if (isStatusReceived)
            {
                if (send == Send.Reset)
                {
                    serialPort.Write(new byte[] { 0x02, 0x00, 0x3c, 0x3c, 0x00 }, 0, 5);
                }
                else if (send == Send.Dl)
                {
                    serialPort.Write(new byte[] { 0x02, 0x02, 0x08, 0x00, 0x01, 0x0b, 0x00 }, 0, 7);
                }
                else if (send == Send.Phy)
                {
                    serialPort.Write(new byte[] { 0x02, 0x02, 0x08, 0x00, 0x00, 0x0a, 0x00 }, 0, 7);
                }

                isStatusReceived = false;

            }

            serialPort.RtsEnable = false;
            serialPort.DtrEnable = true;
        }
    }
}
