using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalSimulation
{
    public partial class Results : Form
    {
        Label[] AveWait = new Label[4],
            RatingCount = new Label[4];

        public Results()
        {
            InitializeComponent();
            SetGroups();
        }

        public Results(float shiftLen, int[] closeWait, int closeTime, float[] aveWaits, int openRooms, int simNum)
        {
            InitializeComponent();
            SetGroups();
            this.Text = "Results for " + simNum;
            ShiftTimeLabel.Text = "After " + shiftLen + " hours:";
            RatingCount[0].Text = closeWait[0] + " patients of rating type 1";
            RatingCount[1].Text = closeWait[1] + " patients of rating type 2";
            RatingCount[2].Text = closeWait[2] + " patients of rating type 3";
            RatingCount[3].Text = closeWait[3] + " patients of rating type 4";
            ExtraTimeLabel.Text = "It took " + (((float)closeTime/600) - (float)shiftLen).ToString("n2") + " hours to room the remaining patients";
            AveWait[0].Text = "Average wait time for rating 1: " + aveWaits[0].ToString("n2") + " minutes";
            AveWait[1].Text = "Average wait time for rating 2: " + aveWaits[1].ToString("n2") + " minutes";
            AveWait[2].Text = "Average wait time for rating 3: " + aveWaits[2].ToString("n2") + " minutes";
            AveWait[3].Text = "Average wait time for rating 4: " + aveWaits[3].ToString("n2") + " minutes";
            EmptyRoomCount.Text = openRooms + " rooms were empty by the end of the simulation";
        }

        private void SetGroups()
        {
            AveWait[0] = AveWait1;
            AveWait[1] = AveWait2;
            AveWait[2] = AveWait3;
            AveWait[3] = AveWait4;

            RatingCount[0] = Rating1Count;
            RatingCount[1] = Rating2Count;
            RatingCount[2] = Rating3Count;
            RatingCount[3] = Rating4Count;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
