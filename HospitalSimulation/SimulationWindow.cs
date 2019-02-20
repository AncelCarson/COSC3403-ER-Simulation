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
        public SimulationWindow()
        {
            InitializeComponent();
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
            OpenRooms(numRooms);
        }

        void OpenRooms(int numRooms)
        {
            switch (numRooms)
            {
                case 14:
                    Room15Panel.Visible = true;
                    goto case 13;
                case 13:
                    Room14Panel.Visible = true;
                    goto case 12;
                case 12:
                    Room13Panel.Visible = true;
                    goto case 11;
                case 11:
                    Room12Panel.Visible = true;
                    goto case 10;
                case 10:
                    Room11Panel.Visible = true;
                    goto case 9;
                case 9:
                    Room10Panel.Visible = true;
                    goto case 8;
                case 8:
                    Room9Panel.Visible = true;
                    goto case 7;
                case 7:
                    Room8Panel.Visible = true;
                    goto case 6;
                case 6:
                    Room7Panel.Visible = true;
                    goto case 5;
                case 5:
                    Room6Panel.Visible = true;
                    goto case 4;
                case 4:
                    Room5Panel.Visible = true;
                    goto case 3;
                case 3:
                    Room4Panel.Visible = true;
                    goto case 2;
                case 2:
                    Room3Panel.Visible = true;
                    goto case 1;
                case 1:
                    Room2Panel.Visible = true;
                    goto case 0;
                case 0:
                    Room1Panel.Visible = true;
                    break;
            }
        }


    }
}
