namespace MacroSim
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStripContainer1 = new ToolStripContainer();
            statusStrip1 = new StatusStrip();
            connectedToSimLabel = new ToolStripStatusLabel();
            connectedToMacroPadLabel = new ToolStripStatusLabel();
            stateLabel = new ToolStripStatusLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            altitude = new SevenSegmentDisplay();
            com1standby = new SevenSegmentDisplay();
            label1 = new Label();
            label2 = new Label();
            com1active = new SevenSegmentDisplay();
            label3 = new Label();
            label4 = new Label();
            com2standby = new SevenSegmentDisplay();
            com2active = new SevenSegmentDisplay();
            nav1standby = new SevenSegmentDisplay();
            nav1active = new SevenSegmentDisplay();
            nav2standby = new SevenSegmentDisplay();
            nav2active = new SevenSegmentDisplay();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            heading = new SevenSegmentDisplay();
            course = new SevenSegmentDisplay();
            label11 = new Label();
            label12 = new Label();
            verticalspeed = new SevenSegmentDisplay();
            menuStrip1 = new MenuStrip();
            appToolStripMenuItem = new ToolStripMenuItem();
            connectToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            macroPadToolStripMenuItem = new ToolStripMenuItem();
            baud9600ToolStripMenuItem = new ToolStripMenuItem();
            baud115200ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            altitudeToolStripMenuItem = new ToolStripMenuItem();
            altitudeIncrease1000ToolStripMenuItem = new ToolStripMenuItem();
            altitudeDecrease1000ToolStripMenuItem = new ToolStripMenuItem();
            toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            statusStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            toolStripContainer1.BottomToolStripPanel.Controls.Add(statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(tableLayoutPanel1);
            toolStripContainer1.ContentPanel.Size = new Size(443, 497);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(443, 545);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(menuStrip1);
            // 
            // statusStrip1
            // 
            statusStrip1.Dock = DockStyle.None;
            statusStrip1.Items.AddRange(new ToolStripItem[] { connectedToSimLabel, connectedToMacroPadLabel, stateLabel });
            statusStrip1.Location = new Point(0, 0);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(443, 24);
            statusStrip1.TabIndex = 0;
            // 
            // connectedToSimLabel
            // 
            connectedToSimLabel.BorderSides = ToolStripStatusLabelBorderSides.Right;
            connectedToSimLabel.Name = "connectedToSimLabel";
            connectedToSimLabel.Size = new Size(126, 19);
            connectedToSimLabel.Text = "Not connected to sim";
            // 
            // connectedToMacroPadLabel
            // 
            connectedToMacroPadLabel.BorderSides = ToolStripStatusLabelBorderSides.Right;
            connectedToMacroPadLabel.Name = "connectedToMacroPadLabel";
            connectedToMacroPadLabel.Size = new Size(161, 19);
            connectedToMacroPadLabel.Text = "Not connected to MacroPad";
            // 
            // stateLabel
            // 
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(36, 19);
            stateLabel.Text = "None";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(altitude, 0, 11);
            tableLayoutPanel1.Controls.Add(com1standby, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(com1active, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 1, 2);
            tableLayoutPanel1.Controls.Add(com2standby, 0, 3);
            tableLayoutPanel1.Controls.Add(com2active, 1, 3);
            tableLayoutPanel1.Controls.Add(nav1standby, 0, 5);
            tableLayoutPanel1.Controls.Add(nav1active, 1, 5);
            tableLayoutPanel1.Controls.Add(nav2standby, 0, 7);
            tableLayoutPanel1.Controls.Add(nav2active, 1, 7);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 1, 4);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(label8, 1, 6);
            tableLayoutPanel1.Controls.Add(label9, 0, 8);
            tableLayoutPanel1.Controls.Add(label10, 1, 8);
            tableLayoutPanel1.Controls.Add(heading, 0, 9);
            tableLayoutPanel1.Controls.Add(course, 1, 9);
            tableLayoutPanel1.Controls.Add(label11, 0, 10);
            tableLayoutPanel1.Controls.Add(label12, 1, 10);
            tableLayoutPanel1.Controls.Add(verticalspeed, 1, 11);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 12;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11F));
            tableLayoutPanel1.Size = new Size(443, 497);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // altitude
            // 
            altitude.Anchor = AnchorStyles.None;
            altitude.BackColor = Color.Black;
            altitude.FontColor = Color.Red;
            altitude.FractDigits = 0;
            altitude.LeftMargin = 0;
            altitude.Location = new Point(25, 442);
            altitude.Margin = new Padding(0);
            altitude.Name = "altitude";
            altitude.RightMargin = 0;
            altitude.Selection = FrequencySelection.None;
            altitude.SelectionColor = Color.Yellow;
            altitude.Size = new Size(170, 50);
            altitude.TabIndex = 23;
            altitude.TopMargin = 5;
            altitude.Value = new decimal(new int[] { 321, 0, 0, 0 });
            altitude.WholeDigits = 5;
            // 
            // com1standby
            // 
            com1standby.Anchor = AnchorStyles.None;
            com1standby.BackColor = Color.Black;
            com1standby.FontColor = Color.Red;
            com1standby.LeftMargin = 0;
            com1standby.Location = new Point(25, 29);
            com1standby.Margin = new Padding(0);
            com1standby.Name = "com1standby";
            com1standby.RightMargin = 0;
            com1standby.Selection = FrequencySelection.None;
            com1standby.SelectionColor = Color.Yellow;
            com1standby.Size = new Size(170, 50);
            com1standby.TabIndex = 0;
            com1standby.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(56, 3);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 1;
            label1.Text = "COM1 Standby";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(284, 3);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 2;
            label2.Text = "COM1 Active";
            // 
            // com1active
            // 
            com1active.Anchor = AnchorStyles.None;
            com1active.BackColor = Color.Black;
            com1active.FontColor = Color.Red;
            com1active.LeftMargin = 0;
            com1active.Location = new Point(247, 29);
            com1active.Margin = new Padding(0);
            com1active.Name = "com1active";
            com1active.RightMargin = 0;
            com1active.Selection = FrequencySelection.None;
            com1active.SelectionColor = Color.Yellow;
            com1active.Size = new Size(170, 50);
            com1active.TabIndex = 3;
            com1active.Value = new decimal(new int[] { 134225, 0, 0, 196608 });
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(56, 85);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 4;
            label3.Text = "COM2 Standby";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(284, 85);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 5;
            label4.Text = "COM2 Active";
            // 
            // com2standby
            // 
            com2standby.Anchor = AnchorStyles.None;
            com2standby.BackColor = Color.Black;
            com2standby.FontColor = Color.Red;
            com2standby.LeftMargin = 0;
            com2standby.Location = new Point(25, 111);
            com2standby.Margin = new Padding(0);
            com2standby.Name = "com2standby";
            com2standby.RightMargin = 0;
            com2standby.Selection = FrequencySelection.None;
            com2standby.SelectionColor = Color.Yellow;
            com2standby.Size = new Size(170, 50);
            com2standby.TabIndex = 6;
            com2standby.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // com2active
            // 
            com2active.Anchor = AnchorStyles.None;
            com2active.BackColor = Color.Black;
            com2active.FontColor = Color.Red;
            com2active.LeftMargin = 0;
            com2active.Location = new Point(247, 111);
            com2active.Margin = new Padding(0);
            com2active.Name = "com2active";
            com2active.RightMargin = 0;
            com2active.Selection = FrequencySelection.None;
            com2active.SelectionColor = Color.Yellow;
            com2active.Size = new Size(170, 50);
            com2active.TabIndex = 7;
            com2active.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // nav1standby
            // 
            nav1standby.Anchor = AnchorStyles.None;
            nav1standby.BackColor = Color.Black;
            nav1standby.FontColor = Color.Red;
            nav1standby.FractDigits = 2;
            nav1standby.LeftMargin = 0;
            nav1standby.Location = new Point(25, 193);
            nav1standby.Margin = new Padding(0);
            nav1standby.Name = "nav1standby";
            nav1standby.RightMargin = 0;
            nav1standby.Selection = FrequencySelection.None;
            nav1standby.SelectionColor = Color.Yellow;
            nav1standby.Size = new Size(170, 50);
            nav1standby.TabIndex = 8;
            nav1standby.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // nav1active
            // 
            nav1active.Anchor = AnchorStyles.None;
            nav1active.BackColor = Color.Black;
            nav1active.FontColor = Color.Red;
            nav1active.FractDigits = 2;
            nav1active.LeftMargin = 0;
            nav1active.Location = new Point(247, 193);
            nav1active.Margin = new Padding(0);
            nav1active.Name = "nav1active";
            nav1active.RightMargin = 0;
            nav1active.Selection = FrequencySelection.None;
            nav1active.SelectionColor = Color.Yellow;
            nav1active.Size = new Size(170, 50);
            nav1active.TabIndex = 9;
            nav1active.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // nav2standby
            // 
            nav2standby.Anchor = AnchorStyles.None;
            nav2standby.BackColor = Color.Black;
            nav2standby.FontColor = Color.Red;
            nav2standby.FractDigits = 2;
            nav2standby.LeftMargin = 0;
            nav2standby.Location = new Point(25, 275);
            nav2standby.Margin = new Padding(0);
            nav2standby.Name = "nav2standby";
            nav2standby.RightMargin = 0;
            nav2standby.Selection = FrequencySelection.None;
            nav2standby.SelectionColor = Color.Yellow;
            nav2standby.Size = new Size(170, 50);
            nav2standby.TabIndex = 10;
            nav2standby.Value = new decimal(new int[] { 321, 0, 0, 0 });
            // 
            // nav2active
            // 
            nav2active.Anchor = AnchorStyles.None;
            nav2active.BackColor = Color.Black;
            nav2active.FontColor = Color.Red;
            nav2active.FractDigits = 2;
            nav2active.LeftMargin = 0;
            nav2active.Location = new Point(247, 275);
            nav2active.Margin = new Padding(0);
            nav2active.Name = "nav2active";
            nav2active.RightMargin = 0;
            nav2active.Selection = FrequencySelection.None;
            nav2active.SelectionColor = Color.Yellow;
            nav2active.Size = new Size(170, 50);
            nav2active.TabIndex = 11;
            nav2active.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(58, 167);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 12;
            label5.Text = "NAV1 Standby";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(286, 167);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 13;
            label6.Text = "NAV1 Active";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(58, 249);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 14;
            label7.Text = "NAV2 Standby";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(286, 249);
            label8.Name = "label8";
            label8.Size = new Size(91, 20);
            label8.TabIndex = 15;
            label8.Text = "NAV2 Active";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(77, 331);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 16;
            label9.Text = "Heading";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(305, 331);
            label10.Name = "label10";
            label10.Size = new Size(54, 20);
            label10.TabIndex = 17;
            label10.Text = "Course";
            // 
            // heading
            // 
            heading.Anchor = AnchorStyles.None;
            heading.BackColor = Color.Black;
            heading.FontColor = Color.Red;
            heading.FractDigits = 0;
            heading.LeftMargin = 0;
            heading.Location = new Point(25, 357);
            heading.Margin = new Padding(0);
            heading.Name = "heading";
            heading.RightMargin = 0;
            heading.Selection = FrequencySelection.None;
            heading.SelectionColor = Color.Yellow;
            heading.Size = new Size(170, 50);
            heading.TabIndex = 18;
            heading.TopMargin = 5;
            heading.Value = new decimal(new int[] { 321, 0, 0, 0 });
            // 
            // course
            // 
            course.Anchor = AnchorStyles.None;
            course.BackColor = Color.Black;
            course.FontColor = Color.Red;
            course.FractDigits = 0;
            course.LeftMargin = 0;
            course.Location = new Point(247, 357);
            course.Margin = new Padding(0);
            course.Name = "course";
            course.RightMargin = 0;
            course.Selection = FrequencySelection.None;
            course.SelectionColor = Color.Yellow;
            course.Size = new Size(170, 50);
            course.TabIndex = 19;
            course.TopMargin = 5;
            course.Value = new decimal(new int[] { 321, 0, 0, 0 });
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(79, 413);
            label11.Name = "label11";
            label11.Size = new Size(62, 20);
            label11.TabIndex = 20;
            label11.Text = "Altitude";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(280, 413);
            label12.Name = "label12";
            label12.Size = new Size(104, 20);
            label12.TabIndex = 21;
            label12.Text = "Vertical Speed";
            // 
            // verticalspeed
            // 
            verticalspeed.Anchor = AnchorStyles.None;
            verticalspeed.BackColor = Color.Black;
            verticalspeed.FontColor = Color.Red;
            verticalspeed.FractDigits = 0;
            verticalspeed.LeftMargin = 0;
            verticalspeed.Location = new Point(247, 442);
            verticalspeed.Margin = new Padding(0);
            verticalspeed.Name = "verticalspeed";
            verticalspeed.RightMargin = 0;
            verticalspeed.Selection = FrequencySelection.None;
            verticalspeed.SelectionColor = Color.Yellow;
            verticalspeed.Size = new Size(170, 50);
            verticalspeed.TabIndex = 22;
            verticalspeed.TopMargin = 5;
            verticalspeed.Value = new decimal(new int[] { 321, 0, 0, 0 });
            verticalspeed.WholeDigits = 4;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { appToolStripMenuItem, macroPadToolStripMenuItem, altitudeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(443, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // appToolStripMenuItem
            // 
            appToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { connectToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            appToolStripMenuItem.Name = "appToolStripMenuItem";
            appToolStripMenuItem.Size = new Size(41, 20);
            appToolStripMenuItem.Text = "App";
            // 
            // connectToolStripMenuItem
            // 
            connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            connectToolStripMenuItem.Size = new Size(156, 22);
            connectToolStripMenuItem.Text = "Connect to Sim";
            connectToolStripMenuItem.Click += ConnectToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(153, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(156, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // macroPadToolStripMenuItem
            // 
            macroPadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { baud9600ToolStripMenuItem, baud115200ToolStripMenuItem, toolStripSeparator2 });
            macroPadToolStripMenuItem.Name = "macroPadToolStripMenuItem";
            macroPadToolStripMenuItem.Size = new Size(73, 20);
            macroPadToolStripMenuItem.Text = "MacroPad";
            // 
            // baud9600ToolStripMenuItem
            // 
            baud9600ToolStripMenuItem.Name = "baud9600ToolStripMenuItem";
            baud9600ToolStripMenuItem.Size = new Size(140, 22);
            baud9600ToolStripMenuItem.Tag = "9600";
            baud9600ToolStripMenuItem.Text = "9600 Baud";
            baud9600ToolStripMenuItem.Click += BaudRateMenuItem_Click;
            // 
            // baud115200ToolStripMenuItem
            // 
            baud115200ToolStripMenuItem.Checked = true;
            baud115200ToolStripMenuItem.CheckState = CheckState.Checked;
            baud115200ToolStripMenuItem.Name = "baud115200ToolStripMenuItem";
            baud115200ToolStripMenuItem.Size = new Size(140, 22);
            baud115200ToolStripMenuItem.Tag = "115200";
            baud115200ToolStripMenuItem.Text = "115200 Baud";
            baud115200ToolStripMenuItem.Click += BaudRateMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(137, 6);
            // 
            // altitudeToolStripMenuItem
            // 
            altitudeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { altitudeIncrease1000ToolStripMenuItem, altitudeDecrease1000ToolStripMenuItem });
            altitudeToolStripMenuItem.Name = "altitudeToolStripMenuItem";
            altitudeToolStripMenuItem.Size = new Size(61, 20);
            altitudeToolStripMenuItem.Text = "Altitude";
            // 
            // altitudeIncrease1000ToolStripMenuItem
            // 
            altitudeIncrease1000ToolStripMenuItem.Name = "altitudeIncrease1000ToolStripMenuItem";
            altitudeIncrease1000ToolStripMenuItem.Size = new Size(193, 22);
            altitudeIncrease1000ToolStripMenuItem.Text = "Altitude Increase 1000";
            altitudeIncrease1000ToolStripMenuItem.Click += altitudeIncrease1000ToolStripMenuItem_Click;
            // 
            // altitudeDecrease1000ToolStripMenuItem
            // 
            altitudeDecrease1000ToolStripMenuItem.Name = "altitudeDecrease1000ToolStripMenuItem";
            altitudeDecrease1000ToolStripMenuItem.Size = new Size(193, 22);
            altitudeDecrease1000ToolStripMenuItem.Text = "Altitude Decrease 1000";
            altitudeDecrease1000ToolStripMenuItem.Click += altitudeDecrease1000ToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 545);
            Controls.Add(toolStripContainer1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MacroSim";
            FormClosed += MainForm_FormClosed;
            toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            toolStripContainer1.BottomToolStripPanel.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private SevenSegmentDisplay com1standby;
        private Label label1;
        private Label label2;
        private SevenSegmentDisplay com1active;
        private Label label3;
        private Label label4;
        private SevenSegmentDisplay com2standby;
        private SevenSegmentDisplay com2active;
        private SevenSegmentDisplay nav1standby;
        private SevenSegmentDisplay nav1active;
        private SevenSegmentDisplay nav2standby;
        private SevenSegmentDisplay nav2active;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private SevenSegmentDisplay altitude;
        private SevenSegmentDisplay heading;
        private SevenSegmentDisplay course;
        private Label label11;
        private Label label12;
        private SevenSegmentDisplay verticalspeed;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel connectedToSimLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem appToolStripMenuItem;
        private ToolStripMenuItem connectToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem macroPadToolStripMenuItem;
        private ToolStripMenuItem baud9600ToolStripMenuItem;
        private ToolStripMenuItem baud115200ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem altitudeToolStripMenuItem;
        private ToolStripMenuItem altitudeIncrease1000ToolStripMenuItem;
        private ToolStripMenuItem altitudeDecrease1000ToolStripMenuItem;
        private ToolStripStatusLabel connectedToMacroPadLabel;
        private ToolStripStatusLabel stateLabel;
    }
}