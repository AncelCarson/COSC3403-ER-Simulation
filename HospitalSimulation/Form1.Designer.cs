namespace HospitalSimulation
{
    partial class FrontPanel
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
            this.InstantSimButton = new System.Windows.Forms.Button();
            this.TimedSimButton = new System.Windows.Forms.Button();
            this.ChangeAveDelay = new System.Windows.Forms.CheckBox();
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.DelayMinValue = new System.Windows.Forms.NumericUpDown();
            this.DelayMaxValue = new System.Windows.Forms.NumericUpDown();
            this.AverageDelay = new System.Windows.Forms.Label();
            this.TimeUnitsLabel = new System.Windows.Forms.Label();
            this.ChangeNumRooms = new System.Windows.Forms.CheckBox();
            this.RoomDropDown = new System.Windows.Forms.ComboBox();
            this.ChangeFreqPercent = new System.Windows.Forms.CheckBox();
            this.HelpButton = new System.Windows.Forms.Button();
            this.Severity1Percent = new System.Windows.Forms.NumericUpDown();
            this.PercentChance1 = new System.Windows.Forms.Label();
            this.PercentChance2 = new System.Windows.Forms.Label();
            this.Severity2Percent = new System.Windows.Forms.NumericUpDown();
            this.PercentChance3 = new System.Windows.Forms.Label();
            this.Severity3Percent = new System.Windows.Forms.NumericUpDown();
            this.PercentChance4 = new System.Windows.Forms.Label();
            this.Severity4Percent = new System.Windows.Forms.NumericUpDown();
            this.RoomTime4 = new System.Windows.Forms.Label();
            this.Severity4RoomWait = new System.Windows.Forms.NumericUpDown();
            this.RoomTime3 = new System.Windows.Forms.Label();
            this.Severity3RoomWait = new System.Windows.Forms.NumericUpDown();
            this.RoomTime2 = new System.Windows.Forms.Label();
            this.Severity2RoomWait = new System.Windows.Forms.NumericUpDown();
            this.RoomTime1 = new System.Windows.Forms.Label();
            this.Severity1RoomWait = new System.Windows.Forms.NumericUpDown();
            this.ChangeRoomWait = new System.Windows.Forms.CheckBox();
            this.shiftLengthLabel = new System.Windows.Forms.Label();
            this.shiftLength = new System.Windows.Forms.NumericUpDown();
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DelayMinValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayMaxValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity1Percent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity2Percent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity3Percent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity4Percent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity4RoomWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity3RoomWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity2RoomWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity1RoomWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftLength)).BeginInit();
            this.topMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // InstantSimButton
            // 
            this.InstantSimButton.Location = new System.Drawing.Point(209, 232);
            this.InstantSimButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InstantSimButton.Name = "InstantSimButton";
            this.InstantSimButton.Size = new System.Drawing.Size(133, 31);
            this.InstantSimButton.TabIndex = 1;
            this.InstantSimButton.Text = "Instant Simulation";
            this.InstantSimButton.UseVisualStyleBackColor = true;
            this.InstantSimButton.Click += new System.EventHandler(this.InstantSimButton_Click);
            // 
            // TimedSimButton
            // 
            this.TimedSimButton.Location = new System.Drawing.Point(60, 232);
            this.TimedSimButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TimedSimButton.Name = "TimedSimButton";
            this.TimedSimButton.Size = new System.Drawing.Size(142, 31);
            this.TimedSimButton.TabIndex = 2;
            this.TimedSimButton.Text = "Timed Simulation";
            this.TimedSimButton.UseVisualStyleBackColor = true;
            this.TimedSimButton.Click += new System.EventHandler(this.TimedSimButton_Click);
            // 
            // ChangeAveDelay
            // 
            this.ChangeAveDelay.AutoSize = true;
            this.ChangeAveDelay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeAveDelay.Location = new System.Drawing.Point(11, 46);
            this.ChangeAveDelay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChangeAveDelay.Name = "ChangeAveDelay";
            this.ChangeAveDelay.Size = new System.Drawing.Size(160, 17);
            this.ChangeAveDelay.TabIndex = 3;
            this.ChangeAveDelay.Text = "Average patient arrival delay";
            this.ChangeAveDelay.UseVisualStyleBackColor = true;
            this.ChangeAveDelay.CheckedChanged += new System.EventHandler(this.ChangeAveDelay_CheckedChanged);
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.Location = new System.Drawing.Point(2, 24);
            this.SettingsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(340, 13);
            this.SettingsLabel.TabIndex = 4;
            this.SettingsLabel.Text = "If you would like to change any values click the appropriate check box";
            // 
            // DelayMinValue
            // 
            this.DelayMinValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelayMinValue.Enabled = false;
            this.DelayMinValue.Location = new System.Drawing.Point(11, 65);
            this.DelayMinValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DelayMinValue.Name = "DelayMinValue";
            this.DelayMinValue.Size = new System.Drawing.Size(37, 20);
            this.DelayMinValue.TabIndex = 5;
            this.DelayMinValue.ValueChanged += new System.EventHandler(this.DelayMinValue_ValueChanged);
            // 
            // DelayMaxValue
            // 
            this.DelayMaxValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelayMaxValue.Enabled = false;
            this.DelayMaxValue.Location = new System.Drawing.Point(52, 65);
            this.DelayMaxValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DelayMaxValue.Name = "DelayMaxValue";
            this.DelayMaxValue.Size = new System.Drawing.Size(37, 20);
            this.DelayMaxValue.TabIndex = 6;
            this.DelayMaxValue.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.DelayMaxValue.ValueChanged += new System.EventHandler(this.DelayMaxValue_ValueChanged);
            // 
            // AverageDelay
            // 
            this.AverageDelay.AutoSize = true;
            this.AverageDelay.Location = new System.Drawing.Point(98, 66);
            this.AverageDelay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AverageDelay.Name = "AverageDelay";
            this.AverageDelay.Size = new System.Drawing.Size(22, 13);
            this.AverageDelay.TabIndex = 7;
            this.AverageDelay.Text = "7.5";
            // 
            // TimeUnitsLabel
            // 
            this.TimeUnitsLabel.AutoSize = true;
            this.TimeUnitsLabel.Location = new System.Drawing.Point(123, 66);
            this.TimeUnitsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimeUnitsLabel.Name = "TimeUnitsLabel";
            this.TimeUnitsLabel.Size = new System.Drawing.Size(43, 13);
            this.TimeUnitsLabel.TabIndex = 8;
            this.TimeUnitsLabel.Text = "minutes";
            // 
            // ChangeNumRooms
            // 
            this.ChangeNumRooms.AutoSize = true;
            this.ChangeNumRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeNumRooms.Location = new System.Drawing.Point(178, 46);
            this.ChangeNumRooms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChangeNumRooms.Name = "ChangeNumRooms";
            this.ChangeNumRooms.Size = new System.Drawing.Size(151, 17);
            this.ChangeNumRooms.TabIndex = 9;
            this.ChangeNumRooms.Text = "Number of avaliable rooms";
            this.ChangeNumRooms.UseVisualStyleBackColor = true;
            this.ChangeNumRooms.CheckedChanged += new System.EventHandler(this.ChangeNumRooms_CheckedChanged);
            // 
            // RoomDropDown
            // 
            this.RoomDropDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RoomDropDown.Enabled = false;
            this.RoomDropDown.FormattingEnabled = true;
            this.RoomDropDown.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.RoomDropDown.Location = new System.Drawing.Point(178, 63);
            this.RoomDropDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RoomDropDown.Name = "RoomDropDown";
            this.RoomDropDown.Size = new System.Drawing.Size(68, 21);
            this.RoomDropDown.TabIndex = 10;
            this.RoomDropDown.Text = "6";
            // 
            // ChangeFreqPercent
            // 
            this.ChangeFreqPercent.AutoSize = true;
            this.ChangeFreqPercent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeFreqPercent.Location = new System.Drawing.Point(11, 95);
            this.ChangeFreqPercent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChangeFreqPercent.Name = "ChangeFreqPercent";
            this.ChangeFreqPercent.Size = new System.Drawing.Size(159, 17);
            this.ChangeFreqPercent.TabIndex = 11;
            this.ChangeFreqPercent.Text = "Percent chance per severity";
            this.ChangeFreqPercent.UseVisualStyleBackColor = true;
            this.ChangeFreqPercent.CheckedChanged += new System.EventHandler(this.ChangeFreqPercent_CheckedChanged);
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(7, 232);
            this.HelpButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(41, 31);
            this.HelpButton.TabIndex = 12;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // Severity1Percent
            // 
            this.Severity1Percent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Severity1Percent.Enabled = false;
            this.Severity1Percent.Location = new System.Drawing.Point(11, 114);
            this.Severity1Percent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Severity1Percent.Name = "Severity1Percent";
            this.Severity1Percent.Size = new System.Drawing.Size(43, 20);
            this.Severity1Percent.TabIndex = 13;
            this.Severity1Percent.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // PercentChance1
            // 
            this.PercentChance1.AutoSize = true;
            this.PercentChance1.Location = new System.Drawing.Point(67, 115);
            this.PercentChance1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PercentChance1.Name = "PercentChance1";
            this.PercentChance1.Size = new System.Drawing.Size(88, 13);
            this.PercentChance1.TabIndex = 14;
            this.PercentChance1.Text = "Severity Rating 1";
            // 
            // PercentChance2
            // 
            this.PercentChance2.AutoSize = true;
            this.PercentChance2.Location = new System.Drawing.Point(67, 134);
            this.PercentChance2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PercentChance2.Name = "PercentChance2";
            this.PercentChance2.Size = new System.Drawing.Size(88, 13);
            this.PercentChance2.TabIndex = 16;
            this.PercentChance2.Text = "Severity Rating 2";
            // 
            // Severity2Percent
            // 
            this.Severity2Percent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Severity2Percent.Enabled = false;
            this.Severity2Percent.Location = new System.Drawing.Point(11, 134);
            this.Severity2Percent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Severity2Percent.Name = "Severity2Percent";
            this.Severity2Percent.Size = new System.Drawing.Size(43, 20);
            this.Severity2Percent.TabIndex = 15;
            this.Severity2Percent.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // PercentChance3
            // 
            this.PercentChance3.AutoSize = true;
            this.PercentChance3.Location = new System.Drawing.Point(67, 153);
            this.PercentChance3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PercentChance3.Name = "PercentChance3";
            this.PercentChance3.Size = new System.Drawing.Size(88, 13);
            this.PercentChance3.TabIndex = 18;
            this.PercentChance3.Text = "Severity Rating 3";
            // 
            // Severity3Percent
            // 
            this.Severity3Percent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Severity3Percent.Enabled = false;
            this.Severity3Percent.Location = new System.Drawing.Point(11, 153);
            this.Severity3Percent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Severity3Percent.Name = "Severity3Percent";
            this.Severity3Percent.Size = new System.Drawing.Size(43, 20);
            this.Severity3Percent.TabIndex = 17;
            this.Severity3Percent.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // PercentChance4
            // 
            this.PercentChance4.AutoSize = true;
            this.PercentChance4.Location = new System.Drawing.Point(67, 172);
            this.PercentChance4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PercentChance4.Name = "PercentChance4";
            this.PercentChance4.Size = new System.Drawing.Size(88, 13);
            this.PercentChance4.TabIndex = 20;
            this.PercentChance4.Text = "Severity Rating 4";
            // 
            // Severity4Percent
            // 
            this.Severity4Percent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Severity4Percent.Enabled = false;
            this.Severity4Percent.Location = new System.Drawing.Point(11, 172);
            this.Severity4Percent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Severity4Percent.Name = "Severity4Percent";
            this.Severity4Percent.Size = new System.Drawing.Size(43, 20);
            this.Severity4Percent.TabIndex = 19;
            this.Severity4Percent.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // RoomTime4
            // 
            this.RoomTime4.AutoSize = true;
            this.RoomTime4.Location = new System.Drawing.Point(233, 172);
            this.RoomTime4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RoomTime4.Name = "RoomTime4";
            this.RoomTime4.Size = new System.Drawing.Size(88, 13);
            this.RoomTime4.TabIndex = 29;
            this.RoomTime4.Text = "Severity Rating 4";
            // 
            // Severity4RoomWait
            // 
            this.Severity4RoomWait.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Severity4RoomWait.Enabled = false;
            this.Severity4RoomWait.Location = new System.Drawing.Point(178, 172);
            this.Severity4RoomWait.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Severity4RoomWait.Name = "Severity4RoomWait";
            this.Severity4RoomWait.Size = new System.Drawing.Size(43, 20);
            this.Severity4RoomWait.TabIndex = 28;
            this.Severity4RoomWait.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // RoomTime3
            // 
            this.RoomTime3.AutoSize = true;
            this.RoomTime3.Location = new System.Drawing.Point(233, 153);
            this.RoomTime3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RoomTime3.Name = "RoomTime3";
            this.RoomTime3.Size = new System.Drawing.Size(88, 13);
            this.RoomTime3.TabIndex = 27;
            this.RoomTime3.Text = "Severity Rating 3";
            // 
            // Severity3RoomWait
            // 
            this.Severity3RoomWait.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Severity3RoomWait.Enabled = false;
            this.Severity3RoomWait.Location = new System.Drawing.Point(178, 153);
            this.Severity3RoomWait.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Severity3RoomWait.Name = "Severity3RoomWait";
            this.Severity3RoomWait.Size = new System.Drawing.Size(43, 20);
            this.Severity3RoomWait.TabIndex = 26;
            this.Severity3RoomWait.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // RoomTime2
            // 
            this.RoomTime2.AutoSize = true;
            this.RoomTime2.Location = new System.Drawing.Point(233, 134);
            this.RoomTime2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RoomTime2.Name = "RoomTime2";
            this.RoomTime2.Size = new System.Drawing.Size(88, 13);
            this.RoomTime2.TabIndex = 25;
            this.RoomTime2.Text = "Severity Rating 2";
            // 
            // Severity2RoomWait
            // 
            this.Severity2RoomWait.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Severity2RoomWait.Enabled = false;
            this.Severity2RoomWait.Location = new System.Drawing.Point(178, 134);
            this.Severity2RoomWait.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Severity2RoomWait.Name = "Severity2RoomWait";
            this.Severity2RoomWait.Size = new System.Drawing.Size(43, 20);
            this.Severity2RoomWait.TabIndex = 24;
            this.Severity2RoomWait.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // RoomTime1
            // 
            this.RoomTime1.AutoSize = true;
            this.RoomTime1.Location = new System.Drawing.Point(233, 115);
            this.RoomTime1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RoomTime1.Name = "RoomTime1";
            this.RoomTime1.Size = new System.Drawing.Size(88, 13);
            this.RoomTime1.TabIndex = 23;
            this.RoomTime1.Text = "Severity Rating 1";
            // 
            // Severity1RoomWait
            // 
            this.Severity1RoomWait.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Severity1RoomWait.Enabled = false;
            this.Severity1RoomWait.Location = new System.Drawing.Point(178, 114);
            this.Severity1RoomWait.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Severity1RoomWait.Name = "Severity1RoomWait";
            this.Severity1RoomWait.Size = new System.Drawing.Size(43, 20);
            this.Severity1RoomWait.TabIndex = 22;
            this.Severity1RoomWait.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // ChangeRoomWait
            // 
            this.ChangeRoomWait.AutoSize = true;
            this.ChangeRoomWait.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeRoomWait.Location = new System.Drawing.Point(178, 95);
            this.ChangeRoomWait.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChangeRoomWait.Name = "ChangeRoomWait";
            this.ChangeRoomWait.Size = new System.Drawing.Size(114, 17);
            this.ChangeRoomWait.TabIndex = 21;
            this.ChangeRoomWait.Text = "Average room time";
            this.ChangeRoomWait.UseVisualStyleBackColor = true;
            this.ChangeRoomWait.CheckedChanged += new System.EventHandler(this.ChangeRoomWait_CheckedChanged);
            // 
            // shiftLengthLabel
            // 
            this.shiftLengthLabel.AutoSize = true;
            this.shiftLengthLabel.Location = new System.Drawing.Point(157, 199);
            this.shiftLengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shiftLengthLabel.Name = "shiftLengthLabel";
            this.shiftLengthLabel.Size = new System.Drawing.Size(64, 13);
            this.shiftLengthLabel.TabIndex = 31;
            this.shiftLengthLabel.Text = "Shift Length";
            // 
            // shiftLength
            // 
            this.shiftLength.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shiftLength.Enabled = false;
            this.shiftLength.Location = new System.Drawing.Point(112, 197);
            this.shiftLength.Margin = new System.Windows.Forms.Padding(2);
            this.shiftLength.Name = "shiftLength";
            this.shiftLength.Size = new System.Drawing.Size(43, 20);
            this.shiftLength.TabIndex = 30;
            this.shiftLength.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // topMenu
            // 
            this.topMenu.BackColor = System.Drawing.Color.Gold;
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(350, 24);
            this.topMenu.TabIndex = 32;
            this.topMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // FrontPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 274);
            this.Controls.Add(this.shiftLengthLabel);
            this.Controls.Add(this.shiftLength);
            this.Controls.Add(this.RoomTime4);
            this.Controls.Add(this.Severity4RoomWait);
            this.Controls.Add(this.RoomTime3);
            this.Controls.Add(this.Severity3RoomWait);
            this.Controls.Add(this.RoomTime2);
            this.Controls.Add(this.Severity2RoomWait);
            this.Controls.Add(this.RoomTime1);
            this.Controls.Add(this.Severity1RoomWait);
            this.Controls.Add(this.ChangeRoomWait);
            this.Controls.Add(this.PercentChance4);
            this.Controls.Add(this.Severity4Percent);
            this.Controls.Add(this.PercentChance3);
            this.Controls.Add(this.Severity3Percent);
            this.Controls.Add(this.PercentChance2);
            this.Controls.Add(this.Severity2Percent);
            this.Controls.Add(this.PercentChance1);
            this.Controls.Add(this.Severity1Percent);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.ChangeFreqPercent);
            this.Controls.Add(this.RoomDropDown);
            this.Controls.Add(this.ChangeNumRooms);
            this.Controls.Add(this.TimeUnitsLabel);
            this.Controls.Add(this.AverageDelay);
            this.Controls.Add(this.DelayMaxValue);
            this.Controls.Add(this.DelayMinValue);
            this.Controls.Add(this.SettingsLabel);
            this.Controls.Add(this.ChangeAveDelay);
            this.Controls.Add(this.TimedSimButton);
            this.Controls.Add(this.InstantSimButton);
            this.Controls.Add(this.topMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.topMenu;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrontPanel";
            this.Text = "Hospital Simulation";
            ((System.ComponentModel.ISupportInitialize)(this.DelayMinValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayMaxValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity1Percent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity2Percent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity3Percent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity4Percent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity4RoomWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity3RoomWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity2RoomWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity1RoomWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftLength)).EndInit();
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button InstantSimButton;
        private System.Windows.Forms.Button TimedSimButton;
        private System.Windows.Forms.CheckBox ChangeAveDelay;
        private System.Windows.Forms.Label SettingsLabel;
        private System.Windows.Forms.NumericUpDown DelayMinValue;
        private System.Windows.Forms.NumericUpDown DelayMaxValue;
        private System.Windows.Forms.Label AverageDelay;
        private System.Windows.Forms.Label TimeUnitsLabel;
        private System.Windows.Forms.CheckBox ChangeNumRooms;
        private System.Windows.Forms.ComboBox RoomDropDown;
        private System.Windows.Forms.CheckBox ChangeFreqPercent;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.NumericUpDown Severity1Percent;
        private System.Windows.Forms.Label PercentChance1;
        private System.Windows.Forms.Label PercentChance2;
        private System.Windows.Forms.NumericUpDown Severity2Percent;
        private System.Windows.Forms.Label PercentChance3;
        private System.Windows.Forms.NumericUpDown Severity3Percent;
        private System.Windows.Forms.Label PercentChance4;
        private System.Windows.Forms.NumericUpDown Severity4Percent;
        private System.Windows.Forms.Label RoomTime4;
        private System.Windows.Forms.NumericUpDown Severity4RoomWait;
        private System.Windows.Forms.Label RoomTime3;
        private System.Windows.Forms.NumericUpDown Severity3RoomWait;
        private System.Windows.Forms.Label RoomTime2;
        private System.Windows.Forms.NumericUpDown Severity2RoomWait;
        private System.Windows.Forms.Label RoomTime1;
        private System.Windows.Forms.NumericUpDown Severity1RoomWait;
        private System.Windows.Forms.CheckBox ChangeRoomWait;
        private System.Windows.Forms.Label shiftLengthLabel;
        private System.Windows.Forms.NumericUpDown shiftLength;
        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

