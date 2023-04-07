namespace LaserDiodeTest
{
    partial class MeasureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupName = new System.Windows.Forms.GroupBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.lblUnderscore = new System.Windows.Forms.Label();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.groupMeasurement = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblPowOp = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblIth = new System.Windows.Forms.Label();
            this.lblSlope = new System.Windows.Forms.Label();
            this.lblPowMax = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPower = new System.Windows.Forms.Label();
            this.lblVoltage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupName.SuspendLayout();
            this.groupMeasurement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(13, 585);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupName
            // 
            this.groupName.Controls.Add(this.lblFileName);
            this.groupName.Controls.Add(this.txtName2);
            this.groupName.Controls.Add(this.lblUnderscore);
            this.groupName.Controls.Add(this.txtName1);
            this.groupName.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.groupName.Location = new System.Drawing.Point(13, 13);
            this.groupName.Margin = new System.Windows.Forms.Padding(4);
            this.groupName.Name = "groupName";
            this.groupName.Padding = new System.Windows.Forms.Padding(4);
            this.groupName.Size = new System.Drawing.Size(864, 88);
            this.groupName.TabIndex = 6;
            this.groupName.TabStop = false;
            this.groupName.Text = "Name";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(250, 42);
            this.lblFileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(126, 21);
            this.lblFileName.TabIndex = 4;
            this.lblFileName.Text = "_915_G15_QCW";
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(136, 36);
            this.txtName2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(100, 28);
            this.txtName2.TabIndex = 3;
            this.txtName2.Text = "1";
            // 
            // lblUnderscore
            // 
            this.lblUnderscore.AutoSize = true;
            this.lblUnderscore.Location = new System.Drawing.Point(114, 42);
            this.lblUnderscore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnderscore.Name = "lblUnderscore";
            this.lblUnderscore.Size = new System.Drawing.Size(18, 21);
            this.lblUnderscore.TabIndex = 1;
            this.lblUnderscore.Text = "_";
            // 
            // txtName1
            // 
            this.txtName1.Location = new System.Drawing.Point(8, 36);
            this.txtName1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(100, 28);
            this.txtName1.TabIndex = 2;
            this.txtName1.Text = "1";
            // 
            // groupMeasurement
            // 
            this.groupMeasurement.Controls.Add(this.label14);
            this.groupMeasurement.Controls.Add(this.label13);
            this.groupMeasurement.Controls.Add(this.label12);
            this.groupMeasurement.Controls.Add(this.lblPowOp);
            this.groupMeasurement.Controls.Add(this.label10);
            this.groupMeasurement.Controls.Add(this.label9);
            this.groupMeasurement.Controls.Add(this.lblCurrent);
            this.groupMeasurement.Controls.Add(this.lblIth);
            this.groupMeasurement.Controls.Add(this.lblSlope);
            this.groupMeasurement.Controls.Add(this.lblPowMax);
            this.groupMeasurement.Controls.Add(this.label4);
            this.groupMeasurement.Controls.Add(this.lblPower);
            this.groupMeasurement.Controls.Add(this.lblVoltage);
            this.groupMeasurement.Controls.Add(this.label1);
            this.groupMeasurement.Controls.Add(this.btnStart);
            this.groupMeasurement.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.groupMeasurement.Location = new System.Drawing.Point(13, 109);
            this.groupMeasurement.Margin = new System.Windows.Forms.Padding(4);
            this.groupMeasurement.Name = "groupMeasurement";
            this.groupMeasurement.Padding = new System.Windows.Forms.Padding(4);
            this.groupMeasurement.Size = new System.Drawing.Size(270, 351);
            this.groupMeasurement.TabIndex = 8;
            this.groupMeasurement.TabStop = false;
            this.groupMeasurement.Text = "Measurement";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(145, 320);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 21);
            this.label14.TabIndex = 20;
            this.label14.Text = "000000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(145, 284);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 21);
            this.label13.TabIndex = 19;
            this.label13.Text = "000000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(145, 248);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 21);
            this.label12.TabIndex = 18;
            this.label12.Text = "000000";
            // 
            // lblPowOp
            // 
            this.lblPowOp.AutoSize = true;
            this.lblPowOp.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPowOp.Location = new System.Drawing.Point(145, 212);
            this.lblPowOp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPowOp.Name = "lblPowOp";
            this.lblPowOp.Size = new System.Drawing.Size(64, 21);
            this.lblPowOp.TabIndex = 17;
            this.lblPowOp.Text = "000000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(145, 158);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 21);
            this.label10.TabIndex = 16;
            this.label10.Text = "000000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(145, 122);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "000000";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrent.Location = new System.Drawing.Point(145, 86);
            this.lblCurrent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(64, 21);
            this.lblCurrent.TabIndex = 14;
            this.lblCurrent.Text = "000000";
            // 
            // lblIth
            // 
            this.lblIth.AutoSize = true;
            this.lblIth.Location = new System.Drawing.Point(12, 320);
            this.lblIth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIth.Name = "lblIth";
            this.lblIth.Size = new System.Drawing.Size(53, 21);
            this.lblIth.TabIndex = 13;
            this.lblIth.Text = "Ith, A:";
            // 
            // lblSlope
            // 
            this.lblSlope.AutoSize = true;
            this.lblSlope.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblSlope.Location = new System.Drawing.Point(12, 284);
            this.lblSlope.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSlope.Name = "lblSlope";
            this.lblSlope.Size = new System.Drawing.Size(93, 21);
            this.lblSlope.TabIndex = 12;
            this.lblSlope.Text = "Slope, W/A:";
            // 
            // lblPowMax
            // 
            this.lblPowMax.AutoSize = true;
            this.lblPowMax.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblPowMax.Location = new System.Drawing.Point(12, 248);
            this.lblPowMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPowMax.Name = "lblPowMax";
            this.lblPowMax.Size = new System.Drawing.Size(104, 21);
            this.lblPowMax.TabIndex = 11;
            this.lblPowMax.Text = "Pow Max, W:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pow Op, W:";
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblPower.Location = new System.Drawing.Point(12, 158);
            this.lblPower.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(83, 21);
            this.lblPower.TabIndex = 9;
            this.lblPower.Text = "Power, W:";
            // 
            // lblVoltage
            // 
            this.lblVoltage.AutoSize = true;
            this.lblVoltage.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblVoltage.Location = new System.Drawing.Point(12, 122);
            this.lblVoltage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVoltage.Name = "lblVoltage";
            this.lblVoltage.Size = new System.Drawing.Size(86, 21);
            this.lblVoltage.TabIndex = 8;
            this.lblVoltage.Text = "Voltage, V:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Current, A:";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnStart.Location = new System.Drawing.Point(67, 34);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(115, 40);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.Location = new System.Drawing.Point(89, 464);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(101, 29);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "FAILED";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(149, 509);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 60);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(303, 114);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(1027, 504);
            this.chart.TabIndex = 15;
            this.chart.Text = "chart1";
            // 
            // MeasureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 630);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.groupMeasurement);
            this.Controls.Add(this.groupName);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MeasureForm";
            this.Text = "Form_Measure_Universal";
            this.Load += new System.EventHandler(this.MeasureForm_Load);
            this.groupName.ResumeLayout(false);
            this.groupName.PerformLayout();
            this.groupMeasurement.ResumeLayout(false);
            this.groupMeasurement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupName;
        private System.Windows.Forms.GroupBox groupMeasurement;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblUnderscore;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblIth;
        private System.Windows.Forms.Label lblSlope;
        private System.Windows.Forms.Label lblPowMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.Label lblVoltage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPowOp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}