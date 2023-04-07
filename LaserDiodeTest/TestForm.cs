using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaserDiodeTest
{
    public partial class TestForm : Form
    {
        protected string conStr;
        protected OleDbConnection connection;
        protected DataTable results;
        protected string tableName;
        protected QCWData testData;
        public TestForm()
        {
            testData = new QCWData();
            InitializeComponent();
            conStr = ConfigurationManager.ConnectionStrings["db_4wConnectionString"].ConnectionString;
            connection = new OleDbConnection(conStr);
        }
        public QCWData GetTestData() { return testData; } 
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            connection.Open();
            LoadNames();
        }

        private void LoadNames()
        {
            DataTable userTables = null;
            List<string> tableNames = new List<string>();
            string[] restrictions = new string[4];
            restrictions[3] = "Table";
            userTables = connection.GetSchema("Tables", restrictions);
            for (int i = 0; i < userTables.Rows.Count; i++)
            {
                tableNames.Add(userTables.Rows[i][2].ToString());
            }
            this.comboName.SelectedIndexChanged -= new System.EventHandler(this.comboName_SelectedIndexChanged);
            comboName.DataSource = tableNames;
            this.comboName.SelectedIndexChanged += new System.EventHandler(this.comboName_SelectedIndexChanged);
        }

        private void LoadTypes()
        {
            results = new DataTable();
            OleDbCommand cmd = new OleDbCommand(string.Format("SELECT  * FROM [{0}]", tableName), connection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);

            adapter.Fill(results);

            if (!results.Columns.Contains("CoeffPower"))
            {
                comboType.DataSource = null;
                tableName = string.Empty;
                LoadFormData(true, true);
                return;
            }

            var r = from rec in results.AsEnumerable()
                    select new
                    {
                        Grade = rec.Field<int>("Wavelength") + " nm Grade " + rec.Field<int>("Grade"),
                        Key = rec.Field<int>("Wavelength") + "," + rec.Field<int>("Grade")
                    };
            comboType.DataSource = r.ToList();
            comboType.DisplayMember = "Grade";
            comboType.ValueMember = "Key";
        }

        private void comboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            tableName = cmb.Text;
            LoadTypes();
        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            LoadClassData(cmb.SelectedIndex);
            groupQCWParameters.Visible = testData.IsQCWTest;
            LoadFormData(testData.IsQCWTest, false);
        }
        private void LoadClassData(int index)
        {
            if (index == -1)
                return;
            DataRow row = results.Rows[index];
            testData.IsQCWTest = tableName.Contains("QCW") ? true : false;
            testData.CoeffPower = (double)row["CoeffPower"];
            testData.MaximumCurrent_A = (double)row["MaximumCurrent_A"];
            testData.Wavelength = (int)row["Wavelength"];
            testData.Grade = (int)row["Grade"];
            testData.OperatingCurrent_A = (double)row["OperatingCurrent_A"];
            testData.Step_A = (double)row["Step_A"];
            testData.ThresholdPower_W = (double)row["ThresholdPower_W"];
            testData.MeasurementTime_ms = (int)row["MeasurementTime_ms"];
            testData.MinThresholdCurrent_A = (double)row["MinThresholdCurrent_A"];
            testData.MaxThresholdCurrent_A = (double)row["MaxThresholdCurrent_A"];
            testData.MinSlope_WA = (double)row["MinSlope_WA"];
            testData.MaxSlope_WA = (double)row["MaxSlope_WA"];
            testData.MinPowAtOp_W = (double)row["MinPowAtOp_W"];
            testData.MinPowAtMax_W = (double)row["MinPowAtMax_W"];
            if (testData.IsQCWTest)
            {
                testData.PulseDuration_ms = (double)row["PulseDuration_ms"];
                testData.DutyCycle = 100 * (double)row["DutyCycle"];
            }
        }
        private void LoadFormData(bool isQCW, bool bClear)
        {
            txtPowerCoeff.Text = bClear ? string.Empty : testData.CoeffPower.ToString();
            txtCurrentMaximum.Text = bClear ? string.Empty: testData.MaximumCurrent_A.ToString();
            txtSMaximum.Text = bClear ? string.Empty : testData.MaxSlope_WA.ToString();
            txtSMinimum.Text = bClear ? string.Empty : testData.MinSlope_WA.ToString();
            txtCurrentStep.Text = bClear ? string.Empty : testData.Step_A.ToString();
            txtTMaximum.Text = bClear ? string.Empty : testData.MaxThresholdCurrent_A.ToString();
            txtTMinimum.Text = bClear ? string.Empty : testData.MinThresholdCurrent_A.ToString();
            txtPowerLevel.Text = bClear ? string.Empty : testData.ThresholdPower_W.ToString();
            txtWaitTime.Text = bClear ? string.Empty : testData.MeasurementTime_ms.ToString();
            txtCurrentOperation.Text = bClear ? string.Empty : testData.OperatingCurrent_A.ToString();
            txtPowerMinimumOp.Text = bClear ? string.Empty : testData.MinPowAtOp_W.ToString();
            txtPowerMinimumMax.Text = bClear ? string.Empty : testData.MinPowAtMax_W.ToString();
            if (isQCW)
            {
                txtPulseWidth.Text = bClear ? string.Empty : testData.PulseDuration_ms.ToString();
                txtDutyCycle.Text = bClear ? string.Empty : testData.DutyCycle.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           OleDbCommand cmd = new OleDbCommand(@"Update " + tableName + " SET MinSlope_WA = @MinSlope_WA WHERE Wavelength = @Wavelength AND Grade=@Grade", connection);
            cmd.Parameters.AddWithValue("@MinSlope_WA", txtSMinimum.Text);
            cmd.Parameters.AddWithValue("@Wavelength", testData.Wavelength);
            cmd.Parameters.AddWithValue("@Grade", testData.Grade);
            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("DATA UPDATED");
            }
        catch (Exception exp)
            {
                MessageBox.Show(exp.Source);
            }

            return;
            string filename = "_" + testData.Wavelength.ToString() + "_G" + testData.Grade.ToString() + (testData.IsQCWTest ? "QCW" : "CW");
            MeasureForm frmMeasure = new MeasureForm(filename);
            frmMeasure.TopLevel = true;
            frmMeasure.Owner = this;
            //frmMeasure.fileName=
            frmMeasure.Show();
        }
    }
}
