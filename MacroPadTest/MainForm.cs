using System.IO.Ports;

// https://forum.arduino.cc/t/solved-c-win10-serial-terminal-missing-first-byte/1080783/4

namespace MacroPadTest
{
    public partial class MainForm : Form
    {
        // delegate to transfer received data to TextBox
        public delegate void AddDataDelegate(string myString);
        public AddDataDelegate myDelegate;

        SerialPort serialPort1 = new SerialPort();

        public MainForm()
        {
            InitializeComponent();

            serialPort1.DataReceived += SerialPort1_DataReceived;

            this.myDelegate = new AddDataDelegate(AddDataMethod);

            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();

            txtOutput.AppendText("The following serial ports were found:");

            // Display each port name to the console.
            foreach (string port in ports)
            {
                txtOutput.AppendText("  " + port);
                ToolStripMenuItem item = new ToolStripMenuItem(port);   // create a new menu item
                item.Click += ComPortsStripMenuItem_Click;  // add event handler
                comPortsStripMenuItem.DropDownItems.Add(item);  // add to the menu of COM ports
            }

            // if no COM ports were found display message
            if (comPortsStripMenuItem.DropDownItems.Count == 0)
                txtOutput.AppendText("\r\n  No COM ports found\r\n");
            else
                txtOutput.AppendText("\r\n  Found " + comPortsStripMenuItem.DropDownItems.Count + " COM ports \n");
        }

        // key on textbox pressed, read key and transmit down serial line
        private void txtOutput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (echoToolStripMenuItem.Text == "Echo ON")
                e.Handled = true; // if echo is off don't display on textbox

            if (serialPort1.IsOpen)
                serialPort1.Write(e.KeyChar.ToString());
            else
                txtOutput.AppendText("No COM port open" + Environment.NewLine);
        }

        // display seral data on textbox
        public void AddDataMethod(string myString)
        {
            txtOutput.AppendText(myString);
        }

        // data received from serial port - display on textbox
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //txtOutput.AppendText(serialPort1.ReadExisting());  // not thread safe
            string s = serialPort1.ReadExisting();
            txtOutput.Invoke(this.myDelegate, new Object[] { s });
        }

        // COM port selected
        private void ComPortsStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("item selected {0} {1}", e.ToString(), sender.ToString());
                serialPort1.Close();
                serialPort1.PortName = sender.ToString();
                serialPort1.RtsEnable = true;
                serialPort1.DtrEnable = true;
                serialPort1.Open();
                txtOutput.AppendText("Opened Port " + sender.ToString() + " baud rate " + serialPort1.BaudRate.ToString() + "\r\n");
                Text = "Port " + sender.ToString() + " baud rate " + serialPort1.BaudRate.ToString();
            }
            catch (Exception ex)
            //{ txtOutput.AppendText("Failed to open Port " + sender.ToString() + "\r\n" + ex + "\r\n"); }
            {
                txtOutput.AppendText("Failed to open Port " + sender.ToString() +
                    "\r\n   Is it already open in another program?? \r\n");
            }
            // serialPort1.RtsEnable = true;
            // serialPort1.Handshake =  Handshake.RequestToSend;
        }

        // baud rate selected
        private void baudRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("item selected {0} {1}", e.ToString(), sender.ToString());
            serialPort1.BaudRate = Convert.ToInt32(sender.ToString());
            txtOutput.AppendText('\n' + " baud rate " + serialPort1.BaudRate.ToString() + '\n');
            Text = "Port " + serialPort1.PortName.ToString() + " baud rate " + serialPort1.BaudRate.ToString();

        }

        // echo selected
        private void echoONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // invert echo ON/OFF  display
            if (echoToolStripMenuItem.Text == "Echo ON")
                echoToolStripMenuItem.Text = "Echo OFF";
            else
                echoToolStripMenuItem.Text = "Echo ON";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();
        }

        // handshake mode selected
        private void handShakeNone(object sender, EventArgs e)
        {
            serialPort1.Handshake = Handshake.None;
        }

        private void handShakeRequestToSend(object sender, EventArgs e)
        {
            serialPort1.Handshake = Handshake.RequestToSend;
        }

        private void handShakeXonXoff(object sender, EventArgs e)
        {
            serialPort1.Handshake = Handshake.XOnXOff;
        }

        private void handShakeRequestXonXoff(object sender, EventArgs e)
        {
            serialPort1.Handshake = Handshake.RequestToSendXOnXOff;
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

// COM1 MHz
// COM1 KHz

// COM2 MHz
// COM2 KHz

// NAV1 MHz
// NAV1 KHz

// NAV2 MHz
// NAV2 KHz

// ADF

// Transponder digit 1
// Transponder digit 2
// Transponder digit 3
// Transponder digit 4

// Altitude selector thousands
// Altitude selector hundreds

// Vertical speed selector

// Heading selector

// Course selector

// Speed selector

// FMS encoder inner
// FMS encoder outer

// Barometer selector

// Map range selector
