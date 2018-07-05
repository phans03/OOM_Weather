using System;
using System.Collections;
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

namespace Weather_History2
{
    public partial class Weatherdata2 : Form
    {
        public Weatherdata2()
        {
            InitializeComponent();
        }
        //initialize filepath
        string tempfile;

        //this is the click handler for the open button on the File menu
        //to open and retrieve any desired .csv file
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ff = new OpenFileDialog();

            ff.InitialDirectory = "c:\\";
            ff.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            ff.FilterIndex = 1;
            ff.RestoreDirectory = true;

            if (ff.ShowDialog() == DialogResult.OK)
            {
                tempfile = ff.FileName;
            }
        }
        //after opening, read the file
        //utility method to read data from tempfile into arraylist
        private ArrayList readdata()
        {
            // create an arraylist to store the data
            ArrayList tempdata = new ArrayList();

            //read every line in the file
            using (StreamReader reader = new StreamReader(tempfile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    //split the line into a string array using a comma delimiter
                    //and add to the arraylist
                    string[] parts = line.Split(',');
                    tempdata.Add(parts);
                }
            }
            //ignore the first row in file as it contains header information
            //and pass out the rest of the data
            tempdata.RemoveAt(0);
            return tempdata;
        }
        //this is the click handler for the plot button
        //clicking this, plots the chart
        private void plotbutton_Click(object sender, EventArgs e)
        {
            //read the array data
            ArrayList data = readdata();

            //delete any existing series from the charts
            tempchart.Series.Clear();
            sunchart.Series.Clear();
            AFchart.Series.Clear();
            rainchart.Series.Clear();

            //create new series for our data and add to the charts 
            //series for airfrost data
            Series s1 = new Series("AirFrost days");
            s1.ChartType = SeriesChartType.Line;
            AFchart.Series.Add(s1);

            //series for rainfall data
            Series s2 = new Series("Rainfall days");
            s2.ChartType = SeriesChartType.Line;
            rainchart.Series.Add(s2);

            //series for sun data
            Series s3 = new Series("Sun hours");
            s3.ChartType = SeriesChartType.Line;
            sunchart.Series.Add(s3);

            //series for temperature data
            Series s4 = new Series("Maximum Temp");
            Series s5 = new Series("Minimum Temp");
            s4.ChartType = SeriesChartType.Line;
            s5.ChartType = SeriesChartType.Line;
            tempchart.Series.Add(s4);
            tempchart.Series.Add(s5);

            //for every sample in the data
            foreach (string[] d in data)
            {
                //process the weather data and parse them properly
                // extract year of the sample
                int year = int.Parse(d[0].Trim());

                // extract maximum and minimum temperatures
                double maxtemp = double.Parse(d[2].Trim());
                double mintemp = double.Parse(d[3].Trim());

                // extract the sun, rain, and airfrost data
                int AFdata = int.Parse(d[4].Trim());
                double raindays = double.Parse(d[5].Trim());
                double sunhours = double.Parse(d[6].Trim());

                // add to the Series
                s1.Points.AddXY(year, AFdata);
                s2.Points.AddXY(year, raindays);
                s3.Points.AddXY(year, sunhours);
                s4.Points.AddXY(year, maxtemp);
                s5.Points.AddXY(year, mintemp);
            }
        }
        //this is the click handler for the save button on the File Menu
        //to save chart as .jpeg to any location
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog ff = new SaveFileDialog();

            ff.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            ff.FilterIndex = 1;
            ff.RestoreDirectory = true;

            if (ff.ShowDialog() == DialogResult.OK)
            {
                tempchart.SaveImage(ff.FileName, ChartImageFormat.Jpeg);    //saves the tempchart
            }
             if (ff.ShowDialog() == DialogResult.OK)
            {
                rainchart.SaveImage(ff.FileName, ChartImageFormat.Jpeg);    //saves the rainchart
            }
             if (ff.ShowDialog() == DialogResult.OK)
            {
                sunchart.SaveImage(ff.FileName, ChartImageFormat.Jpeg);     //saves the sunchart
            }
             if (ff.ShowDialog() == DialogResult.OK)
            {
                AFchart.SaveImage(ff.FileName, ChartImageFormat.Jpeg);      //saves the AFchart
            }
        }
        //this is the click handler for the exit button on the File menu
        //to exit the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
