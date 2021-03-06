﻿namespace HospitalSimulation
{
    partial class Results
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Results));
            this.ExtraTimeLabel = new System.Windows.Forms.Label();
            this.ShiftTimeLabel = new System.Windows.Forms.Label();
            this.PatientLabel = new System.Windows.Forms.Label();
            this.Rating1Count = new System.Windows.Forms.Label();
            this.Rating2Count = new System.Windows.Forms.Label();
            this.Rating3Count = new System.Windows.Forms.Label();
            this.Rating4Count = new System.Windows.Forms.Label();
            this.AveLabel = new System.Windows.Forms.Label();
            this.AveWait1 = new System.Windows.Forms.Label();
            this.AveWait2 = new System.Windows.Forms.Label();
            this.AveWait3 = new System.Windows.Forms.Label();
            this.AveWait4 = new System.Windows.Forms.Label();
            this.EmptyRoomCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExtraTimeLabel
            // 
            this.ExtraTimeLabel.AutoSize = true;
            this.ExtraTimeLabel.Location = new System.Drawing.Point(15, 110);
            this.ExtraTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ExtraTimeLabel.Name = "ExtraTimeLabel";
            this.ExtraTimeLabel.Size = new System.Drawing.Size(234, 13);
            this.ExtraTimeLabel.TabIndex = 0;
            this.ExtraTimeLabel.Text = "It took 1.25 hours to room the remaining patients";
            // 
            // ShiftTimeLabel
            // 
            this.ShiftTimeLabel.AutoSize = true;
            this.ShiftTimeLabel.Location = new System.Drawing.Point(6, 9);
            this.ShiftTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShiftTimeLabel.Name = "ShiftTimeLabel";
            this.ShiftTimeLabel.Size = new System.Drawing.Size(76, 13);
            this.ShiftTimeLabel.TabIndex = 1;
            this.ShiftTimeLabel.Text = "After 10 hours:";
            // 
            // PatientLabel
            // 
            this.PatientLabel.AutoSize = true;
            this.PatientLabel.Location = new System.Drawing.Point(15, 30);
            this.PatientLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PatientLabel.Name = "PatientLabel";
            this.PatientLabel.Size = new System.Drawing.Size(69, 13);
            this.PatientLabel.TabIndex = 2;
            this.PatientLabel.Text = "Patients Left:";
            // 
            // Rating1Count
            // 
            this.Rating1Count.AutoSize = true;
            this.Rating1Count.Location = new System.Drawing.Point(29, 49);
            this.Rating1Count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Rating1Count.Name = "Rating1Count";
            this.Rating1Count.Size = new System.Drawing.Size(132, 13);
            this.Rating1Count.TabIndex = 3;
            this.Rating1Count.Text = "10 patients of rating type 1";
            // 
            // Rating2Count
            // 
            this.Rating2Count.AutoSize = true;
            this.Rating2Count.Location = new System.Drawing.Point(29, 63);
            this.Rating2Count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Rating2Count.Name = "Rating2Count";
            this.Rating2Count.Size = new System.Drawing.Size(126, 13);
            this.Rating2Count.TabIndex = 4;
            this.Rating2Count.Text = "7 patients of rating type 2";
            // 
            // Rating3Count
            // 
            this.Rating3Count.AutoSize = true;
            this.Rating3Count.Location = new System.Drawing.Point(29, 76);
            this.Rating3Count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Rating3Count.Name = "Rating3Count";
            this.Rating3Count.Size = new System.Drawing.Size(126, 13);
            this.Rating3Count.TabIndex = 5;
            this.Rating3Count.Text = "2 patients of rating type 3";
            // 
            // Rating4Count
            // 
            this.Rating4Count.AutoSize = true;
            this.Rating4Count.Location = new System.Drawing.Point(29, 90);
            this.Rating4Count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Rating4Count.Name = "Rating4Count";
            this.Rating4Count.Size = new System.Drawing.Size(126, 13);
            this.Rating4Count.TabIndex = 6;
            this.Rating4Count.Text = "0 patients of rating type 4";
            // 
            // AveLabel
            // 
            this.AveLabel.AutoSize = true;
            this.AveLabel.Location = new System.Drawing.Point(6, 133);
            this.AveLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AveLabel.Name = "AveLabel";
            this.AveLabel.Size = new System.Drawing.Size(55, 13);
            this.AveLabel.TabIndex = 7;
            this.AveLabel.Text = "Averages:";
            // 
            // AveWait1
            // 
            this.AveWait1.AutoSize = true;
            this.AveWait1.Location = new System.Drawing.Point(15, 151);
            this.AveWait1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AveWait1.Name = "AveWait1";
            this.AveWait1.Size = new System.Drawing.Size(201, 13);
            this.AveWait1.TabIndex = 8;
            this.AveWait1.Text = "Average wait time for rating 1: 90 minutes";
            // 
            // AveWait2
            // 
            this.AveWait2.AutoSize = true;
            this.AveWait2.Location = new System.Drawing.Point(15, 165);
            this.AveWait2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AveWait2.Name = "AveWait2";
            this.AveWait2.Size = new System.Drawing.Size(201, 13);
            this.AveWait2.TabIndex = 9;
            this.AveWait2.Text = "Average wait time for rating 2: 60 minutes";
            // 
            // AveWait3
            // 
            this.AveWait3.AutoSize = true;
            this.AveWait3.Location = new System.Drawing.Point(15, 178);
            this.AveWait3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AveWait3.Name = "AveWait3";
            this.AveWait3.Size = new System.Drawing.Size(201, 13);
            this.AveWait3.TabIndex = 10;
            this.AveWait3.Text = "Average wait time for rating 3: 30 minutes";
            // 
            // AveWait4
            // 
            this.AveWait4.AutoSize = true;
            this.AveWait4.Location = new System.Drawing.Point(15, 192);
            this.AveWait4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AveWait4.Name = "AveWait4";
            this.AveWait4.Size = new System.Drawing.Size(195, 13);
            this.AveWait4.TabIndex = 11;
            this.AveWait4.Text = "Average wait time for rating 4: 2 minutes";
            // 
            // EmptyRoomCount
            // 
            this.EmptyRoomCount.AutoSize = true;
            this.EmptyRoomCount.Location = new System.Drawing.Point(6, 218);
            this.EmptyRoomCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmptyRoomCount.Name = "EmptyRoomCount";
            this.EmptyRoomCount.Size = new System.Drawing.Size(233, 13);
            this.EmptyRoomCount.TabIndex = 12;
            this.EmptyRoomCount.Text = "0 rooms were empty by the end of the simulation";
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 249);
            this.Controls.Add(this.EmptyRoomCount);
            this.Controls.Add(this.AveWait4);
            this.Controls.Add(this.AveWait3);
            this.Controls.Add(this.AveWait2);
            this.Controls.Add(this.AveWait1);
            this.Controls.Add(this.AveLabel);
            this.Controls.Add(this.Rating4Count);
            this.Controls.Add(this.Rating3Count);
            this.Controls.Add(this.Rating2Count);
            this.Controls.Add(this.Rating1Count);
            this.Controls.Add(this.PatientLabel);
            this.Controls.Add(this.ShiftTimeLabel);
            this.Controls.Add(this.ExtraTimeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Results";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExtraTimeLabel;
        private System.Windows.Forms.Label ShiftTimeLabel;
        private System.Windows.Forms.Label PatientLabel;
        private System.Windows.Forms.Label Rating1Count;
        private System.Windows.Forms.Label Rating2Count;
        private System.Windows.Forms.Label Rating3Count;
        private System.Windows.Forms.Label Rating4Count;
        private System.Windows.Forms.Label AveLabel;
        private System.Windows.Forms.Label AveWait1;
        private System.Windows.Forms.Label AveWait2;
        private System.Windows.Forms.Label AveWait3;
        private System.Windows.Forms.Label AveWait4;
        private System.Windows.Forms.Label EmptyRoomCount;
    }
}