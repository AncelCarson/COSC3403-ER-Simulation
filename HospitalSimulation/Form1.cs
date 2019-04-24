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
        int numRooms;
        int[] severityRatings = new int[4];
        int[] roomTimes = new int[4];
        float delayMin, delayMax, delayAverage;
        float[] waitDelays = new float[3];
        HelpForm help;
        SimulationWindow simulation;
        Results results;
        int shiftLen;
        PatientQueue patients;

        public FrontPanel()
        {
            InitializeComponent();
            delayMin = (float)DelayMinValue.Value;
            delayMax = (float)DelayMaxValue.Value;
            delayAverage = ((delayMin + delayMax) / 2);
            AverageDelay.Text = delayAverage.ToString("n2");
            shiftLength.Enabled = true;
            /*
            Label[] PercentChance = new Label[4];
            PercentChance[0] = PercentChance1;
            PercentChance[1] = PercentChance2;
            PercentChance[2] = PercentChance3;
            PercentChance[3] = PercentChance4;
            */

            /*
            Label[] RoomTime = new Label[4];
            RoomTime[0] = RoomTime1;
            RoomTime[1] = RoomTime2;
            RoomTime[2] = RoomTime3;
            RoomTime[3] = RoomTime4;
            */

            /*
            NumericUpDown[] SeverityPercent = new NumericUpDown[4];
            SeverityPercent[0] = Severity1Percent;
            SeverityPercent[1] = Severity2Percent;
            SeverityPercent[2] = Severity3Percent;
            SeverityPercent[3] = Severity4Percent;

            NumericUpDown[] WaitTime = new NumericUpDown[4];
            WaitTime[0] = Severity1RoomWait;
            WaitTime[1] = Severity2RoomWait;
            WaitTime[2] = Severity3RoomWait;
            WaitTime[3] = Severity4RoomWait;
            */
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

        private void shiftLength_ValueChanged(object sender, EventArgs e)
        {
            shiftLen = (int)shiftLength.Value;
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
            if (CheckChances())
            {
                simulation = new SimulationWindow(numRooms, shiftLen, severityRatings, roomTimes, waitDelays);
                simulation.Show();
            }
        }

        private void InstantSimButton_Click(object sender, EventArgs e)
        {
            SetSentValues();
            if (CheckChances())
            {
                results = new Results();
                results.Show();
            }
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

        private Boolean CheckChances()
        {
            int totalChance = 0;
            for (int i = 0; i <= 3; i++)
            {
                totalChance += severityRatings[i];
            }
            if (totalChance != 100)
            {
                MessageBox.Show("Chance values must add to 100.", "Check values and try again");
                return false;
            }
            return true;
        }

        void InstantSimulation()
        {
            /*
             * int shiftRemaining = shiftLen * 60;
            //Pregenerate patients
            for (int j = 0; j <= shiftLen * 60;)
            {
                //Create new patient
                j += patients.AddPatient().GetDelayTime();
            }

            shiftRemaining -= patients.GetPatient(1).GetDelayTime();

            //Run Shift
            for (int i = 0; i <= shiftRemaining;)
            {
                for (int ii=0; i < numRooms; i++)
                {
                    //Remove roomtime by shortest
                }

                //Add wait time to other patients

                //Resort Queue
            }

            //While loop check if still patients
                //Same operations as run shift
            */
        }
    }
}
