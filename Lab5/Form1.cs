using Lab__5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[,] points;


        private void Plotlines(int[,] lines)
        {
            for (var i = 0; i < lines.GetLength(0); i++)
            {
                chart1.Series["Lines"].Points.AddXY(lines[i, 0], lines[i, 1]);
                chart1.Series["Lines"].Points.AddXY(lines[i, 2], lines[i, 3]);
                chart1.Series["Lines"].Points.AddXY(lines[i, 4], lines[i, 5]);
                chart1.Series["Lines"].Points.AddXY(lines[i, 6], lines[i, 7]);
                chart1.Series["Lines"].Points.AddXY(double.NaN, double.NaN);
            }
        }
        private void InitializeChart()
        {
            chart1.ChartAreas.Clear();
            chart1.Series.Clear();
            var chartArea = new ChartArea
            {
                AxisX =
                {
                    Minimum = 0,
                    Maximum = 100000,
                    Interval = 20000,
                    MajorGrid = { Enabled = false }
                },
                AxisY =
                {
                    Minimum = 0,
                    Maximum = 100000,
                    Interval = 20000,
                    MajorGrid = { Enabled = false }
                }
            };
            var seriesPoints = new Series("Points")
            {
                ChartType = SeriesChartType.FastPoint,
                MarkerStyle = MarkerStyle.Circle,
                Color = Color.Blue,
                BorderColor = Color.Black,
                BorderWidth = 2,
                MarkerSize = 8,
                IsVisibleInLegend = false
            };
            var seriesLines = new Series("Lines")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Red,
                BorderWidth = 2,
                IsVisibleInLegend = false
            };
            chart1.ChartAreas.Add(chartArea);
            chart1.Series.Add(seriesPoints);
            chart1.Series.Add(seriesLines);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeChart();
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = @"Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var Path = openFileDialog.FileName;
                textBox1.Text = openFileDialog.FileName;
                points = Calculation.LoadPoints(Path);
                var pointsText = new StringBuilder();
                for (var i = 0; i < points.GetLength(0); i++)
                {
                    pointsText.AppendLine($"{points[i, 0]} {points[i, 1]}");
                    chart1.Series["Points"].Points.AddXY(points[i, 0], points[i, 1]);
                }
                richTextBox1.Text = pointsText.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var lines = new int[,] { };
            if (radioButton1.Checked)
            {
                lines = Calculation.BruteForceLines(points);
            }
            else if (radioButton2.Checked)
            {
                lines = Calculation.IntelectualLines(points);
            }
            Plotlines(lines);
        }
    }
}
