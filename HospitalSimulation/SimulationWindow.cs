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
        private TableLayoutPanel[] Rooms = new TableLayoutPanel[15];
        private Label[] PatientNum = new Label[15];
        private Label[] PatientRating = new Label[15];
        private Label[] AveWait = new Label[4];
        Queue<Patient>[] RatingLine = new Queue<Patient>[4];

        public SimulationWindow()
        {
            InitializeComponent();
            SetGroups();

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

        public SimulationWindow(int numRooms, int[] severityRatings, int [] roomTimes, float[] waitDelays)
        {
            InitializeComponent();
            SetGroups();
            OpenRooms(numRooms);
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

        void OpenRooms(int numRooms)
        {
            for (int i = 0; i <= numRooms; i++)
            {
                Rooms[i].Visible = true;
            }
        }
    }
}