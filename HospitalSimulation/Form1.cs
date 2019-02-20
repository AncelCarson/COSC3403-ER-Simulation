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
    public partial class FrontPanel : Form
    {
        float delayMin, delayMax, delayAverage;
        int numRooms;
        int[] severityRatings = new int[4];
        int[] roomTimes = new int[4];
        float[] waitDelays = new float[3];
        HelpForm help;
        SimulationWindow simulation;
        Results results;

        public FrontPanel()
        {
            InitializeComponent();
            delayMin = (float)DelayMinValue.Value;
            delayMax = (float)DelayMaxValue.Value;
            delayAverage = ((delayMin + delayMax) / 2);
            AverageDelay.Text = delayAverage.ToString("n2");
        }

        private void ChangeAveDelay_CheckedChanged(object sender, EventArgs e)
        {
            if (ChangeAveDelay.Checked == true)
            {
                DelayMinValue.Enabled = true;
                DelayMaxValue.Enabled = true;
            }
            else
            {
                DelayMinValue.Enabled = false;
                DelayMaxValue.Enabled = false;
                DelayMinValue.Value = 0;
                DelayMaxValue.Value = 15;
            }
        }

        private void DelayMinValue_ValueChanged(object sender, EventArgs e)
        {
            delayMin = (float)DelayMinValue.Value;
            delayMax = (float)DelayMaxValue.Value;
            delayAverage = ((delayMin + delayMax) / 2);
            AverageDelay.Text = delayAverage.ToString("n2");
        }

        private void DelayMaxValue_ValueChanged(object sender, EventArgs e)
        {
            delayMin = (float)DelayMinValue.Value;
            delayMax = (float)DelayMaxValue.Value;
            delayAverage = ((delayMin + delayMax) / 2);
            AverageDelay.Text = delayAverage.ToString("n2");
        }

        private void ChangeNumRooms_CheckedChanged(object sender, EventArgs e)
        {
            if (ChangeNumRooms.Checked == true)
            {
                RoomDropDown.Enabled = true;
            }
            else
            {
                RoomDropDown.SelectedIndex = 5;
                RoomDropDown.Enabled = false;
            }
        }

        private void ChangeFreqPercent_CheckedChanged(object sender, EventArgs e)
        {
            if (ChangeFreqPercent.Checked == true)
            {
                Severity1Percent.Enabled = true;
                Severity2Percent.Enabled = true;
                Severity3Percent.Enabled = true;
                Severity4Percent.Enabled = true;
            }
            else
            {
                Severity1Percent.Value = 20;
                Severity2Percent.Value = 30;
                Severity3Percent.Value = 40;
                Severity4Percent.Value = 10;
                Severity1Percent.Enabled = false;
                Severity2Percent.Enabled = false;
                Severity3Percent.Enabled = false;
                Severity4Percent.Enabled = false;
            }
        }

        private void ChangeRoomWait_CheckedChanged(object sender, EventArgs e)
        {
            if (ChangeRoomWait.Checked == true)
            {
                Severity1RoomWait.Enabled = true;
                Severity2RoomWait.Enabled = true;
                Severity3RoomWait.Enabled = true;
                Severity4RoomWait.Enabled = true;
            }
            else
            {
                Severity1RoomWait.Value = 30;
                Severity2RoomWait.Value = 45;
                Severity3RoomWait.Value = 60;
                Severity4RoomWait.Value = 20;
                Severity1RoomWait.Enabled = false;
                Severity2RoomWait.Enabled = false;
                Severity3RoomWait.Enabled = false;
                Severity4RoomWait.Enabled = false;
            }
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            if (help != null)
            {
                help.Close();
            }

            help = new HelpForm();
            help.Show();

        }

        private void TimedSimButton_Click(object sender, EventArgs e)
        {
            SetSentValues();
            simulation = new SimulationWindow(numRooms, severityRatings, roomTimes, waitDelays);
            simulation.Show();
        }

        private void InstantSimButton_Click(object sender, EventArgs e)
        {
            SetSentValues();
            results = new Results();
            results.Show();
        }

        private void SetSentValues()
        {
            numRooms = RoomDropDown.SelectedIndex;
            severityRatings[0] = (int)Severity1Percent.Value;
            severityRatings[1] = (int)Severity2Percent.Value;
            severityRatings[2] = (int)Severity3Percent.Value;
            severityRatings[3] = (int)Severity4Percent.Value;
            roomTimes[0] = (int)Severity1RoomWait.Value;
            roomTimes[1] = (int)Severity2RoomWait.Value;
            roomTimes[2] = (int)Severity3RoomWait.Value;
            roomTimes[3] = (int)Severity4RoomWait.Value;
            waitDelays[0] = delayMin;
            waitDelays[1] = delayMax;
            waitDelays[2] = delayAverage;
        }
    }
}
