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
            this.Severity41RoomWait = new System.Windows.Forms.NumericUpDown();
            this.RoomTime3 = new System.Windows.Forms.Label();
            this.Severity3RoomWait = new System.Windows.Forms.NumericUpDown();
            this.RoomTime2 = new System.Windows.Forms.Label();
            this.Severity2RoomWait = new System.Windows.Forms.NumericUpDown();
            this.RoomTime1 = new System.Windows.Forms.Label();
            this.Severity1RoomWait = new System.Windows.Forms.NumericUpDown();
            this.ChangeRoomWait = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DelayMinValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayMaxValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity1Percent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity2Percent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity3Percent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity4Percent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity41RoomWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity3RoomWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity2RoomWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity1RoomWait)).BeginInit();
            this.SuspendLayout();
            // 
            // InstantSimButton
            // 
            this.InstantSimButton.Location = new System.Drawing.Point(379, 392);
            this.InstantSimButton.Name = "InstantSimButton";
            this.InstantSimButton.Size = new System.Drawing.Size(244, 57);
            this.InstantSimButton.TabIndex = 1;
            this.InstantSimButton.Text = "Instant Simulation";
            this.InstantSimButton.UseVisualStyleBackColor = true;
            // 
            // TimedSimButton
            // 
            this.TimedSimButton.Location = new System.Drawing.Point(107, 392);
            this.TimedSimButton.Name = "TimedSimButton";
            this.TimedSimButton.Size = new System.Drawing.Size(260, 57);
            this.TimedSimButton.TabIndex = 2;
            this.TimedSimButton.Text = "Timed Simulation";
            this.TimedSimButton.UseVisualStyleBackColor = true;
            // 
            // ChangeAveDelay
            // 
            this.ChangeAveDelay.AutoSize = true;
            this.ChangeAveDelay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeAveDelay.Location = new System.Drawing.Point(17, 48);
            this.ChangeAveDelay.Name = "ChangeAveDelay";
            this.ChangeAveDelay.Size = new System.Drawing.Size(284, 29);
            this.ChangeAveDelay.TabIndex = 3;
            this.ChangeAveDelay.Text = "Average patient arrival delay";
            this.ChangeAveDelay.UseVisualStyleBackColor = true;
            this.ChangeAveDelay.CheckedChanged += new System.EventHandler(this.ChangeAveDelay_CheckedChanged);
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.Location = new System.Drawing.Point(12, 9);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(611, 25);
            this.SettingsLabel.TabIndex = 4;
            this.SettingsLabel.Text = "If you would like to change any values click the appropriate check box";
            // 
            // DelayMinValue
            // 
            this.DelayMinValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelayMinValue.Enabled = false;
            this.DelayMinValue.Location = new System.Drawing.Point(17, 83);
            this.DelayMinValue.Name = "DelayMinValue";
            this.DelayMinValue.Size = new System.Drawing.Size(68, 29);
            this.DelayMinValue.TabIndex = 5;
            this.DelayMinValue.ValueChanged += new System.EventHandler(this.DelayMinValue_ValueChanged);
            // 
            // DelayMaxValue
            // 
            this.DelayMaxValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelayMaxValue.Enabled = false;
            this.DelayMaxValue.Location = new System.Drawing.Point(91, 83);
            this.DelayMaxValue.Name = "DelayMaxValue";
            this.DelayMaxValue.Size = new System.Drawing.Size(67, 29);
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
            this.AverageDelay.Location = new System.Drawing.Point(176, 85);
            this.AverageDelay.Name = "AverageDelay";
            this.AverageDelay.Size = new System.Drawing.Size(39, 25);
            this.AverageDelay.TabIndex = 7;
            this.AverageDelay.Text = "7.5";
            // 
            // TimeUnitsLabel
            // 
            this.TimeUnitsLabel.AutoSize = true;
            this.TimeUnitsLabel.Location = new System.Drawing.Point(221, 85);
            this.TimeUnitsLabel.Name = "TimeUnitsLabel";
            this.TimeUnitsLabel.Size = new System.Drawing.Size(80, 25);
            this.TimeUnitsLabel.TabIndex = 8;
            this.TimeUnitsLabel.Text = "minutes";
            // 
            // ChangeNumRooms
            // 
            this.ChangeNumRooms.AutoSize = true;
            this.ChangeNumRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeNumRooms.Location = new System.Drawing.Point(322, 48);
            this.ChangeNumRooms.Name = "ChangeNumRooms";
            this.ChangeNumRooms.Size = new System.Drawing.Size(269, 29);
            this.ChangeNumRooms.TabIndex = 9;
            this.ChangeNumRooms.Text = "Number of avaliable rooms";
            this.ChangeNumRooms.UseVisualStyleBackColor = true;
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
            this.RoomDropDown.Location = new System.Drawing.Point(322, 80);
            this.RoomDropDown.Name = "RoomDropDown";
            this.RoomDropDown.Size = new System.Drawing.Size(121, 32);
            this.RoomDropDown.TabIndex = 10;
            this.RoomDropDown.Text = "6";
            // 
            // ChangeFreqPercent
            // 
            this.ChangeFreqPercent.AutoSize = true;
            this.ChangeFreqPercent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeFreqPercent.Location = new System.Drawing.Point(17, 139);
            this.ChangeFreqPercent.Name = "ChangeFreqPercent";
            this.ChangeFreqPercent.Size = new System.Drawing.Size(279, 29);
            this.ChangeFreqPercent.TabIndex = 11;
            this.ChangeFreqPercent.Text = "Percent chance per severity";
            this.ChangeFreqPercent.UseVisualStyleBackColor = true;
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(9, 392);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(75, 58);
            this.HelpButton.TabIndex = 12;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            // 
            // Severity1Percent
            // 
            this.Severity1Percent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Severity1Percent.Enabled = false;
            this.Severity1Percent.Location = new System.Drawing.Point(17, 174);
            this.Severity1Percent.Name = "Severity1Percent";
            this.Severity1Percent.Size = new System.Drawing.Size(78, 29);
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
            this.PercentChance1.Location = new System.Drawing.Point(119, 175);
            this.PercentChance1.Name = "PercentChance1";
            this.PercentChance1.Size = new System.Drawing.Size(159, 25);
            this.PercentChance1.TabIndex = 14;
            this.PercentChance1.Text = "Severity Rating 1";
            // 
            // PercentChance2
            // 
            this.PercentChance2.AutoSize = true;
            this.PercentChance2.Location = new System.Drawing.Point(119, 211);
            this.PercentChance2.Name = "PercentChance2";
            this.PercentChance2.Size = new System.Drawing.Size(159, 25);
            this.PercentChance2.TabIndex = 16;
            this.PercentChance2.Text = "Severity Rating 2";
            // 
            // Severity2Percent
            // 
            this.Severity2Percent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Severity2Percent.Enabled = false;
            this.Severity2Percent.Location = new System.Drawing.Point(17, 210);
            this.Severity2Percent.Name = "Severity2Percent";
            this.Severity2Percent.Size = new System.Drawing.Size(78, 29);
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
            this.PercentChance3.Location = new System.Drawing.Point(119, 246);
            this.PercentChance3.Name = "PercentChance3";
            this.PercentChance3.Size = new System.Drawing.Size(159, 25);
            this.PercentChance3.TabIndex = 18;
            this.PercentChance3.Text = "Severity Rating 3";
            // 
            // Severity3Percent
            // 
            this.Severity3Percent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Severity3Percent.Enabled = false;
            this.Severity3Percent.Location = new System.Drawing.Point(17, 245);
            this.Severity3Percent.Name = "Severity3Percent";
            this.Severity3Percent.Size = new System.Drawing.Size(78, 29);
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
            this.PercentChance4.Location = new System.Drawing.Point(119, 281);
            this.PercentChance4.Name = "PercentChance4";
            this.PercentChance4.Size = new System.Drawing.Size(159, 25);
            this.PercentChance4.TabIndex = 20;
            this.PercentChance4.Text = "Severity Rating 4";
            // 
            // Severity4Percent
            // 
            this.Severity4Percent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Severity4Percent.Enabled = false;
            this.Severity4Percent.Location = new System.Drawing.Point(17, 280);
            this.Severity4Percent.Name = "Severity4Percent";
            this.Severity4Percent.Size = new System.Drawing.Size(78, 29);
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
            this.RoomTime4.Location = new System.Drawing.Point(424, 281);
            this.RoomTime4.Name = "RoomTime4";
            this.RoomTime4.Size = new System.Drawing.Size(159, 25);
            this.RoomTime4.TabIndex = 29;
            this.RoomTime4.Text = "Severity Rating 4";
            // 
            // Severity41RoomWait
            // 
            this.Severity41RoomWait.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Severity41RoomWait.Enabled = false;
            this.Severity41RoomWait.Location = new System.Drawing.Point(322, 280);
            this.Severity41RoomWait.Name = "Severity41RoomWait";
            this.Severity41RoomWait.Size = new System.Drawing.Size(78, 29);
            this.Severity41RoomWait.TabIndex = 28;
            this.Severity41RoomWait.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // RoomTime3
            // 
            this.RoomTime3.AutoSize = true;
            this.RoomTime3.Location = new System.Drawing.Point(424, 246);
            this.RoomTime3.Name = "RoomTime3";
            this.RoomTime3.Size = new System.Drawing.Size(159, 25);
            this.RoomTime3.TabIndex = 27;
            this.RoomTime3.Text = "Severity Rating 3";
            // 
            // Severity3RoomWait
            // 
            this.Severity3RoomWait.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Severity3RoomWait.Enabled = false;
            this.Severity3RoomWait.Location = new System.Drawing.Point(322, 245);
            this.Severity3RoomWait.Name = "Severity3RoomWait";
            this.Severity3RoomWait.Size = new System.Drawing.Size(78, 29);
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
            this.RoomTime2.Location = new System.Drawing.Point(424, 211);
            this.RoomTime2.Name = "RoomTime2";
            this.RoomTime2.Size = new System.Drawing.Size(159, 25);
            this.RoomTime2.TabIndex = 25;
            this.RoomTime2.Text = "Severity Rating 2";
            // 
            // Severity2RoomWait
            // 
            this.Severity2RoomWait.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Severity2RoomWait.Enabled = false;
            this.Severity2RoomWait.Location = new System.Drawing.Point(322, 210);
            this.Severity2RoomWait.Name = "Severity2RoomWait";
            this.Severity2RoomWait.Size = new System.Drawing.Size(78, 29);
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
            this.RoomTime1.Location = new System.Drawing.Point(424, 175);
            this.RoomTime1.Name = "RoomTime1";
            this.RoomTime1.Size = new System.Drawing.Size(159, 25);
            this.RoomTime1.TabIndex = 23;
            this.RoomTime1.Text = "Severity Rating 1";
            // 
            // Severity1RoomWait
            // 
            this.Severity1RoomWait.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Severity1RoomWait.Enabled = false;
            this.Severity1RoomWait.Location = new System.Drawing.Point(322, 174);
            this.Severity1RoomWait.Name = "Severity1RoomWait";
            this.Severity1RoomWait.Size = new System.Drawing.Size(78, 29);
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
            this.ChangeRoomWait.Location = new System.Drawing.Point(322, 139);
            this.ChangeRoomWait.Name = "ChangeRoomWait";
            this.ChangeRoomWait.Size = new System.Drawing.Size(202, 29);
            this.ChangeRoomWait.TabIndex = 21;
            this.ChangeRoomWait.Text = "Average room time";
            this.ChangeRoomWait.UseVisualStyleBackColor = true;
            // 
            // FrontPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 463);
            this.Controls.Add(this.RoomTime4);
            this.Controls.Add(this.Severity41RoomWait);
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
            this.Name = "FrontPanel";
            this.Text = "Hospital Simulation";
            ((System.ComponentModel.ISupportInitialize)(this.DelayMinValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayMaxValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity1Percent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity2Percent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity3Percent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity4Percent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity41RoomWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity3RoomWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity2RoomWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Severity1RoomWait)).EndInit();
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
        private System.Windows.Forms.NumericUpDown Severity41RoomWait;
        private System.Windows.Forms.Label RoomTime3;
        private System.Windows.Forms.NumericUpDown Severity3RoomWait;
        private System.Windows.Forms.Label RoomTime2;
        private System.Windows.Forms.NumericUpDown Severity2RoomWait;
        private System.Windows.Forms.Label RoomTime1;
        private System.Windows.Forms.NumericUpDown Severity1RoomWait;
        private System.Windows.Forms.CheckBox ChangeRoomWait;
    }
}

