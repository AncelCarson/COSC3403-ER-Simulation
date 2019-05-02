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
        int[] severityRatings = new int[4],
            roomTimes = new int[4];
        float delayMin, 
            delayMax, 
            delayAverage, 
            shiftLen;
        float[] waitDelays = new float[3];
        HelpForm help;
        SimulationWindow simulation;
        Results results;
        PatientQueue patients;
        int instantSimNum=0;
        Random rnd = new Random();

        public FrontPanel()
        {
            InitializeComponent();

            //Initialize Varraibles
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
            shiftLen = (float)shiftLength.Value;
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
            UpdateSentValues();
            if (CheckValues())
            {
                simulation = new SimulationWindow(numRooms, shiftLen, severityRatings, roomTimes, waitDelays, ref rnd);
                simulation.Show();
            }
        }

        public void InstantSimButton_Click(object sender, EventArgs e)
        {
            UpdateSentValues();
            if (CheckValues())
            {
                patients = new PatientQueue(numRooms, ref rnd);
                InstantSimulation(ref (patients));
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (help != null)
            {
                help.Close();
            }

            help = new HelpForm();
            help.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Boolean CheckValues()
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

            if(waitDelays[0] > waitDelays[1])
            {
                MessageBox.Show("Delay values must be formatted minimum then maximum.", "Check values and try again");
                return false;
            }
            return true;
        }

        void InstantSimulation(ref PatientQueue patients)
        {
            
            float shift=0;
            float shiftOver = 0;
            int lowestRoomtime;
            int numPatients = 0;
            int openRooms = 0;
            int rating1 = 0;
            int rating2 = 0;
            int rating3 = 0;
            int rating4 = 0;
            instantSimNum++;
            //int counter =0;

            //Pregenerate patients
            for (float j = 0; j <= shiftLen * 60;)
            {
                //Create new patient
                numPatients++;
                patients.AddPatient(ref (severityRatings), ref (roomTimes), ref (waitDelays));
                j += patients.GetPatient(numPatients).GetDelayTime();
                patients.GetPatient(numPatients).SetArrivalTime((int)j);
                
            }

            shift += patients.GetPatient(1).GetArrivalTime();

            //Run Shift
            while (shift <= shiftLen*60)
            {
                //counter++;
                //System.Diagnostics.Debug.WriteLine(counter);
                lowestRoomtime = 100000;
                //if not null -> if arrived -> if smaller than current room time
                for (int z = 1; z <= numRooms; z++)
                {
                    /*System.Diagnostics.Debug.Write("Arive Time");
                    System.Diagnostics.Debug.WriteLine(patients.GetPatient(z).GetArrivalTime());
                    System.Diagnostics.Debug.Write("current Time");
                    System.Diagnostics.Debug.WriteLine(shift);*/
                    //if (patients.GetPatient(z) != null)
                    {
                        if (patients.GetPatient(z).GetArrivalTime() <= shift)
                        {
                            if (patients.GetPatient(z).roomTimeManip < lowestRoomtime)
                            {
                                lowestRoomtime = patients.GetPatient(z).roomTimeManip;
                            }
                        }
                    }
                }

                for (int i=1; i <= numRooms; i++)
                {
                    //if(patients.GetPatient(i)!= null)
                    {
                        if (patients.GetPatient(i).GetArrivalTime() <= shift)
                        {
                            /*if (patients.GetPatient(i).GetArrivalTime() < shift && patients.GetPatient(i).GetArrivalTime() > shift - lowestRoomtime)
                            {
                                System.Diagnostics.Debug.WriteLine("Is this Possible?");
                                patients.GetPatient(i).roomTime -= (int)(shift - patients.GetPatient(i).GetArrivalTime());
                            }*/
                            patients.GetPatient(i).roomTimeManip -= lowestRoomtime;

                            //Creates inacuracies if value is less than zero as that is not propogated forward
                            if (patients.GetPatient(i).roomTimeManip <= 0)
                            {
                                if (patients.GetPatient(i).roomTimeManip == 0)
                                {
                                    patients.RemovePatient(i, shift);
                                }
                            }
                        }
                    }
                    
                }
                //System.Diagnostics.Debug.WriteLine(shift);
                //Resort Queue
                patients.SortQueue((int)shift);
                shift += lowestRoomtime;
            }
            for (int i = 1; i <= numRooms; i++)
            {
                if (patients.GetPatient(i) == null)
                {
                    openRooms++;
                }
                else
                {
                    switch (patients.GetPatient(i).GetRating())
                    {
                        case 1: rating1++; break;
                        case 2: rating2++; break;
                        case 3: rating3++; break;
                        case 4: rating4++; break;
                    }
                        
                }
            }
            for(int i = numRooms+1; i <= patients.GetSize();i++)
            {
                switch (patients.GetPatient(i).GetRating())
                {
                    case 1: rating1++; break;
                    case 2: rating2++; break;
                    case 3: rating3++; break;
                    case 4: rating4++; break;
                }
            }

            while (patients.GetPatient(numRooms+1)!= null)
            {
                //counter++;
                //System.Diagnostics.Debug.WriteLine(counter);
                lowestRoomtime = 100000;
                //if not null -> if arrived -> if smaller than current room time
                for (int z = 1; z <= numRooms; z++)
                {
                    /*System.Diagnostics.Debug.Write("Arive Time");
                    System.Diagnostics.Debug.WriteLine(patients.GetPatient(z).GetArrivalTime());
                    System.Diagnostics.Debug.Write("current Time");
                    System.Diagnostics.Debug.WriteLine(shift);*/
                    //if (patients.GetPatient(z) != null)
                    {
                        if (patients.GetPatient(z).GetArrivalTime() <= shift+shiftOver)
                        {
                            if (patients.GetPatient(z).roomTimeManip < lowestRoomtime)
                            {
                                lowestRoomtime = patients.GetPatient(z).roomTimeManip;
                            }
                        }
                    }
                }

                for (int i = 1; i <= numRooms; i++)
                {
                    //if (patients.GetPatient(i) != null)
                    {
                        if (patients.GetPatient(i).GetArrivalTime() <= shift + shiftOver)
                        {
                            /*if (patients.GetPatient(i).GetArrivalTime() < shift && patients.GetPatient(i).GetArrivalTime() > shift - lowestRoomtime)
                            {
                                System.Diagnostics.Debug.WriteLine("Is this Possible?");
                                patients.GetPatient(i).roomTime -= (int)(shift - patients.GetPatient(i).GetArrivalTime());
                            }*/
                            patients.GetPatient(i).roomTimeManip -= lowestRoomtime;

                            //Creates inacuracies if value is less than zero as that is not propogated forward
                            if (patients.GetPatient(i).roomTimeManip <= 0)
                            {
                                if (patients.GetPatient(i).roomTimeManip == 0)
                                {
                                    patients.RemovePatient(i, shift + shiftOver);
                                }
                            }
                        }
                    }

                }
                //System.Diagnostics.Debug.WriteLine(shift);
                //Resort Queue
                patients.SortQueue((int)(shift + shiftOver));
                shiftOver += lowestRoomtime;
            }
            results = new Results(shiftLen, rating1, rating2, rating3, rating4, patients.GetAvgWait1(shift+shiftOver), patients.GetAvgWait2(), patients.GetAvgWait3(),
                patients.GetAvgWait4(), shiftOver/60, openRooms, instantSimNum);
            results.Show();
            //System.Diagnostics.Debug.WriteLine("Next Run");
        }

        private void UpdateSentValues()
        {
            numRooms = RoomDropDown.SelectedIndex + 1;
            shiftLen = (float)shiftLength.Value;
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
