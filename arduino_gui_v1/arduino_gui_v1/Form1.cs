using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace arduino_gui_v1
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort_1;

        private int[] startPositions = new int[4];
        private int[] middlePositions = new int[4]; 
        private int[] dropPositions = new int[4];
        private int[] endPositions = new int[4];
        private CancellationTokenSource cts;


        public Form1()
        {
            InitializeComponent();
            // Initialize the serial port
            serialPort_1 = new SerialPort("COM3", 9600);
            serialPort_1.Open();

        }

        private void ServoAngle_Click(object sender, EventArgs e)
        {
            try
            {
                var commands = new List<string>();


                if (checkBox1.Checked)
                {
                    int angle1 = int.Parse(textBox1.Text);
                    if (angle1 >= 0 && angle1 <= 180)
                    {
                        commands.Add($"S0{angle1:D3}");
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid angle (0-180) for Servo 1.");
                        return;
                    }
                }

                if (checkBox2.Checked)
                {
                    int angle2 = int.Parse(textBox2.Text);
                    if (angle2 >= 0 && angle2 <= 180)
                    {
                        commands.Add($"S1{angle2:D3}");
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid angle (0-180) for Servo 2.");
                        return;
                    }
                }

                if (checkBox3.Checked)
                {
                    int angle3 = int.Parse(textBox3.Text);
                    if (angle3 >= 0 && angle3 <= 180)
                    {
                        commands.Add($"S2{angle3:D3}");
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid angle (0-180) for Servo 3.");
                        return;
                    }
                }

                if (checkBox4.Checked)
                {
                    int angle4 = int.Parse(textBox4.Text);
                    if (angle4 >= 0 && angle4 <= 180)
                    {
                        commands.Add($"S3{angle4:D3}");
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid angle (0-180) for Servo 4.");
                        return;
                    }
                }

                // Send all the commands
                foreach (var command in commands)
                {
                    serialPort_1.WriteLine(command);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numerical values.");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (serialPort_1.IsOpen)
            {
                serialPort_1.Close();
            }
            base.OnFormClosing(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort_1.IsOpen)
            {
                serialPort_1.WriteLine("on");
            }
            else
            {
                MessageBox.Show("Serial port is not open");
            }
        }

        private void onButton_Click(object sender, EventArgs e)
        {
            if (serialPort_1.IsOpen)
            {
                serialPort_1.WriteLine("off");
            }
            else
            {
                MessageBox.Show("Serial port is not open");
            }
        }

        private void servoClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            //checkBox1.Checked = false;
            //checkBox2.Checked = false;
            //checkBox3.Checked = false;
            //checkBox4.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }
        private void checkBox2_CheckedChanged(object sender, EventArgs e) { }
        private void checkBox3_CheckedChanged(object sender, EventArgs e) { }
        private void checkBox4_CheckedChanged(object sender, EventArgs e) { }



        private async void Process_START_BTN_Click(object sender, EventArgs e)
        {
            Process_START_BTN.Enabled = false;
            Process_END_BTN.Enabled = true; 

            try
            {
             
                startPositions[0] = int.Parse(Process_TB1.Text);
                startPositions[1] = int.Parse(Process_TB2.Text);
                startPositions[2] = int.Parse(Process_TB3.Text);
                startPositions[3] = int.Parse(Process_TB4.Text);

                middlePositions[0] = int.Parse(Process_TB5.Text);
                middlePositions[1] = int.Parse(Process_TB6.Text);
                middlePositions[2] = int.Parse(Process_TB7.Text);
                middlePositions[3] = int.Parse(Process_TB8.Text);

                dropPositions[0] = int.Parse(Process_TB9.Text);
                dropPositions[1] = int.Parse(Process_TB10.Text);
                dropPositions[2] = int.Parse(Process_TB11.Text);
                dropPositions[3] = int.Parse(Process_TB12.Text);

                endPositions[0] = int.Parse(Process_TB13.Text);
                endPositions[1] = int.Parse(Process_TB14.Text);
                endPositions[2] = int.Parse(Process_TB15.Text);
                endPositions[3] = int.Parse(Process_TB16.Text);

                int loopCount = int.Parse(Process_Loop_TB.Text);

                cts = new CancellationTokenSource();
                var token = cts.Token;

                Process_Progress_based_on_loop.Maximum = loopCount;
                Process_Progress_based_on_loop.Value = 0;

                await LoopProcess(loopCount, token);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numerical values for positions.");
            }
            catch (OverflowException)
            {
                MessageBox.Show("One or more input values is too large.");
            }
            finally
            {
       
                Process_START_BTN.Enabled = true;
            }
        }

        private void Process_END_BTN_Click(object sender, EventArgs e)
        {
      
            Process_START_BTN.Enabled = true;
            Process_END_BTN.Enabled = false; 

            if (cts != null)
            {
                cts.Cancel();
            }
        }

        private async Task LoopProcess(int loopCount, CancellationToken token)
        {
            try
            {
                for (int i = 0; i < loopCount; i++)
                {

                    // Check if cancellation is requested
                    token.ThrowIfCancellationRequested();

                    setElectromagnet(true);

                    SendPositions(startPositions);
                    await Task.Delay(1500, token); 

                    SendPositions(middlePositions);
                    await Task.Delay(1500, token);

                    SendPositions(dropPositions);
                    await Task.Delay(1500, token);

                    await Task.Delay(100, token);
                    setElectromagnet(false);

                    SendPositions(endPositions);
                    await Task.Delay(1600, token); 




                    Process_Progress_based_on_loop.PerformStep();
                }
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Process was stopped.");
            }
        }

        private void SendPositions(int[] positions)
        {
            var commands = new List<string>();

            for (int i = 0; i < 4; i++)
            {
                if (this.Controls.Find($"Process_CB{i + 1}", true).FirstOrDefault() is CheckBox checkBox && checkBox.Checked)
                {
                    if (positions[i] >= 0 && positions[i] <= 180)
                    {
                        commands.Add($"S{i}{positions[i]:D3}");
                    }
                    else
                    {
                        MessageBox.Show($"Please enter a valid angle (0-180) for Servo {i + 1}.");
                        return;
                    }
                }
            }

            // Send all the commands
            foreach (var command in commands)
            {
                if (serialPort_1.IsOpen)
                {
                    serialPort_1.WriteLine(command);
                }
            }
        }

        private void setElectromagnet(bool state)
        {
            if (serialPort_1.IsOpen)
            {
                string command = state ? "on" : "off";
                serialPort_1.WriteLine(command);
            }
        }

        private void Process_EM_ON_Click(object sender, EventArgs e)
        {
            setElectromagnet(true);
        }

        private void Process_EM_OFF_Click(object sender, EventArgs e)
        {
            setElectromagnet(false);
        }
    }
}
