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
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();

            // Assuming you have a Chart control named "chart1" on your form

            // Read data from the file
            Dictionary<string, int> ageValues = new Dictionary<string, int>();

            string filePath = @"C:\\Users\\Queen\\Desktop\\SACNASP FORM1\\bin\\Debug\\2018.txt";

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        string year = parts[0];
                        string ageGroup = parts[1];
                        int value = int.Parse(parts[2]);

                        string key = year + " - " + ageGroup;
                        if (ageValues.ContainsKey(key))
                        {
                            ageValues[key] += value; // Add the value to the existing age group
                        }
                        else
                        {
                            ageValues.Add(key, value); // Create a new entry for the age group
                        }
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
            Series series = new Series("Age");
            series.ChartType = SeriesChartType.Column;

            // Add data points to the series
            foreach (KeyValuePair<string, int> ageEntry in ageValues)
            {
                string ageGroup = ageEntry.Key;
                int value = ageEntry.Value;

                series.Points.AddXY(ageGroup, value);
            }

            // Add the series to the chart
            chart1.Series.Add(series);

            // Set axis labels
            chart1.ChartAreas[0].AxisX.Interval = 1;

            // Display the chart
            chart1.Invalidate();



            Dictionary<string, int> agwValues1 = new Dictionary<string, int>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        string year1 = parts[0];
                        string ageGroup1 = parts[1];
                        int value1 = int.Parse(parts[2]);

                        string key = year1 + " - " + ageGroup1;
                        if (ageValues.ContainsKey(key))
                        {
                            ageValues[key] += value1; // Add the value to the existing age group
                        }
                        else
                        {
                            ageValues.Add(key, value1); // Create a new entry for the age group
                        }
                    }
                    else
                    {
                        // Handle invalid lines or display an error message
                    }
                }
            }

            // Clear any existing series from the chart
            chart2.Series.Clear();

            // Create a new series for the pie chart
            Series series1 = new Series("Age");
            series1.ChartType = SeriesChartType.Pie;

            // Add data points to the series
            foreach (KeyValuePair<string, int> ageEntry in ageValues)
            {
                string ageGroup1 = ageEntry.Key;
                int value1 = ageEntry.Value;

                series1.Points.AddXY(ageGroup1, value1);
            }

            // Add the series to the chart
            chart2.Series.Add(series1);

            // Set chart options
            chart2.Series[0].IsValueShownAsLabel = true; // Display values as labels
            chart2.Legends[0].Enabled = true; // Enable the legend

            // Display the chart
            chart2.Invalidate();

            ///second panel

            Dictionary<string, int> ageValues19 = new Dictionary<string, int>();

            string filePath19 = @"C:\\Users\\Queen\\Desktop\\SACNASP FORM1\\bin\\Debug\\2019.txt";

            using (StreamReader reader19 = new StreamReader(filePath19))
            {
                string line19;
                while ((line19 = reader19.ReadLine()) != null)
                {
                    string[] parts19 = line19.Split(',');
                    if (parts19.Length == 3)
                    {
                        string year19 = parts19[0];
                        string ageGroup19 = parts19[1];
                        int value19 = int.Parse(parts19[2]);

                        string key19 = year19 + " - " + ageGroup19;
                        if (ageValues19.ContainsKey(key19))
                        {
                            ageValues19[key19] += value19; // Add the value to the existing age group
                        }
                        else
                        {
                            ageValues19.Add(key19, value19); // Create a new entry for the age group
                        }
                    }
                    else
                    {
                        // Handle invalid lines or display an error message
                    }
                }
            }

            // Clear any existing series from the chart
            chart4.Series.Clear();

            // Create a new series for the bar graph
            Series series19 = new Series("Age");
            series19.ChartType = SeriesChartType.Column;

            // Add data points to the series
            foreach (KeyValuePair<string, int> ageEntry19 in ageValues19)
            {
                string ageGroup19 = ageEntry19.Key;
                int value19 = ageEntry19.Value;

                series19.Points.AddXY(ageGroup19, value19);
            }

            // Add the series to the chart
            chart4.Series.Add(series19);

            // Set axis labels
            chart4.ChartAreas[0].AxisX.Interval = 1;

            // Display the chart
            chart4.Invalidate();

            //Pie chart


            Dictionary<string, int> ageValues191 = new Dictionary<string, int>();

            using (StreamReader reader = new StreamReader(filePath19))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        string year191 = parts[0];
                        string ageGroup191 = parts[1];
                        int value191 = int.Parse(parts[2]);

                        string key191 = year191 + " - " + ageGroup191;
                        if (ageValues191.ContainsKey(key191))
                        {
                            ageValues191[key191] += value191; // Add the value to the existing age group
                        }
                        else
                        {
                            ageValues191.Add(key191, value191); // Create a new entry for the age group
                        }
                    }
                    else
                    {
                        // Handle invalid lines or display an error message
                    }
                }
            }

            // Clear any existing series from the chart
            chart3.Series.Clear();

            // Create a new series for the pie chart
            Series series191 = new Series("Age");
            series191.ChartType = SeriesChartType.Pie;

            // Add data points to the series
            foreach (KeyValuePair<string, int> ageEntry191 in ageValues191)
            {
                string ageGroup191 = ageEntry191.Key;
                int value191 = ageEntry191.Value;

                series191.Points.AddXY(ageGroup191, value191);
            }

            // Add the series to the chart
            chart3.Series.Add(series191);

            // Set chart options
            chart3.Series[0].IsValueShownAsLabel = true; // Display values as labels
            chart3.Legends[0].Enabled = true; // Enable the legend

            // Display the chart
            chart3.Invalidate();

            //third panel


            Dictionary<string, int> ageValues20 = new Dictionary<string, int>();

            string filePath20 = @"C:\\Users\\Queen\\Desktop\\SACNASP FORM1\\bin\\Debug\\2020.txt";

            using (StreamReader reader20 = new StreamReader(filePath20))
            {
                string line20;
                while ((line20 = reader20.ReadLine()) != null)
                {
                    string[] parts20 = line20.Split(',');
                    if (parts20.Length == 3)
                    {
                        string year20 = parts20[0];
                        string ageGroup20 = parts20[1];
                        int value20 = int.Parse(parts20[2]);

                        string key20 = year20 + " - " + ageGroup20;
                        if (ageValues20.ContainsKey(key20))
                        {
                            ageValues20[key20] += value20; // Add the value to the existing age group
                        }
                        else
                        {
                            ageValues20.Add(key20, value20); // Create a new entry for the age group
                        }
                    }
                    else
                    {
                        // Handle invalid lines or display an error message
                    }
                }
            }

            // Clear any existing series from the chart
            chart6.Series.Clear();

            // Create a new series for the bar graph
            Series series20 = new Series("Age");
            series20.ChartType = SeriesChartType.Column;

            // Add data points to the series
            foreach (KeyValuePair<string, int> ageEntry20 in ageValues20)
            {
                string ageGroup20 = ageEntry20.Key;
                int value20 = ageEntry20.Value;

                series20.Points.AddXY(ageGroup20, value20);
            }

            // Add the series to the chart
            chart6.Series.Add(series20);

            // Set axis labels
            chart6.ChartAreas[0].AxisX.Interval = 1;

            // Display the chart
            chart6.Invalidate();

            //Pie chart


            Dictionary<string, int> ageValues202 = new Dictionary<string, int>();

            using (StreamReader reader = new StreamReader(filePath20))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        string year202 = parts[0];
                        string ageGroup202 = parts[1];
                        int value202 = int.Parse(parts[2]);

                        string key202 = year202 + " - " + ageGroup202;
                        if (ageValues202.ContainsKey(key202))
                        {
                            ageValues191[key202] += value202; // Add the value to the existing age group
                        }
                        else
                        {
                            ageValues202.Add(key202, value202); // Create a new entry for the age group
                        }
                    }
                    else
                    {
                        // Handle invalid lines or display an error message
                    }
                }
            }

            // Clear any existing series from the chart
            chart5.Series.Clear();

            // Create a new series for the pie chart
            Series series202 = new Series("Age");
            series202.ChartType = SeriesChartType.Pie;

            // Add data points to the series
            foreach (KeyValuePair<string, int> ageEntry202 in ageValues202)
            {
                string ageGroup202 = ageEntry202.Key;
                int value202 = ageEntry202.Value;

                series202.Points.AddXY(ageGroup202, value202);
            }

            // Add the series to the chart
            chart5.Series.Add(series202);

            // Set chart options
            chart5.Series[0].IsValueShownAsLabel = true; // Display values as labels
            chart5.Legends[0].Enabled = true; // Enable the legend
            
            // Display the chart
            chart5.Invalidate();

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            panel2020.Hide();
            panel3.Hide();
            panel2.Hide();
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void btnto2019_Click(object sender, EventArgs e)
        {
            panel3.Show();
        }

        private void btn2020_Click(object sender, EventArgs e)
        {
            panel2020.Show();
        }

        private void panel2020_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
