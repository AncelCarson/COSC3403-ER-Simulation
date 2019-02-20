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
            Room1Panel.Visible = true;
            if(numRooms == 0)
            {
                return;
            }
            Room2Panel.Visible = true;
            if (numRooms == 1)
            {
                return;
            }
            Room3Panel.Visible = true;
            if (numRooms == 2)
            {
                return;
            }
            Room4Panel.Visible = true;
            if (numRooms == 3)
            {
                return;
            }
            Room5Panel.Visible = true;
            if (numRooms == 4)
            {
                return;
            }
            Room6Panel.Visible = true;
            if (numRooms == 5)
            {
                return;
            }
            Room7Panel.Visible = true;
            if (numRooms == 6)
            {
                return;
            }
            Room8Panel.Visible = true;
            if (numRooms == 7)
            {
                return;
            }
            Room9Panel.Visible = true;
            if (numRooms == 8)
            {
                return;
            }
            Room10Panel.Visible = true;
            if (numRooms == 9)
            {
                return;
            }
            Room11Panel.Visible = true;
            if (numRooms == 10)
            {
                return;
            }
            Room12Panel.Visible = true;
            if (numRooms == 11)
            {
                return;
            }
            Room13Panel.Visible = true;
            if (numRooms == 12)
            {
                return;
            }
            Room14Panel.Visible = true;
            if (numRooms == 13)
            {
                return;
            }
            Room15Panel.Visible = true;
            if (numRooms == 14)
            {
                return;
            }
        }
    }
}
