namespace LaserDiodeTest
{
    partial class TestForm
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
            this.groupTest = new System.Windows.Forms.GroupBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.comboName = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.groupCurrentParameters = new System.Windows.Forms.GroupBox();
            this.lblWaitTimeMs = new System.Windows.Forms.Label();
            this.lblPowerMinimumOpW = new System.Windows.Forms.Label();
            this.lblPowerMiniumMaxW = new System.Windows.Forms.Label();
            this.lblCurrentStepA = new System.Windows.Forms.Label();
            this.lblCurrentOperationA = new System.Windows.Forms.Label();
            this.lblCurrentMaximumA = new System.Windows.Forms.Label();
            this.txtWaitTime = new System.Windows.Forms.TextBox();
            this.txtPowerMinimumOp = new System.Windows.Forms.TextBox();
            this.lblWaitTime = new System.Windows.Forms.Label();
            this.lblPowerMinimumOp = new System.Windows.Forms.Label();
            this.lblPowerMiniumMax = new System.Windows.Forms.Label();
            this.txtPowerMinimumMax = new System.Windows.Forms.TextBox();
            this.txtCurrentStep = new System.Windows.Forms.TextBox();
            this.txtCurrentOperation = new System.Windows.Forms.TextBox();
            this.lblCurrentStep = new System.Windows.Forms.Label();
            this.lblCurrentOperation = new System.Windows.Forms.Label();
            this.lblCurrentMaximum = new System.Windows.Forms.Label();
            this.txtCurrentMaximum = new System.Windows.Forms.TextBox();
            this.groupPowerCoeff = new System.Windows.Forms.GroupBox();
            this.txtPowerCoeff = new System.Windows.Forms.TextBox();
            this.groupSlope = new System.Windows.Forms.GroupBox();
            this.lblSMaximumWA = new System.Windows.Forms.Label();
            this.lblSMinimumWA = new System.Windows.Forms.Label();
            this.txtSMaximum = new System.Windows.Forms.TextBox();
            this.lblSMaximum = new System.Windows.Forms.Label();
            this.lblSMinimum = new System.Windows.Forms.Label();
            this.txtSMinimum = new System.Windows.Forms.TextBox();
            this.groupThreshold = new System.Windows.Forms.GroupBox();
            this.lblPowerLevelW = new System.Windows.Forms.Label();
            this.lblTMaximumA = new System.Windows.Forms.Label();
            this.lblTMinimumA = new System.Windows.Forms.Label();
            this.txtPowerLevel = new System.Windows.Forms.TextBox();
            this.txtTMaximum = new System.Windows.Forms.TextBox();
            this.lblPowerLevel = new System.Windows.Forms.Label();
            this.lblTMaximum = new System.Windows.Forms.Label();
            this.lblTMinimum = new System.Windows.Forms.Label();
            this.txtTMinimum = new System.Windows.Forms.TextBox();
            this.groupQCWParameters = new System.Windows.Forms.GroupBox();
            this.lblDutyCycleP = new System.Windows.Forms.Label();
            this.lblPulseWidthMs = new System.Windows.Forms.Label();
            this.txtDutyCycle = new System.Windows.Forms.TextBox();
            this.lblDutyCycle = new System.Windows.Forms.Label();
            this.lblPulseWidth = new System.Windows.Forms.Label();
            this.txtPulseWidth = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupTest.SuspendLayout();
            this.groupCurrentParameters.SuspendLayout();
            this.groupPowerCoeff.SuspendLayout();
            this.groupSlope.SuspendLayout();
            this.groupThreshold.SuspendLayout();
            this.groupQCWParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupTest
            // 
            this.groupTest.Controls.Add(this.comboType);
            this.groupTest.Controls.Add(this.comboName);
            this.groupTest.Controls.Add(this.lblType);
            this.groupTest.Controls.Add(this.lblName);
            this.groupTest.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.groupTest.Location = new System.Drawing.Point(37, 37);
            this.groupTest.Margin = new System.Windows.Forms.Padding(4);
            this.groupTest.Name = "groupTest";
            this.groupTest.Padding = new System.Windows.Forms.Padding(4);
            this.groupTest.Size = new System.Drawing.Size(709, 123);
            this.groupTest.TabIndex = 0;
            this.groupTest.TabStop = false;
            this.groupTest.Text = "Test";
            // 
            // comboType
            // 
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(80, 68);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(557, 29);
            this.comboType.TabIndex = 5;
            this.comboType.SelectedIndexChanged += new System.EventHandler(this.comboType_SelectedIndexChanged);
            // 
            // comboName
            // 
            this.comboName.FormattingEnabled = true;
            this.comboName.Location = new System.Drawing.Point(80, 32);
            this.comboName.Name = "comboName";
            this.comboName.Size = new System.Drawing.Size(190, 29);
            this.comboName.TabIndex = 4;
            this.comboName.SelectedIndexChanged += new System.EventHandler(this.comboName_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(8, 71);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(48, 21);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 21);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // groupCurrentParameters
            // 
            this.groupCurrentParameters.Controls.Add(this.lblWaitTimeMs);
            this.groupCurrentParameters.Controls.Add(this.lblPowerMinimumOpW);
            this.groupCurrentParameters.Controls.Add(this.lblPowerMiniumMaxW);
            this.groupCurrentParameters.Controls.Add(this.lblCurrentStepA);
            this.groupCurrentParameters.Controls.Add(this.lblCurrentOperationA);
            this.groupCurrentParameters.Controls.Add(this.lblCurrentMaximumA);
            this.groupCurrentParameters.Controls.Add(this.txtWaitTime);
            this.groupCurrentParameters.Controls.Add(this.txtPowerMinimumOp);
            this.groupCurrentParameters.Controls.Add(this.lblWaitTime);
            this.groupCurrentParameters.Controls.Add(this.lblPowerMinimumOp);
            this.groupCurrentParameters.Controls.Add(this.lblPowerMiniumMax);
            this.groupCurrentParameters.Controls.Add(this.txtPowerMinimumMax);
            this.groupCurrentParameters.Controls.Add(this.txtCurrentStep);
            this.groupCurrentParameters.Controls.Add(this.txtCurrentOperation);
            this.groupCurrentParameters.Controls.Add(this.lblCurrentStep);
            this.groupCurrentParameters.Controls.Add(this.lblCurrentOperation);
            this.groupCurrentParameters.Controls.Add(this.lblCurrentMaximum);
            this.groupCurrentParameters.Controls.Add(this.txtCurrentMaximum);
            this.groupCurrentParameters.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.groupCurrentParameters.Location = new System.Drawing.Point(37, 181);
            this.groupCurrentParameters.Margin = new System.Windows.Forms.Padding(4);
            this.groupCurrentParameters.Name = "groupCurrentParameters";
            this.groupCurrentParameters.Padding = new System.Windows.Forms.Padding(4);
            this.groupCurrentParameters.Size = new System.Drawing.Size(662, 156);
            this.groupCurrentParameters.TabIndex = 1;
            this.groupCurrentParameters.TabStop = false;
            this.groupCurrentParameters.Text = "Current Parameters";
            // 
            // lblWaitTimeMs
            // 
            this.lblWaitTimeMs.AutoSize = true;
            this.lblWaitTimeMs.Location = new System.Drawing.Point(598, 111);
            this.lblWaitTimeMs.Name = "lblWaitTimeMs";
            this.lblWaitTimeMs.Size = new System.Drawing.Size(31, 21);
            this.lblWaitTimeMs.TabIndex = 17;
            this.lblWaitTimeMs.Text = "ms";
            // 
            // lblPowerMinimumOpW
            // 
            this.lblPowerMinimumOpW.AutoSize = true;
            this.lblPowerMinimumOpW.Location = new System.Drawing.Point(598, 75);
            this.lblPowerMinimumOpW.Name = "lblPowerMinimumOpW";
            this.lblPowerMinimumOpW.Size = new System.Drawing.Size(25, 21);
            this.lblPowerMinimumOpW.TabIndex = 16;
            this.lblPowerMinimumOpW.Text = "W";
            // 
            // lblPowerMiniumMaxW
            // 
            this.lblPowerMiniumMaxW.AutoSize = true;
            this.lblPowerMiniumMaxW.Location = new System.Drawing.Point(598, 39);
            this.lblPowerMiniumMaxW.Name = "lblPowerMiniumMaxW";
            this.lblPowerMiniumMaxW.Size = new System.Drawing.Size(25, 21);
            this.lblPowerMiniumMaxW.TabIndex = 15;
            this.lblPowerMiniumMaxW.Text = "W";
            // 
            // lblCurrentStepA
            // 
            this.lblCurrentStepA.AutoSize = true;
            this.lblCurrentStepA.Location = new System.Drawing.Point(273, 111);
            this.lblCurrentStepA.Name = "lblCurrentStepA";
            this.lblCurrentStepA.Size = new System.Drawing.Size(20, 21);
            this.lblCurrentStepA.TabIndex = 14;
            this.lblCurrentStepA.Text = "A";
            // 
            // lblCurrentOperationA
            // 
            this.lblCurrentOperationA.AutoSize = true;
            this.lblCurrentOperationA.Location = new System.Drawing.Point(273, 75);
            this.lblCurrentOperationA.Name = "lblCurrentOperationA";
            this.lblCurrentOperationA.Size = new System.Drawing.Size(20, 21);
            this.lblCurrentOperationA.TabIndex = 13;
            this.lblCurrentOperationA.Text = "A";
            // 
            // lblCurrentMaximumA
            // 
            this.lblCurrentMaximumA.AutoSize = true;
            this.lblCurrentMaximumA.Location = new System.Drawing.Point(273, 39);
            this.lblCurrentMaximumA.Name = "lblCurrentMaximumA";
            this.lblCurrentMaximumA.Size = new System.Drawing.Size(20, 21);
            this.lblCurrentMaximumA.TabIndex = 12;
            this.lblCurrentMaximumA.Text = "A";
            // 
            // txtWaitTime
            // 
            this.txtWaitTime.Location = new System.Drawing.Point(492, 108);
            this.txtWaitTime.Name = "txtWaitTime";
            this.txtWaitTime.Size = new System.Drawing.Size(100, 28);
            this.txtWaitTime.TabIndex = 11;
            // 
            // txtPowerMinimumOp
            // 
            this.txtPowerMinimumOp.Location = new System.Drawing.Point(492, 72);
            this.txtPowerMinimumOp.Name = "txtPowerMinimumOp";
            this.txtPowerMinimumOp.Size = new System.Drawing.Size(100, 28);
            this.txtPowerMinimumOp.TabIndex = 10;
            // 
            // lblWaitTime
            // 
            this.lblWaitTime.AutoSize = true;
            this.lblWaitTime.Location = new System.Drawing.Point(341, 111);
            this.lblWaitTime.Name = "lblWaitTime";
            this.lblWaitTime.Size = new System.Drawing.Size(84, 21);
            this.lblWaitTime.TabIndex = 9;
            this.lblWaitTime.Text = "Wait time:";
            // 
            // lblPowerMinimumOp
            // 
            this.lblPowerMinimumOp.AutoSize = true;
            this.lblPowerMinimumOp.Location = new System.Drawing.Point(341, 75);
            this.lblPowerMinimumOp.Name = "lblPowerMinimumOp";
            this.lblPowerMinimumOp.Size = new System.Drawing.Size(133, 21);
            this.lblPowerMinimumOp.TabIndex = 8;
            this.lblPowerMinimumOp.Text = "Power minimum:";
            // 
            // lblPowerMiniumMax
            // 
            this.lblPowerMiniumMax.AutoSize = true;
            this.lblPowerMiniumMax.Location = new System.Drawing.Point(341, 39);
            this.lblPowerMiniumMax.Name = "lblPowerMiniumMax";
            this.lblPowerMiniumMax.Size = new System.Drawing.Size(133, 21);
            this.lblPowerMiniumMax.TabIndex = 6;
            this.lblPowerMiniumMax.Text = "Power minimum:";
            // 
            // txtPowerMinimumMax
            // 
            this.txtPowerMinimumMax.Location = new System.Drawing.Point(492, 36);
            this.txtPowerMinimumMax.Name = "txtPowerMinimumMax";
            this.txtPowerMinimumMax.Size = new System.Drawing.Size(100, 28);
            this.txtPowerMinimumMax.TabIndex = 7;
            // 
            // txtCurrentStep
            // 
            this.txtCurrentStep.Location = new System.Drawing.Point(167, 108);
            this.txtCurrentStep.Name = "txtCurrentStep";
            this.txtCurrentStep.Size = new System.Drawing.Size(100, 28);
            this.txtCurrentStep.TabIndex = 5;
            // 
            // txtCurrentOperation
            // 
            this.txtCurrentOperation.Location = new System.Drawing.Point(167, 72);
            this.txtCurrentOperation.Name = "txtCurrentOperation";
            this.txtCurrentOperation.Size = new System.Drawing.Size(100, 28);
            this.txtCurrentOperation.TabIndex = 4;
            // 
            // lblCurrentStep
            // 
            this.lblCurrentStep.AutoSize = true;
            this.lblCurrentStep.Location = new System.Drawing.Point(8, 111);
            this.lblCurrentStep.Name = "lblCurrentStep";
            this.lblCurrentStep.Size = new System.Drawing.Size(104, 21);
            this.lblCurrentStep.TabIndex = 2;
            this.lblCurrentStep.Text = "Current step:";
            // 
            // lblCurrentOperation
            // 
            this.lblCurrentOperation.AutoSize = true;
            this.lblCurrentOperation.Location = new System.Drawing.Point(8, 75);
            this.lblCurrentOperation.Name = "lblCurrentOperation";
            this.lblCurrentOperation.Size = new System.Drawing.Size(142, 21);
            this.lblCurrentOperation.TabIndex = 1;
            this.lblCurrentOperation.Text = "Current operation:";
            // 
            // lblCurrentMaximum
            // 
            this.lblCurrentMaximum.AutoSize = true;
            this.lblCurrentMaximum.Location = new System.Drawing.Point(8, 39);
            this.lblCurrentMaximum.Name = "lblCurrentMaximum";
            this.lblCurrentMaximum.Size = new System.Drawing.Size(144, 21);
            this.lblCurrentMaximum.TabIndex = 0;
            this.lblCurrentMaximum.Text = "Current maximum:";
            // 
            // txtCurrentMaximum
            // 
            this.txtCurrentMaximum.Location = new System.Drawing.Point(167, 36);
            this.txtCurrentMaximum.Name = "txtCurrentMaximum";
            this.txtCurrentMaximum.Size = new System.Drawing.Size(100, 28);
            this.txtCurrentMaximum.TabIndex = 0;
            // 
            // groupPowerCoeff
            // 
            this.groupPowerCoeff.Controls.Add(this.txtPowerCoeff);
            this.groupPowerCoeff.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.groupPowerCoeff.Location = new System.Drawing.Point(628, 381);
            this.groupPowerCoeff.Margin = new System.Windows.Forms.Padding(4);
            this.groupPowerCoeff.Name = "groupPowerCoeff";
            this.groupPowerCoeff.Padding = new System.Windows.Forms.Padding(4);
            this.groupPowerCoeff.Size = new System.Drawing.Size(211, 69);
            this.groupPowerCoeff.TabIndex = 2;
            this.groupPowerCoeff.TabStop = false;
            this.groupPowerCoeff.Text = "Power Coeff";
            // 
            // txtPowerCoeff
            // 
            this.txtPowerCoeff.Location = new System.Drawing.Point(26, 33);
            this.txtPowerCoeff.Name = "txtPowerCoeff";
            this.txtPowerCoeff.Size = new System.Drawing.Size(100, 28);
            this.txtPowerCoeff.TabIndex = 8;
            // 
            // groupSlope
            // 
            this.groupSlope.Controls.Add(this.lblSMaximumWA);
            this.groupSlope.Controls.Add(this.lblSMinimumWA);
            this.groupSlope.Controls.Add(this.txtSMaximum);
            this.groupSlope.Controls.Add(this.lblSMaximum);
            this.groupSlope.Controls.Add(this.lblSMinimum);
            this.groupSlope.Controls.Add(this.txtSMinimum);
            this.groupSlope.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.groupSlope.Location = new System.Drawing.Point(336, 345);
            this.groupSlope.Margin = new System.Windows.Forms.Padding(4);
            this.groupSlope.Name = "groupSlope";
            this.groupSlope.Padding = new System.Windows.Forms.Padding(4);
            this.groupSlope.Size = new System.Drawing.Size(267, 123);
            this.groupSlope.TabIndex = 1;
            this.groupSlope.TabStop = false;
            this.groupSlope.Text = "Slope";
            // 
            // lblSMaximumWA
            // 
            this.lblSMaximumWA.AutoSize = true;
            this.lblSMaximumWA.Location = new System.Drawing.Point(215, 75);
            this.lblSMaximumWA.Name = "lblSMaximumWA";
            this.lblSMaximumWA.Size = new System.Drawing.Size(41, 21);
            this.lblSMaximumWA.TabIndex = 19;
            this.lblSMaximumWA.Text = "W/A";
            // 
            // lblSMinimumWA
            // 
            this.lblSMinimumWA.AutoSize = true;
            this.lblSMinimumWA.Location = new System.Drawing.Point(215, 39);
            this.lblSMinimumWA.Name = "lblSMinimumWA";
            this.lblSMinimumWA.Size = new System.Drawing.Size(41, 21);
            this.lblSMinimumWA.TabIndex = 18;
            this.lblSMinimumWA.Text = "W/A";
            // 
            // txtSMaximum
            // 
            this.txtSMaximum.Location = new System.Drawing.Point(109, 72);
            this.txtSMaximum.Name = "txtSMaximum";
            this.txtSMaximum.Size = new System.Drawing.Size(100, 28);
            this.txtSMaximum.TabIndex = 14;
            // 
            // lblSMaximum
            // 
            this.lblSMaximum.AutoSize = true;
            this.lblSMaximum.Location = new System.Drawing.Point(8, 75);
            this.lblSMaximum.Name = "lblSMaximum";
            this.lblSMaximum.Size = new System.Drawing.Size(87, 21);
            this.lblSMaximum.TabIndex = 13;
            this.lblSMaximum.Text = "Maximum:";
            // 
            // lblSMinimum
            // 
            this.lblSMinimum.AutoSize = true;
            this.lblSMinimum.Location = new System.Drawing.Point(8, 39);
            this.lblSMinimum.Name = "lblSMinimum";
            this.lblSMinimum.Size = new System.Drawing.Size(84, 21);
            this.lblSMinimum.TabIndex = 11;
            this.lblSMinimum.Text = "Minimum:";
            // 
            // txtSMinimum
            // 
            this.txtSMinimum.Location = new System.Drawing.Point(109, 36);
            this.txtSMinimum.Name = "txtSMinimum";
            this.txtSMinimum.Size = new System.Drawing.Size(100, 28);
            this.txtSMinimum.TabIndex = 12;
            // 
            // groupThreshold
            // 
            this.groupThreshold.Controls.Add(this.lblPowerLevelW);
            this.groupThreshold.Controls.Add(this.lblTMaximumA);
            this.groupThreshold.Controls.Add(this.lblTMinimumA);
            this.groupThreshold.Controls.Add(this.txtPowerLevel);
            this.groupThreshold.Controls.Add(this.txtTMaximum);
            this.groupThreshold.Controls.Add(this.lblPowerLevel);
            this.groupThreshold.Controls.Add(this.lblTMaximum);
            this.groupThreshold.Controls.Add(this.lblTMinimum);
            this.groupThreshold.Controls.Add(this.txtTMinimum);
            this.groupThreshold.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.groupThreshold.Location = new System.Drawing.Point(37, 345);
            this.groupThreshold.Margin = new System.Windows.Forms.Padding(4);
            this.groupThreshold.Name = "groupThreshold";
            this.groupThreshold.Padding = new System.Windows.Forms.Padding(4);
            this.groupThreshold.Size = new System.Drawing.Size(277, 156);
            this.groupThreshold.TabIndex = 1;
            this.groupThreshold.TabStop = false;
            this.groupThreshold.Text = "Threshold";
            // 
            // lblPowerLevelW
            // 
            this.lblPowerLevelW.AutoSize = true;
            this.lblPowerLevelW.Location = new System.Drawing.Point(250, 111);
            this.lblPowerLevelW.Name = "lblPowerLevelW";
            this.lblPowerLevelW.Size = new System.Drawing.Size(25, 21);
            this.lblPowerLevelW.TabIndex = 17;
            this.lblPowerLevelW.Text = "W";
            // 
            // lblTMaximumA
            // 
            this.lblTMaximumA.AutoSize = true;
            this.lblTMaximumA.Location = new System.Drawing.Point(250, 75);
            this.lblTMaximumA.Name = "lblTMaximumA";
            this.lblTMaximumA.Size = new System.Drawing.Size(20, 21);
            this.lblTMaximumA.TabIndex = 14;
            this.lblTMaximumA.Text = "A";
            // 
            // lblTMinimumA
            // 
            this.lblTMinimumA.AutoSize = true;
            this.lblTMinimumA.Location = new System.Drawing.Point(250, 39);
            this.lblTMinimumA.Name = "lblTMinimumA";
            this.lblTMinimumA.Size = new System.Drawing.Size(20, 21);
            this.lblTMinimumA.TabIndex = 13;
            this.lblTMinimumA.Text = "A";
            // 
            // txtPowerLevel
            // 
            this.txtPowerLevel.Location = new System.Drawing.Point(139, 108);
            this.txtPowerLevel.Name = "txtPowerLevel";
            this.txtPowerLevel.Size = new System.Drawing.Size(100, 28);
            this.txtPowerLevel.TabIndex = 11;
            // 
            // txtTMaximum
            // 
            this.txtTMaximum.Location = new System.Drawing.Point(139, 72);
            this.txtTMaximum.Name = "txtTMaximum";
            this.txtTMaximum.Size = new System.Drawing.Size(100, 28);
            this.txtTMaximum.TabIndex = 10;
            // 
            // lblPowerLevel
            // 
            this.lblPowerLevel.AutoSize = true;
            this.lblPowerLevel.Location = new System.Drawing.Point(8, 111);
            this.lblPowerLevel.Name = "lblPowerLevel";
            this.lblPowerLevel.Size = new System.Drawing.Size(102, 21);
            this.lblPowerLevel.TabIndex = 9;
            this.lblPowerLevel.Text = "Power Level:";
            // 
            // lblTMaximum
            // 
            this.lblTMaximum.AutoSize = true;
            this.lblTMaximum.Location = new System.Drawing.Point(8, 75);
            this.lblTMaximum.Name = "lblTMaximum";
            this.lblTMaximum.Size = new System.Drawing.Size(87, 21);
            this.lblTMaximum.TabIndex = 8;
            this.lblTMaximum.Text = "Maximum:";
            // 
            // lblTMinimum
            // 
            this.lblTMinimum.AutoSize = true;
            this.lblTMinimum.Location = new System.Drawing.Point(8, 39);
            this.lblTMinimum.Name = "lblTMinimum";
            this.lblTMinimum.Size = new System.Drawing.Size(84, 21);
            this.lblTMinimum.TabIndex = 6;
            this.lblTMinimum.Text = "Minimum:";
            // 
            // txtTMinimum
            // 
            this.txtTMinimum.Location = new System.Drawing.Point(139, 36);
            this.txtTMinimum.Name = "txtTMinimum";
            this.txtTMinimum.Size = new System.Drawing.Size(100, 28);
            this.txtTMinimum.TabIndex = 7;
            // 
            // groupQCWParameters
            // 
            this.groupQCWParameters.Controls.Add(this.lblDutyCycleP);
            this.groupQCWParameters.Controls.Add(this.lblPulseWidthMs);
            this.groupQCWParameters.Controls.Add(this.txtDutyCycle);
            this.groupQCWParameters.Controls.Add(this.lblDutyCycle);
            this.groupQCWParameters.Controls.Add(this.lblPulseWidth);
            this.groupQCWParameters.Controls.Add(this.txtPulseWidth);
            this.groupQCWParameters.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.groupQCWParameters.Location = new System.Drawing.Point(763, 37);
            this.groupQCWParameters.Margin = new System.Windows.Forms.Padding(4);
            this.groupQCWParameters.Name = "groupQCWParameters";
            this.groupQCWParameters.Padding = new System.Windows.Forms.Padding(4);
            this.groupQCWParameters.Size = new System.Drawing.Size(270, 123);
            this.groupQCWParameters.TabIndex = 1;
            this.groupQCWParameters.TabStop = false;
            this.groupQCWParameters.Text = "QCW Parameters";
            // 
            // lblDutyCycleP
            // 
            this.lblDutyCycleP.AutoSize = true;
            this.lblDutyCycleP.Location = new System.Drawing.Point(226, 75);
            this.lblDutyCycleP.Name = "lblDutyCycleP";
            this.lblDutyCycleP.Size = new System.Drawing.Size(22, 21);
            this.lblDutyCycleP.TabIndex = 19;
            this.lblDutyCycleP.Text = "%";
            // 
            // lblPulseWidthMs
            // 
            this.lblPulseWidthMs.AutoSize = true;
            this.lblPulseWidthMs.Location = new System.Drawing.Point(226, 39);
            this.lblPulseWidthMs.Name = "lblPulseWidthMs";
            this.lblPulseWidthMs.Size = new System.Drawing.Size(31, 21);
            this.lblPulseWidthMs.TabIndex = 18;
            this.lblPulseWidthMs.Text = "ms";
            // 
            // txtDutyCycle
            // 
            this.txtDutyCycle.Location = new System.Drawing.Point(120, 72);
            this.txtDutyCycle.Name = "txtDutyCycle";
            this.txtDutyCycle.Size = new System.Drawing.Size(100, 28);
            this.txtDutyCycle.TabIndex = 8;
            // 
            // lblDutyCycle
            // 
            this.lblDutyCycle.AutoSize = true;
            this.lblDutyCycle.Location = new System.Drawing.Point(8, 75);
            this.lblDutyCycle.Name = "lblDutyCycle";
            this.lblDutyCycle.Size = new System.Drawing.Size(88, 21);
            this.lblDutyCycle.TabIndex = 7;
            this.lblDutyCycle.Text = "Duty cycle:";
            // 
            // lblPulseWidth
            // 
            this.lblPulseWidth.AutoSize = true;
            this.lblPulseWidth.Location = new System.Drawing.Point(8, 39);
            this.lblPulseWidth.Name = "lblPulseWidth";
            this.lblPulseWidth.Size = new System.Drawing.Size(98, 21);
            this.lblPulseWidth.TabIndex = 5;
            this.lblPulseWidth.Text = "Pulse width:";
            // 
            // txtPulseWidth
            // 
            this.txtPulseWidth.Location = new System.Drawing.Point(120, 36);
            this.txtPulseWidth.Name = "txtPulseWidth";
            this.txtPulseWidth.Size = new System.Drawing.Size(100, 28);
            this.txtPulseWidth.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(381, 495);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(164, 66);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(628, 495);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(164, 66);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 575);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupQCWParameters);
            this.Controls.Add(this.groupSlope);
            this.Controls.Add(this.groupThreshold);
            this.Controls.Add(this.groupPowerCoeff);
            this.Controls.Add(this.groupCurrentParameters);
            this.Controls.Add(this.groupTest);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TestForm";
            this.Text = "TestParameters_Universal";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.groupTest.ResumeLayout(false);
            this.groupTest.PerformLayout();
            this.groupCurrentParameters.ResumeLayout(false);
            this.groupCurrentParameters.PerformLayout();
            this.groupPowerCoeff.ResumeLayout(false);
            this.groupPowerCoeff.PerformLayout();
            this.groupSlope.ResumeLayout(false);
            this.groupSlope.PerformLayout();
            this.groupThreshold.ResumeLayout(false);
            this.groupThreshold.PerformLayout();
            this.groupQCWParameters.ResumeLayout(false);
            this.groupQCWParameters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupTest;
        private System.Windows.Forms.GroupBox groupCurrentParameters;
        private System.Windows.Forms.GroupBox groupPowerCoeff;
        private System.Windows.Forms.GroupBox groupSlope;
        private System.Windows.Forms.GroupBox groupThreshold;
        private System.Windows.Forms.GroupBox groupQCWParameters;
        private System.Windows.Forms.TextBox txtWaitTime;
        private System.Windows.Forms.TextBox txtPowerMinimumOp;
        private System.Windows.Forms.Label lblWaitTime;
        private System.Windows.Forms.Label lblPowerMinimumOp;
        private System.Windows.Forms.Label lblPowerMiniumMax;
        private System.Windows.Forms.TextBox txtPowerMinimumMax;
        private System.Windows.Forms.TextBox txtCurrentStep;
        private System.Windows.Forms.TextBox txtCurrentOperation;
        private System.Windows.Forms.Label lblCurrentStep;
        private System.Windows.Forms.Label lblCurrentOperation;
        private System.Windows.Forms.Label lblCurrentMaximum;
        private System.Windows.Forms.TextBox txtCurrentMaximum;
        private System.Windows.Forms.TextBox txtPowerCoeff;
        private System.Windows.Forms.TextBox txtSMaximum;
        private System.Windows.Forms.Label lblSMaximum;
        private System.Windows.Forms.Label lblSMinimum;
        private System.Windows.Forms.TextBox txtSMinimum;
        private System.Windows.Forms.TextBox txtPowerLevel;
        private System.Windows.Forms.TextBox txtTMaximum;
        private System.Windows.Forms.Label lblPowerLevel;
        private System.Windows.Forms.Label lblTMaximum;
        private System.Windows.Forms.Label lblTMinimum;
        private System.Windows.Forms.TextBox txtTMinimum;
        private System.Windows.Forms.TextBox txtDutyCycle;
        private System.Windows.Forms.Label lblDutyCycle;
        private System.Windows.Forms.Label lblPulseWidth;
        private System.Windows.Forms.TextBox txtPulseWidth;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.ComboBox comboName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblWaitTimeMs;
        private System.Windows.Forms.Label lblPowerMinimumOpW;
        private System.Windows.Forms.Label lblPowerMiniumMaxW;
        private System.Windows.Forms.Label lblCurrentStepA;
        private System.Windows.Forms.Label lblCurrentOperationA;
        private System.Windows.Forms.Label lblCurrentMaximumA;
        private System.Windows.Forms.Label lblSMaximumWA;
        private System.Windows.Forms.Label lblSMinimumWA;
        private System.Windows.Forms.Label lblPowerLevelW;
        private System.Windows.Forms.Label lblTMaximumA;
        private System.Windows.Forms.Label lblTMinimumA;
        private System.Windows.Forms.Label lblDutyCycleP;
        private System.Windows.Forms.Label lblPulseWidthMs;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
    }
}

