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
        Boolean delayChangeEnabled = false;
        float delayMin;
        float delayMax;
        float delayAverage;
        HelpForm help;
        SimulationWindow simulation;
        Results results;

        public FrontPanel()
        {
            InitializeComponent();
            delayMin = Convert.ToInt32(DelayMinValue.Value);
            delayMax = Convert.ToInt32(DelayMaxValue.Value);
            delayAverage = ((delayMin + delayMax) / 2);
            AverageDelay.Text = delayAverage.ToString("n2");
        }

        private void ChangeAveDelay_CheckedChanged(object sender, EventArgs e)
        {
            if (!delayChangeEnabled)
            {
                DelayMinValue.Enabled = true;
                DelayMaxValue.Enabled = true;
                delayChangeEnabled = true;
            }
            else
            {
                DelayMinValue.Enabled = false;
                DelayMaxValue.Enabled = false;
                DelayMinValue.Value = 0;
                DelayMaxValue.Value = 15;
                delayChangeEnabled = false;
            }
        }

        private void DelayMinValue_ValueChanged(object sender, EventArgs e)
        {
            delayMin = Convert.ToInt32(DelayMinValue.Value);
            delayMax = Convert.ToInt32(DelayMaxValue.Value);
            delayAverage = ((delayMin + delayMax) / 2);
            AverageDelay.Text = delayAverage.ToString("n2");
        }

        private void DelayMaxValue_ValueChanged(object sender, EventArgs e)
        {
            delayMin = Convert.ToInt32(DelayMinValue.Value);
            delayMax = Convert.ToInt32(DelayMaxValue.Value);
            delayAverage = ((delayMin + delayMax) / 2);
            AverageDelay.Text = delayAverage.ToString("n2");
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            help = new HelpForm();
            help.Show();
        }

        private void TimedSimButton_Click(object sender, EventArgs e)
        {
            simulation = new SimulationWindow();
            simulation.Show();
        }

        private void InstantSimButton_Click(object sender, EventArgs e)
        {
            results = new Results();
            results.Show();
        }
    }
}
