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
        public Results()
        {
            InitializeComponent();
            Label[] AveWait = new Label[4];
            AveWait[0] = AveWait1;
            AveWait[1] = AveWait2;
            AveWait[2] = AveWait3;
            AveWait[3] = AveWait4;

            Label[] RatingCount = new Label[4];
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
