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
using System.Windows.Forms.DataVisualization.Charting;

namespace SACNASP_FORM1
{
    public partial class Overall : Form
    {
        public Overall()
        {
            InitializeComponent();

            List<string> years = new List<string>();
            List<string> male = new List<string>();
            List<string> female = new List<string>();

            List<int> values = new List<int>();

            string filePath = @"C:\\Users\\Queen\\Desktop\\SACNASP FORM1\\bin\\Debug\\gender.txt";

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {

                        years.Add(parts[0]);
                        male.Add(parts[1]);
                        female.Add(parts[1]);
                        values.Add(int.Parse(parts[2]));
                    }
                    else
                    {
                        // Handle invalid lines or display an error message
                    }

                }
            }

            // Clear any existing series from the chart
            chart1.Series.Clear();

            // Create a new series for the bar graph
            Series Male = new Series("Male");
            Series Female = new Series("Female");

            Male.ChartType = SeriesChartType.Column;
            Female.ChartType = SeriesChartType.Column;


            // Add data points to the series
            for (int i = 0; i < 6; i = i + 2)
            {
                Male.Points.AddXY(years[i], values[i]);
            }
            for (int j = 1; j < 6; j = j + 2)
            {
                Female.Points.AddXY(years[j], values[j]);
            }

            // Add the series to the chart
            chart1.Series.Add(Male);
            chart1.Series.Add(Female);


            // Set axis labels
            chart1.ChartAreas[0].AxisX.Interval = 1;

            // Display the chart
            chart1.Invalidate();


        }

        private void Overall_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            Graph form2 = new Graph();
            form2.ShowDialog();

        }

        private void btnData_Click(object sender, EventArgs e)
        {
            _2019 data = new _2019();   
            data.ShowDialog();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Charts charts = new Charts();
            charts.ShowDialog();
        }
    }
}
