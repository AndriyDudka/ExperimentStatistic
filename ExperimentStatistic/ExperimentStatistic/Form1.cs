using ExperimentStatistic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExperimentStatistic
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            chart.ChartAreas[0].AxisX.Interval = 1;           
        }

        private void buttonChooseFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                try
                {
                    Logic.DeserializeXmlFile(file);
                    Logic.CreateStatistic();

                    foreach (var session in Logic.sessions)
                    {                      
                        comboBoxHide.Items.Add(session.Date);
                        comboBoxShow.Items.Add(session.Date);
                    }

                    ShowChartPoints();
                    comboBoxHide.SelectedIndex = 0;
                    comboBoxShow.SelectedIndex = 0;
                }
                catch(Exception ex)
                {

                }
            }
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            var xAxis = comboBoxHide.SelectedIndex;
            ShowChartPoints(xAxis, false);
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            var xAxis = comboBoxShow.SelectedIndex;
            ShowChartPoints(xAxis, true);
        }

        private void ShowChartPoints(int xAxis = 0, bool show = true)
        {
            Logic.sessions[xAxis].Show = show;
            chart.Series[0].Points.Clear();
           
            foreach (var session in Logic.sessions)
            {
                if (session.Show)
                    chart.Series[0].Points.AddXY(session.Date, session.TumorSize);
            }
        }
    }
}
