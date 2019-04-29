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
    public partial class SimulationWindow : Form
    {
        private static int totalSimulations;
        private int simID,
            numRooms, 
            shiftLength, 
            tick = 0, 
            timeNext = 0, 
            patientWait = 0, 
            patientsMade = 0,
            tempPatientRating = 0,
            openRooms = 0;
        private int[] severityRatings, 
            roomTimes, 
            closeWait = new int[4],
            numRatings = new int[4],
            totalRatingWaits = new int[4];
        private float[] waitDelays,
            aveRatingsWait = new float[4];
        private Boolean simRun = true, 
            makePatients = true, 
            patientAdded = false, 
            midSaved = false;
        private TableLayoutPanel[] Rooms = new TableLayoutPanel[15];
        private Label[] PatientNum = new Label[15];
        private Label[] PatientRating = new Label[15];
        private Label[] AveWait = new Label[4];
        private Patient[] room;
        private Queue<Patient>[] RatingLine = new Queue<Patient>[4];

        public SimulationWindow()
        {
            InitializeComponent();
            SetGroups();
            totalSimulations++;

            Room1Panel.Visible = true;
            Room2Panel.Visible = true;
            Room3Panel.Visible = true;
            Room4Panel.Visible = true;
            Room5Panel.Visible = true;
            Room6Panel.Visible = true;

            Room1Panel.Enabled = true;
            Room2Panel.Enabled = true;
            Room3Panel.Enabled = true;
            Room4Panel.Enabled = true;
            Results results = new Results();
            results.Show();
        }

        public SimulationWindow(int rooms, int shiftLen, int[] ratings, int[] times, float[] delays)
        {
            severityRatings = new int[ratings.Length];
            for (int i = 0; i < ratings.Length; i++)
            {
                severityRatings[i] = ratings[i];
            }

            roomTimes = new int[times.Length];
            for (int i = 0; i < times.Length; i++)
            {
                roomTimes[i] = times[i];
            }

            waitDelays = new float[delays.Length];
            for (int i = 0; i < delays.Length; i++)
            {
                waitDelays[i] = delays[i];
            }
            numRooms = rooms;
            shiftLength = shiftLen;
            InitializeComponent();
            totalSimulations++;
            simID = totalSimulations;
            SetupItems();
            Timer1.Start();
        }

        private void SetupItems()
        {
            room = new Patient[numRooms];
            for(int i = 0; i < 4; i++)
            {
                RatingLine[i] = new Queue<Patient>();
            }
            SetDispText();
            SetGroups();
            OpenRooms(numRooms);
        }

        private void SetDispText()
        {
            ShiftLengthLabel.Text = "Progress of " + shiftLength + " hour shift";
            this.Text = "Simulation Window " + simID;
        }

        private void SetGroups()
        {
            Rooms[0] = Room1Panel;
            Rooms[1] = Room2Panel;
            Rooms[2] = Room3Panel;
            Rooms[3] = Room4Panel;
            Rooms[4] = Room5Panel;
            Rooms[5] = Room6Panel;
            Rooms[6] = Room7Panel;
            Rooms[7] = Room8Panel;
            Rooms[8] = Room9Panel;
            Rooms[9] = Room10Panel;
            Rooms[10] = Room11Panel;
            Rooms[11] = Room12Panel;
            Rooms[12] = Room13Panel;
            Rooms[13] = Room14Panel;
            Rooms[14] = Room15Panel;

            PatientNum[0] = Room1PatientNumber;
            PatientNum[1] = Room2PatientNumber;
            PatientNum[2] = Room3PatientNumber;
            PatientNum[3] = Room4PatientNumber;
            PatientNum[4] = Room5PatientNumber;
            PatientNum[5] = Room6PatientNumber;
            PatientNum[6] = Room7PatientNumber;
            PatientNum[7] = Room8PatientNumber;
            PatientNum[8] = Room9PatientNumber;
            PatientNum[9] = Room10PatientNumber;
            PatientNum[10] = Room11PatientNumber;
            PatientNum[11] = Room12PatientNumber;
            PatientNum[12] = Room13PatientNumber;
            PatientNum[13] = Room14PatientNumber;
            PatientNum[14] = Room15PatientNumber;

            PatientRating[0] = Room1PatientRating;
            PatientRating[1] = Room2PatientRating;
            PatientRating[2] = Room3PatientRating;
            PatientRating[3] = Room4PatientRating;
            PatientRating[4] = Room5PatientRating;
            PatientRating[5] = Room6PatientRating;
            PatientRating[6] = Room7PatientRating;
            PatientRating[7] = Room8PatientRating;
            PatientRating[8] = Room9PatientRating;
            PatientRating[9] = Room10PatientRating;
            PatientRating[10] = Room11PatientRating;
            PatientRating[11] = Room12PatientRating;
            PatientRating[12] = Room13PatientRating;
            PatientRating[13] = Room14PatientRating;
            PatientRating[14] = Room15PatientRating;

            AveWait[0] = AveWait1;
            AveWait[1] = AveWait2;
            AveWait[2] = AveWait3;
            AveWait[3] = AveWait4;
        }

        private void OpenRooms(int numRooms)
        {
            for (int i = 0; i < numRooms; i++)
            {
                Rooms[i].Visible = true;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (makePatients)
            {
                GetPatients();
            }

            if (tick < (shiftLength * 600))
            {
                TimeCompleteProgress.Value = (int)(((float)tick / ((float)shiftLength * 600)) * 100);
            }
            else
            {
                TimeCompleteProgress.Value = 100;
                if (!midSaved)
                {
                    AfterShift();
                }
                makePatients = false;

                if(patientWait == 0)
                {
                    Timer1.Stop();
                    for (int i = 0; i < numRooms; i++)
                    {
                        if (room[i] == null)
                        {
                            openRooms++;
                        }
                    }
                    Results results = new Results(shiftLength, closeWait, tick, aveRatingsWait, openRooms, simID);
                    results.Show();
                }
            }
            patientWait = RatingLine[0].Count + RatingLine[1].Count + RatingLine[2].Count + RatingLine[3].Count;
            SortPatients();
            UpdateText();
            tick++;
        }

        private void GetPatients()
        {
            if (tick >= timeNext)
            {
                patientsMade++;
                Patient newPatient = new Patient(ref severityRatings, ref roomTimes, ref waitDelays, patientsMade);
                newPatient.SetArrivalTime(ref tick);
                switch (newPatient.GetRating())
                {
                    case 1: RatingLine[0].Enqueue(newPatient); break;
                    case 2: RatingLine[1].Enqueue(newPatient); break;
                    case 3: RatingLine[2].Enqueue(newPatient); break;
                    case 4: RatingLine[3].Enqueue(newPatient); break;
                }
                timeNext = tick + (int)(newPatient.GetDelayTime() * 10);
            }
        }

        private void SortPatients()
        {
            for(int i = 0; i < numRooms; i++)
            {
                if (room[i] == null)
                {
                    room[i] = new Patient(true);
                    Rooms[i].Enabled = false;
                }

                if (room[i].TimeUp(tick))
                {

                    Rooms[i].Enabled = false;
                    if(RatingLine[3].Count > 0)
                    {
                        room[i] = RatingLine[3].Dequeue();
                        patientAdded = true;
                    }
                    else if(RatingLine[0].Count > 0 || RatingLine[1].Count > 0 || RatingLine[2].Count > 0)
                    {
                        switch (getPriority())
                        {
                            case 1: room[i] = RatingLine[0].Dequeue(); break;
                            case 2: room[i] = RatingLine[1].Dequeue(); break;
                            case 3: room[i] = RatingLine[2].Dequeue(); break;
                        }
                        patientAdded = true;
                    }

                    if (room[i] != null)
                    {

                        //Checks that a Patient was added
                        if (patientAdded)
                        {

                            //Tells Patient it has been roomed
                            room[i].Roomed(ref tick);
                            Rooms[i].Enabled = true;
                            PatientNum[i].Text = "Patient #: " + room[i].GetPatientNum();
                            PatientRating[i].Text = "Patient rating: " + room[i].GetRating();


                            //Retrieves rating of Patient in current room
                            tempPatientRating = room[i].GetRating();

                            ////Adds wait of current patient to total for that rating
                            totalRatingWaits[tempPatientRating - 1] = totalRatingWaits[tempPatientRating - 1] + (int)room[i].GetWaitTime(ref tick);

                            ////Increases count of patients of rating type roomed
                            numRatings[tempPatientRating - 1]++;

                            aveRatingsWait[tempPatientRating - 1] = (totalRatingWaits[tempPatientRating - 1] / numRatings[tempPatientRating - 1])/10;

                            //Says Patient has been delt with
                            patientAdded = false;
                        }
                    }
                }
            }
        }

        private void AfterShift()
        {
            midSaved = true;
            for(int i = 0; i < 4; i++)
            {
                closeWait[i] = RatingLine[i].Count;
            }
        }

        public void UpdateText()
        {
            for(int i = 0; i < 4; i++)
            {
                AveWait[i].Text = "Severity rating " + (i+1) + ": " + aveRatingsWait[i].ToString("n2");
            }
            PatientWaitLabel.Text = "Number of patients waiting: " + patientWait;
        }

        private int getPriority()
        {
            int priority = 3,          //Default priority
                currentTick = tick;    //Time when method was called
            double priority1 = 0,      //Priority value of Patient 1
                   priority2 = 0,      //Priority value of Patient 2
                   priority3 = 0;      //Priority Value of Patient 3

            if (RatingLine[0].Count != 0)
            {
                priority1 = RatingLine[0].Peek().GetPriority(currentTick + 1);  //Sets priority value of Patient 1
            }
            if (RatingLine[1].Count != 0)
            {
                priority2 = RatingLine[1].Peek().GetPriority(currentTick + 1);  //Sets priority value of Patient 1
            }
            if (RatingLine[2].Count != 0)
            {
                priority3 = RatingLine[2].Peek().GetPriority(currentTick + 1);  //Sets priority value of Patient 1
            }

            //Logic for determining which Patient has highest priority
            if (priority2 > priority3)
            {
                priority = 2;                    //Sets Priority to queue 2
                if (priority1 > priority2)
                {
                    priority = 1;                 //Sets proirity to queue 1
                }
            }

            if (priority1 > priority3)
            {
                priority = 1;                    //Sets priority to queue 1
                if (priority2 > priority1)
                {
                    priority = 2;                 //Sets proiority to queue 2
                }
            }
            return priority;                    //Returns queue with highest priority
        }
    }
}