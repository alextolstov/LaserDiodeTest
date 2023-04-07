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

namespace LaserDiodeTest
{
    public partial class MeasureForm : Form
    {
        protected string fileName;
        protected BackgroundWorker backgroundWorker;
        public MeasureForm(string name)
        {
            InitializeComponent();
            fileName = name;

            backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MeasureForm_Load(object sender, EventArgs e)
        {
            lblFileName.Text = fileName;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text.Equals("Start"))
            {
                LoadStaticChart();
                btn.Text = "Stop";
                btn.BackColor = Color.Red;
            }
            else
            {
                btn.Text = "Start";
                btn.BackColor = SystemColors.Control;
            }
        }
        private void LoadStaticChart()
        {
            chart.Titles.Add("L-I-V");

            TestForm frmParent = (TestForm)this.Owner;

            QCWData data = frmParent.GetTestData();

            var objChart = chart.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisX.Minimum = 0;
            objChart.AxisX.Maximum = 9;
            objChart.AxisX.Title = "Current, A";


            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = 0;
            objChart.AxisY.Maximum = 27;
            objChart.AxisY.Title = "Power, W";

            chart.Series.Clear();
            chart.Legends.Clear();

            chart.Series.Add("Points");
            chart.Series["Points"].Color = Color.DarkRed;
            chart.Series["Points"].ChartType = SeriesChartType.Point;

            chart.Series["Points"].Points.AddXY(data.OperatingCurrent_A, data.MinPowAtOp_W);
            chart.Series["Points"].Points.AddXY(data.MaximumCurrent_A, data.MinPowAtMax_W);

            chart.Series.Add("TopLine");
            chart.Series["TopLine"].Color = Color.DarkRed;
            chart.Series["TopLine"].ChartType = SeriesChartType.Line;

            chart.Series["TopLine"].Points.AddXY(data.MinThresholdCurrent_A, 0);
            chart.Series["TopLine"].Points.AddXY(data.MaximumCurrent_A, data.MaximumCurrent_A*data.MaxSlope_WA - data.MinThresholdCurrent_A );

            chart.Series.Add("BottomLine");
            chart.Series["BottomLine"].Color = Color.DarkRed;
            chart.Series["BottomLine"].ChartType = SeriesChartType.Line;


            chart.Series["BottomLine"].Points.AddXY(data.MaxThresholdCurrent_A, 0);
            chart.Series["BottomLine"].Points.AddXY(data.MaximumCurrent_A, data.MaximumCurrent_A * data.MinSlope_WA - data.MaxThresholdCurrent_A);

            objChart.AxisY2.IntervalType = DateTimeIntervalType.Number;
            objChart.AxisY2.Minimum = 0;
            objChart.AxisY2.Maximum = 1.2;
            objChart.AxisY2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            objChart.AxisY2.Title = "Voltage, V";

            chart.ChartAreas[0].AxisY2.LineColor = Color.Transparent;
            chart.ChartAreas[0].AxisY2.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY2.Enabled = AxisEnabled.True;
            chart.ChartAreas[0].AxisY2.IsStartedFromZero = chart.ChartAreas[0].AxisY.IsStartedFromZero;
        }
    }
}
