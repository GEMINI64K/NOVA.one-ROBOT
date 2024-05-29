namespace arduino_gui_v1
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
        /// 

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.ServoAngle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.servoClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.onButton = new System.Windows.Forms.Button();
            this.offButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Process_CB16 = new System.Windows.Forms.CheckBox();
            this.Process_CB15 = new System.Windows.Forms.CheckBox();
            this.Process_CB14 = new System.Windows.Forms.CheckBox();
            this.Process_CB13 = new System.Windows.Forms.CheckBox();
            this.Process_TB16 = new System.Windows.Forms.TextBox();
            this.Process_TB15 = new System.Windows.Forms.TextBox();
            this.Process_TB14 = new System.Windows.Forms.TextBox();
            this.Process_TB13 = new System.Windows.Forms.TextBox();
            this.SET_MID = new System.Windows.Forms.Button();
            this.Process_CB12 = new System.Windows.Forms.CheckBox();
            this.Process_CB11 = new System.Windows.Forms.CheckBox();
            this.Process_CB10 = new System.Windows.Forms.CheckBox();
            this.Process_CB9 = new System.Windows.Forms.CheckBox();
            this.Process_TB12 = new System.Windows.Forms.TextBox();
            this.Process_TB11 = new System.Windows.Forms.TextBox();
            this.Process_TB10 = new System.Windows.Forms.TextBox();
            this.Process_TB9 = new System.Windows.Forms.TextBox();
            this.LOOP_BTN = new System.Windows.Forms.Button();
            this.SET_END = new System.Windows.Forms.Button();
            this.SET_START = new System.Windows.Forms.Button();
            this.Process_Loop_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Process_Progress_based_on_loop = new System.Windows.Forms.ProgressBar();
            this.Process_END_BTN = new System.Windows.Forms.Button();
            this.Process_START_BTN = new System.Windows.Forms.Button();
            this.Process_CB8 = new System.Windows.Forms.CheckBox();
            this.Process_CB7 = new System.Windows.Forms.CheckBox();
            this.Process_CB6 = new System.Windows.Forms.CheckBox();
            this.Process_CB5 = new System.Windows.Forms.CheckBox();
            this.Process_TB8 = new System.Windows.Forms.TextBox();
            this.Process_TB7 = new System.Windows.Forms.TextBox();
            this.Process_CB4 = new System.Windows.Forms.CheckBox();
            this.Process_CB3 = new System.Windows.Forms.CheckBox();
            this.Process_CB2 = new System.Windows.Forms.CheckBox();
            this.Process_CB1 = new System.Windows.Forms.CheckBox();
            this.Process_TB6 = new System.Windows.Forms.TextBox();
            this.Process_TB5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Process_TB4 = new System.Windows.Forms.TextBox();
            this.Process_TB3 = new System.Windows.Forms.TextBox();
            this.Process_TB2 = new System.Windows.Forms.TextBox();
            this.Process_TB1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // ServoAngle
            // 
            this.ServoAngle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ServoAngle.Location = new System.Drawing.Point(15, 146);
            this.ServoAngle.Name = "ServoAngle";
            this.ServoAngle.Size = new System.Drawing.Size(100, 29);
            this.ServoAngle.TabIndex = 2;
            this.ServoAngle.Text = "Send Angle";
            this.ServoAngle.UseVisualStyleBackColor = true;
            this.ServoAngle.Click += new System.EventHandler(this.ServoAngle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 90);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(15, 118);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.servoClear);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.ServoAngle);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 184);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servo Control";
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(121, 33);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "SERVO(1)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(121, 64);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(115, 22);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "SERVO(2)";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.Location = new System.Drawing.Point(121, 92);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(115, 20);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "SERVO(3)";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.Location = new System.Drawing.Point(121, 120);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(115, 20);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "SERVO(4)";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // servoClear
            // 
            this.servoClear.Location = new System.Drawing.Point(121, 146);
            this.servoClear.Name = "servoClear";
            this.servoClear.Size = new System.Drawing.Size(100, 29);
            this.servoClear.TabIndex = 15;
            this.servoClear.Text = "CLEAR";
            this.servoClear.UseVisualStyleBackColor = true;
            this.servoClear.Click += new System.EventHandler(this.servoClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.onButton);
            this.groupBox2.Controls.Add(this.offButton);
            this.groupBox2.Location = new System.Drawing.Point(328, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 185);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Electromagnet";
            // 
            // onButton
            // 
            this.onButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.onButton.Location = new System.Drawing.Point(25, 62);
            this.onButton.Name = "onButton";
            this.onButton.Size = new System.Drawing.Size(100, 23);
            this.onButton.TabIndex = 1;
            this.onButton.Text = "OFF";
            this.onButton.UseVisualStyleBackColor = true;
            this.onButton.Click += new System.EventHandler(this.onButton_Click);
            // 
            // offButton
            // 
            this.offButton.ForeColor = System.Drawing.Color.Red;
            this.offButton.Location = new System.Drawing.Point(25, 33);
            this.offButton.Name = "offButton";
            this.offButton.Size = new System.Drawing.Size(100, 23);
            this.offButton.TabIndex = 0;
            this.offButton.Text = "ON";
            this.offButton.UseVisualStyleBackColor = true;
            this.offButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.Process_CB16);
            this.groupBox3.Controls.Add(this.Process_CB15);
            this.groupBox3.Controls.Add(this.Process_CB14);
            this.groupBox3.Controls.Add(this.Process_CB13);
            this.groupBox3.Controls.Add(this.Process_TB16);
            this.groupBox3.Controls.Add(this.Process_TB15);
            this.groupBox3.Controls.Add(this.Process_TB14);
            this.groupBox3.Controls.Add(this.Process_TB13);
            this.groupBox3.Controls.Add(this.SET_MID);
            this.groupBox3.Controls.Add(this.Process_CB12);
            this.groupBox3.Controls.Add(this.Process_CB11);
            this.groupBox3.Controls.Add(this.Process_CB10);
            this.groupBox3.Controls.Add(this.Process_CB9);
            this.groupBox3.Controls.Add(this.Process_TB12);
            this.groupBox3.Controls.Add(this.Process_TB11);
            this.groupBox3.Controls.Add(this.Process_TB10);
            this.groupBox3.Controls.Add(this.Process_TB9);
            this.groupBox3.Controls.Add(this.LOOP_BTN);
            this.groupBox3.Controls.Add(this.SET_END);
            this.groupBox3.Controls.Add(this.SET_START);
            this.groupBox3.Controls.Add(this.Process_Loop_TB);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.Process_Progress_based_on_loop);
            this.groupBox3.Controls.Add(this.Process_END_BTN);
            this.groupBox3.Controls.Add(this.Process_START_BTN);
            this.groupBox3.Controls.Add(this.Process_CB8);
            this.groupBox3.Controls.Add(this.Process_CB7);
            this.groupBox3.Controls.Add(this.Process_CB6);
            this.groupBox3.Controls.Add(this.Process_CB5);
            this.groupBox3.Controls.Add(this.Process_TB8);
            this.groupBox3.Controls.Add(this.Process_TB7);
            this.groupBox3.Controls.Add(this.Process_CB4);
            this.groupBox3.Controls.Add(this.Process_CB3);
            this.groupBox3.Controls.Add(this.Process_CB2);
            this.groupBox3.Controls.Add(this.Process_CB1);
            this.groupBox3.Controls.Add(this.Process_TB6);
            this.groupBox3.Controls.Add(this.Process_TB5);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.Process_TB4);
            this.groupBox3.Controls.Add(this.Process_TB3);
            this.groupBox3.Controls.Add(this.Process_TB2);
            this.groupBox3.Controls.Add(this.Process_TB1);
            this.groupBox3.Location = new System.Drawing.Point(12, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(675, 356);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Process Modeling";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 47;
            this.button1.Text = "SET DROP";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Process_CB16
            // 
            this.Process_CB16.AutoSize = true;
            this.Process_CB16.Location = new System.Drawing.Point(592, 127);
            this.Process_CB16.Name = "Process_CB16";
            this.Process_CB16.Size = new System.Drawing.Size(45, 20);
            this.Process_CB16.TabIndex = 46;
            this.Process_CB16.Text = "S4";
            this.Process_CB16.UseVisualStyleBackColor = true;
            // 
            // Process_CB15
            // 
            this.Process_CB15.AutoSize = true;
            this.Process_CB15.Location = new System.Drawing.Point(592, 101);
            this.Process_CB15.Name = "Process_CB15";
            this.Process_CB15.Size = new System.Drawing.Size(45, 20);
            this.Process_CB15.TabIndex = 45;
            this.Process_CB15.Text = "S3";
            this.Process_CB15.UseVisualStyleBackColor = true;
            // 
            // Process_CB14
            // 
            this.Process_CB14.AutoSize = true;
            this.Process_CB14.Location = new System.Drawing.Point(592, 72);
            this.Process_CB14.Name = "Process_CB14";
            this.Process_CB14.Size = new System.Drawing.Size(45, 20);
            this.Process_CB14.TabIndex = 44;
            this.Process_CB14.Text = "S2";
            this.Process_CB14.UseVisualStyleBackColor = true;
            // 
            // Process_CB13
            // 
            this.Process_CB13.AutoSize = true;
            this.Process_CB13.Location = new System.Drawing.Point(592, 43);
            this.Process_CB13.Name = "Process_CB13";
            this.Process_CB13.Size = new System.Drawing.Size(45, 20);
            this.Process_CB13.TabIndex = 43;
            this.Process_CB13.Text = "S1";
            this.Process_CB13.UseVisualStyleBackColor = true;
            // 
            // Process_TB16
            // 
            this.Process_TB16.Location = new System.Drawing.Point(486, 125);
            this.Process_TB16.Name = "Process_TB16";
            this.Process_TB16.Size = new System.Drawing.Size(100, 22);
            this.Process_TB16.TabIndex = 42;
            // 
            // Process_TB15
            // 
            this.Process_TB15.Location = new System.Drawing.Point(486, 97);
            this.Process_TB15.Name = "Process_TB15";
            this.Process_TB15.Size = new System.Drawing.Size(100, 22);
            this.Process_TB15.TabIndex = 41;
            // 
            // Process_TB14
            // 
            this.Process_TB14.Location = new System.Drawing.Point(486, 69);
            this.Process_TB14.Name = "Process_TB14";
            this.Process_TB14.Size = new System.Drawing.Size(100, 22);
            this.Process_TB14.TabIndex = 40;
            // 
            // Process_TB13
            // 
            this.Process_TB13.Location = new System.Drawing.Point(486, 41);
            this.Process_TB13.Name = "Process_TB13";
            this.Process_TB13.Size = new System.Drawing.Size(100, 22);
            this.Process_TB13.TabIndex = 39;
            // 
            // SET_MID
            // 
            this.SET_MID.Location = new System.Drawing.Point(172, 153);
            this.SET_MID.Name = "SET_MID";
            this.SET_MID.Size = new System.Drawing.Size(100, 33);
            this.SET_MID.TabIndex = 38;
            this.SET_MID.Text = "SET MID";
            this.SET_MID.UseVisualStyleBackColor = true;
            // 
            // Process_CB12
            // 
            this.Process_CB12.AutoSize = true;
            this.Process_CB12.Location = new System.Drawing.Point(435, 127);
            this.Process_CB12.Name = "Process_CB12";
            this.Process_CB12.Size = new System.Drawing.Size(45, 20);
            this.Process_CB12.TabIndex = 37;
            this.Process_CB12.Text = "S4";
            this.Process_CB12.UseVisualStyleBackColor = true;
            // 
            // Process_CB11
            // 
            this.Process_CB11.AutoSize = true;
            this.Process_CB11.Location = new System.Drawing.Point(435, 101);
            this.Process_CB11.Name = "Process_CB11";
            this.Process_CB11.Size = new System.Drawing.Size(45, 20);
            this.Process_CB11.TabIndex = 36;
            this.Process_CB11.Text = "S3";
            this.Process_CB11.UseVisualStyleBackColor = true;
            // 
            // Process_CB10
            // 
            this.Process_CB10.AutoSize = true;
            this.Process_CB10.Location = new System.Drawing.Point(435, 72);
            this.Process_CB10.Name = "Process_CB10";
            this.Process_CB10.Size = new System.Drawing.Size(45, 20);
            this.Process_CB10.TabIndex = 35;
            this.Process_CB10.Text = "S2";
            this.Process_CB10.UseVisualStyleBackColor = true;
            // 
            // Process_CB9
            // 
            this.Process_CB9.AutoSize = true;
            this.Process_CB9.Location = new System.Drawing.Point(435, 43);
            this.Process_CB9.Name = "Process_CB9";
            this.Process_CB9.Size = new System.Drawing.Size(45, 20);
            this.Process_CB9.TabIndex = 34;
            this.Process_CB9.Text = "S1";
            this.Process_CB9.UseVisualStyleBackColor = true;
            // 
            // Process_TB12
            // 
            this.Process_TB12.Location = new System.Drawing.Point(329, 125);
            this.Process_TB12.Name = "Process_TB12";
            this.Process_TB12.Size = new System.Drawing.Size(100, 22);
            this.Process_TB12.TabIndex = 33;
            // 
            // Process_TB11
            // 
            this.Process_TB11.Location = new System.Drawing.Point(329, 99);
            this.Process_TB11.Name = "Process_TB11";
            this.Process_TB11.Size = new System.Drawing.Size(100, 22);
            this.Process_TB11.TabIndex = 32;
            // 
            // Process_TB10
            // 
            this.Process_TB10.Location = new System.Drawing.Point(329, 69);
            this.Process_TB10.Name = "Process_TB10";
            this.Process_TB10.Size = new System.Drawing.Size(100, 22);
            this.Process_TB10.TabIndex = 31;
            // 
            // Process_TB9
            // 
            this.Process_TB9.Location = new System.Drawing.Point(329, 41);
            this.Process_TB9.Name = "Process_TB9";
            this.Process_TB9.Size = new System.Drawing.Size(100, 22);
            this.Process_TB9.TabIndex = 30;
            // 
            // LOOP_BTN
            // 
            this.LOOP_BTN.Location = new System.Drawing.Point(435, 279);
            this.LOOP_BTN.Name = "LOOP_BTN";
            this.LOOP_BTN.Size = new System.Drawing.Size(100, 48);
            this.LOOP_BTN.TabIndex = 29;
            this.LOOP_BTN.Text = "LOOP";
            this.LOOP_BTN.UseVisualStyleBackColor = true;
            // 
            // SET_END
            // 
            this.SET_END.Location = new System.Drawing.Point(486, 153);
            this.SET_END.Name = "SET_END";
            this.SET_END.Size = new System.Drawing.Size(100, 33);
            this.SET_END.TabIndex = 28;
            this.SET_END.Text = "SET END";
            this.SET_END.UseVisualStyleBackColor = true;
            // 
            // SET_START
            // 
            this.SET_START.Location = new System.Drawing.Point(15, 153);
            this.SET_START.Name = "SET_START";
            this.SET_START.Size = new System.Drawing.Size(100, 33);
            this.SET_START.TabIndex = 27;
            this.SET_START.Text = "SET START";
            this.SET_START.UseVisualStyleBackColor = true;
            // 
            // Process_Loop_TB
            // 
            this.Process_Loop_TB.Location = new System.Drawing.Point(435, 225);
            this.Process_Loop_TB.Multiline = true;
            this.Process_Loop_TB.Name = "Process_Loop_TB";
            this.Process_Loop_TB.Size = new System.Drawing.Size(100, 48);
            this.Process_Loop_TB.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "process completion";
            // 
            // Process_Progress_based_on_loop
            // 
            this.Process_Progress_based_on_loop.ForeColor = System.Drawing.Color.LimeGreen;
            this.Process_Progress_based_on_loop.Location = new System.Drawing.Point(6, 279);
            this.Process_Progress_based_on_loop.Name = "Process_Progress_based_on_loop";
            this.Process_Progress_based_on_loop.Size = new System.Drawing.Size(423, 48);
            this.Process_Progress_based_on_loop.TabIndex = 20;
            // 
            // Process_END_BTN
            // 
            this.Process_END_BTN.ForeColor = System.Drawing.Color.Red;
            this.Process_END_BTN.Location = new System.Drawing.Point(555, 279);
            this.Process_END_BTN.Name = "Process_END_BTN";
            this.Process_END_BTN.Size = new System.Drawing.Size(100, 48);
            this.Process_END_BTN.TabIndex = 19;
            this.Process_END_BTN.Text = "End Process";
            this.Process_END_BTN.UseVisualStyleBackColor = true;
            this.Process_END_BTN.Click += new System.EventHandler(this.Process_END_BTN_Click);
            // 
            // Process_START_BTN
            // 
            this.Process_START_BTN.ForeColor = System.Drawing.Color.Green;
            this.Process_START_BTN.Location = new System.Drawing.Point(555, 225);
            this.Process_START_BTN.Name = "Process_START_BTN";
            this.Process_START_BTN.Size = new System.Drawing.Size(100, 48);
            this.Process_START_BTN.TabIndex = 18;
            this.Process_START_BTN.Text = "Start Process";
            this.Process_START_BTN.UseVisualStyleBackColor = true;
            this.Process_START_BTN.Click += new System.EventHandler(this.Process_START_BTN_Click);
            // 
            // Process_CB8
            // 
            this.Process_CB8.AutoSize = true;
            this.Process_CB8.Location = new System.Drawing.Point(278, 127);
            this.Process_CB8.Name = "Process_CB8";
            this.Process_CB8.Size = new System.Drawing.Size(45, 20);
            this.Process_CB8.TabIndex = 17;
            this.Process_CB8.Text = "S4";
            this.Process_CB8.UseVisualStyleBackColor = true;
            // 
            // Process_CB7
            // 
            this.Process_CB7.AutoSize = true;
            this.Process_CB7.Location = new System.Drawing.Point(278, 99);
            this.Process_CB7.Name = "Process_CB7";
            this.Process_CB7.Size = new System.Drawing.Size(45, 20);
            this.Process_CB7.TabIndex = 16;
            this.Process_CB7.Text = "S3";
            this.Process_CB7.UseVisualStyleBackColor = true;
            // 
            // Process_CB6
            // 
            this.Process_CB6.AutoSize = true;
            this.Process_CB6.Location = new System.Drawing.Point(278, 71);
            this.Process_CB6.Name = "Process_CB6";
            this.Process_CB6.Size = new System.Drawing.Size(45, 20);
            this.Process_CB6.TabIndex = 15;
            this.Process_CB6.Text = "S2";
            this.Process_CB6.UseVisualStyleBackColor = true;
            // 
            // Process_CB5
            // 
            this.Process_CB5.AutoSize = true;
            this.Process_CB5.Location = new System.Drawing.Point(278, 43);
            this.Process_CB5.Name = "Process_CB5";
            this.Process_CB5.Size = new System.Drawing.Size(45, 20);
            this.Process_CB5.TabIndex = 14;
            this.Process_CB5.Text = "S1";
            this.Process_CB5.UseVisualStyleBackColor = true;
            // 
            // Process_TB8
            // 
            this.Process_TB8.Location = new System.Drawing.Point(172, 125);
            this.Process_TB8.Name = "Process_TB8";
            this.Process_TB8.Size = new System.Drawing.Size(100, 22);
            this.Process_TB8.TabIndex = 13;
            // 
            // Process_TB7
            // 
            this.Process_TB7.Location = new System.Drawing.Point(172, 97);
            this.Process_TB7.Name = "Process_TB7";
            this.Process_TB7.Size = new System.Drawing.Size(100, 22);
            this.Process_TB7.TabIndex = 12;
            // 
            // Process_CB4
            // 
            this.Process_CB4.AutoSize = true;
            this.Process_CB4.Location = new System.Drawing.Point(121, 127);
            this.Process_CB4.Name = "Process_CB4";
            this.Process_CB4.Size = new System.Drawing.Size(45, 20);
            this.Process_CB4.TabIndex = 11;
            this.Process_CB4.Text = "S4";
            this.Process_CB4.UseVisualStyleBackColor = true;
            // 
            // Process_CB3
            // 
            this.Process_CB3.AutoSize = true;
            this.Process_CB3.Location = new System.Drawing.Point(121, 99);
            this.Process_CB3.Name = "Process_CB3";
            this.Process_CB3.Size = new System.Drawing.Size(45, 20);
            this.Process_CB3.TabIndex = 10;
            this.Process_CB3.Text = "S3";
            this.Process_CB3.UseVisualStyleBackColor = true;
            // 
            // Process_CB2
            // 
            this.Process_CB2.AutoSize = true;
            this.Process_CB2.Location = new System.Drawing.Point(121, 71);
            this.Process_CB2.Name = "Process_CB2";
            this.Process_CB2.Size = new System.Drawing.Size(45, 20);
            this.Process_CB2.TabIndex = 9;
            this.Process_CB2.Text = "S2";
            this.Process_CB2.UseVisualStyleBackColor = true;
            // 
            // Process_CB1
            // 
            this.Process_CB1.AutoSize = true;
            this.Process_CB1.Location = new System.Drawing.Point(121, 43);
            this.Process_CB1.Name = "Process_CB1";
            this.Process_CB1.Size = new System.Drawing.Size(45, 20);
            this.Process_CB1.TabIndex = 8;
            this.Process_CB1.Text = "S1";
            this.Process_CB1.UseVisualStyleBackColor = true;
            // 
            // Process_TB6
            // 
            this.Process_TB6.Location = new System.Drawing.Point(172, 69);
            this.Process_TB6.Name = "Process_TB6";
            this.Process_TB6.Size = new System.Drawing.Size(100, 22);
            this.Process_TB6.TabIndex = 7;
            // 
            // Process_TB5
            // 
            this.Process_TB5.Location = new System.Drawing.Point(172, 41);
            this.Process_TB5.Name = "Process_TB5";
            this.Process_TB5.Size = new System.Drawing.Size(100, 22);
            this.Process_TB5.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "End Position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start Position";
            // 
            // Process_TB4
            // 
            this.Process_TB4.Location = new System.Drawing.Point(15, 125);
            this.Process_TB4.Name = "Process_TB4";
            this.Process_TB4.Size = new System.Drawing.Size(100, 22);
            this.Process_TB4.TabIndex = 3;
            // 
            // Process_TB3
            // 
            this.Process_TB3.Location = new System.Drawing.Point(15, 97);
            this.Process_TB3.Name = "Process_TB3";
            this.Process_TB3.Size = new System.Drawing.Size(100, 22);
            this.Process_TB3.TabIndex = 2;
            // 
            // Process_TB2
            // 
            this.Process_TB2.Location = new System.Drawing.Point(15, 69);
            this.Process_TB2.Name = "Process_TB2";
            this.Process_TB2.Size = new System.Drawing.Size(100, 22);
            this.Process_TB2.TabIndex = 1;
            // 
            // Process_TB1
            // 
            this.Process_TB1.Location = new System.Drawing.Point(15, 41);
            this.Process_TB1.Name = "Process_TB1";
            this.Process_TB1.Size = new System.Drawing.Size(100, 22);
            this.Process_TB1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 573);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Control Panel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button ServoAngle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button onButton;
        private System.Windows.Forms.Button offButton;
        private System.Windows.Forms.Button servoClear;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Process_TB6;
        private System.Windows.Forms.TextBox Process_TB5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Process_TB4;
        private System.Windows.Forms.TextBox Process_TB3;
        private System.Windows.Forms.TextBox Process_TB2;
        private System.Windows.Forms.TextBox Process_TB1;
        private System.Windows.Forms.CheckBox Process_CB7;
        private System.Windows.Forms.CheckBox Process_CB6;
        private System.Windows.Forms.CheckBox Process_CB5;
        private System.Windows.Forms.TextBox Process_TB8;
        private System.Windows.Forms.TextBox Process_TB7;
        private System.Windows.Forms.CheckBox Process_CB4;
        private System.Windows.Forms.CheckBox Process_CB3;
        private System.Windows.Forms.CheckBox Process_CB2;
        private System.Windows.Forms.CheckBox Process_CB1;
        private System.Windows.Forms.CheckBox Process_CB8;
        private System.Windows.Forms.Button Process_END_BTN;
        private System.Windows.Forms.Button Process_START_BTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar Process_Progress_based_on_loop;
        private System.Windows.Forms.TextBox Process_Loop_TB;
        private System.Windows.Forms.Button SET_END;
        private System.Windows.Forms.Button SET_START;
        private System.Windows.Forms.Button LOOP_BTN;
        private System.Windows.Forms.Button SET_MID;
        private System.Windows.Forms.CheckBox Process_CB12;
        private System.Windows.Forms.CheckBox Process_CB11;
        private System.Windows.Forms.CheckBox Process_CB10;
        private System.Windows.Forms.CheckBox Process_CB9;
        private System.Windows.Forms.TextBox Process_TB12;
        private System.Windows.Forms.TextBox Process_TB11;
        private System.Windows.Forms.TextBox Process_TB10;
        private System.Windows.Forms.TextBox Process_TB9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox Process_CB16;
        private System.Windows.Forms.CheckBox Process_CB15;
        private System.Windows.Forms.CheckBox Process_CB14;
        private System.Windows.Forms.CheckBox Process_CB13;
        private System.Windows.Forms.TextBox Process_TB16;
        private System.Windows.Forms.TextBox Process_TB15;
        private System.Windows.Forms.TextBox Process_TB14;
        private System.Windows.Forms.TextBox Process_TB13;
    }
}

