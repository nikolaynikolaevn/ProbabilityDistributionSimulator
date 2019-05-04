namespace ProbabilityDistributionSimulator
{
    partial class MainInterface
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
            this.pbGraph = new System.Windows.Forms.PictureBox();
            this.gbParameters = new System.Windows.Forms.GroupBox();
            this.nUpDownInterval = new System.Windows.Forms.NumericUpDown();
            this.nUpDownAverage = new System.Windows.Forms.NumericUpDown();
            this.nUpDownEvents = new System.Windows.Forms.NumericUpDown();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblEvents = new System.Windows.Forms.Label();
            this.lblInterval = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblPoisson = new System.Windows.Forms.Label();
            this.lblPoissonVariance = new System.Windows.Forms.Label();
            this.lblPoissonMean = new System.Windows.Forms.Label();
            this.lblPoissonStandardDeviation = new System.Windows.Forms.Label();
            this.lblExponentialStandardDeviation = new System.Windows.Forms.Label();
            this.lblExponentialVariance = new System.Windows.Forms.Label();
            this.lblExponentialMean = new System.Windows.Forms.Label();
            this.lblExponential = new System.Windows.Forms.Label();
            this.lblProbability = new System.Windows.Forms.Label();
            this.lblPoissonProbability = new System.Windows.Forms.Label();
            this.lblExponentialProbability = new System.Windows.Forms.Label();
            this.lblSimulationStandardDeviation = new System.Windows.Forms.Label();
            this.lblSimulationVariance = new System.Windows.Forms.Label();
            this.lblSimulationMean = new System.Windows.Forms.Label();
            this.lblSimulation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraph)).BeginInit();
            this.gbParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownAverage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGraph
            // 
            this.pbGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbGraph.Location = new System.Drawing.Point(12, 189);
            this.pbGraph.Name = "pbGraph";
            this.pbGraph.Size = new System.Drawing.Size(1178, 796);
            this.pbGraph.TabIndex = 12;
            this.pbGraph.TabStop = false;
            // 
            // gbParameters
            // 
            this.gbParameters.Controls.Add(this.nUpDownInterval);
            this.gbParameters.Controls.Add(this.nUpDownAverage);
            this.gbParameters.Controls.Add(this.nUpDownEvents);
            this.gbParameters.Controls.Add(this.lblAverage);
            this.gbParameters.Controls.Add(this.lblEvents);
            this.gbParameters.Controls.Add(this.lblInterval);
            this.gbParameters.Controls.Add(this.btnGenerate);
            this.gbParameters.Location = new System.Drawing.Point(12, 12);
            this.gbParameters.Name = "gbParameters";
            this.gbParameters.Size = new System.Drawing.Size(163, 162);
            this.gbParameters.TabIndex = 13;
            this.gbParameters.TabStop = false;
            // 
            // nUpDownInterval
            // 
            this.nUpDownInterval.Location = new System.Drawing.Point(79, 91);
            this.nUpDownInterval.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nUpDownInterval.Name = "nUpDownInterval";
            this.nUpDownInterval.Size = new System.Drawing.Size(75, 20);
            this.nUpDownInterval.TabIndex = 11;
            this.nUpDownInterval.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // nUpDownAverage
            // 
            this.nUpDownAverage.Location = new System.Drawing.Point(79, 56);
            this.nUpDownAverage.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nUpDownAverage.Name = "nUpDownAverage";
            this.nUpDownAverage.Size = new System.Drawing.Size(75, 20);
            this.nUpDownAverage.TabIndex = 10;
            this.nUpDownAverage.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // nUpDownEvents
            // 
            this.nUpDownEvents.Location = new System.Drawing.Point(79, 25);
            this.nUpDownEvents.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nUpDownEvents.Name = "nUpDownEvents";
            this.nUpDownEvents.Size = new System.Drawing.Size(75, 20);
            this.nUpDownEvents.TabIndex = 9;
            this.nUpDownEvents.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(6, 58);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(64, 13);
            this.lblAverage.TabIndex = 5;
            this.lblAverage.Text = "Average (λ):";
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.Location = new System.Drawing.Point(6, 27);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(43, 13);
            this.lblEvents.TabIndex = 6;
            this.lblEvents.Text = "Events:";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(6, 93);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(57, 13);
            this.lblInterval.TabIndex = 7;
            this.lblInterval.Text = "Interval (t):";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(43, 125);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblPoisson
            // 
            this.lblPoisson.AutoSize = true;
            this.lblPoisson.Location = new System.Drawing.Point(224, 41);
            this.lblPoisson.Name = "lblPoisson";
            this.lblPoisson.Size = new System.Drawing.Size(47, 13);
            this.lblPoisson.TabIndex = 12;
            this.lblPoisson.Text = "Poisson:";
            // 
            // lblPoissonVariance
            // 
            this.lblPoissonVariance.AutoSize = true;
            this.lblPoissonVariance.Location = new System.Drawing.Point(224, 90);
            this.lblPoissonVariance.Name = "lblPoissonVariance";
            this.lblPoissonVariance.Size = new System.Drawing.Size(58, 13);
            this.lblPoissonVariance.TabIndex = 13;
            this.lblPoissonVariance.Text = "Variance: -";
            // 
            // lblPoissonMean
            // 
            this.lblPoissonMean.AutoSize = true;
            this.lblPoissonMean.Location = new System.Drawing.Point(224, 66);
            this.lblPoissonMean.Name = "lblPoissonMean";
            this.lblPoissonMean.Size = new System.Drawing.Size(43, 13);
            this.lblPoissonMean.TabIndex = 14;
            this.lblPoissonMean.Text = "Mean: -";
            // 
            // lblPoissonStandardDeviation
            // 
            this.lblPoissonStandardDeviation.AutoSize = true;
            this.lblPoissonStandardDeviation.Location = new System.Drawing.Point(224, 116);
            this.lblPoissonStandardDeviation.Name = "lblPoissonStandardDeviation";
            this.lblPoissonStandardDeviation.Size = new System.Drawing.Size(105, 13);
            this.lblPoissonStandardDeviation.TabIndex = 15;
            this.lblPoissonStandardDeviation.Text = "Standard deviation: -";
            // 
            // lblExponentialStandardDeviation
            // 
            this.lblExponentialStandardDeviation.AutoSize = true;
            this.lblExponentialStandardDeviation.Location = new System.Drawing.Point(475, 116);
            this.lblExponentialStandardDeviation.Name = "lblExponentialStandardDeviation";
            this.lblExponentialStandardDeviation.Size = new System.Drawing.Size(105, 13);
            this.lblExponentialStandardDeviation.TabIndex = 19;
            this.lblExponentialStandardDeviation.Text = "Standard deviation: -";
            // 
            // lblExponentialVariance
            // 
            this.lblExponentialVariance.AutoSize = true;
            this.lblExponentialVariance.Location = new System.Drawing.Point(475, 90);
            this.lblExponentialVariance.Name = "lblExponentialVariance";
            this.lblExponentialVariance.Size = new System.Drawing.Size(58, 13);
            this.lblExponentialVariance.TabIndex = 17;
            this.lblExponentialVariance.Text = "Variance: -";
            // 
            // lblExponentialMean
            // 
            this.lblExponentialMean.AutoSize = true;
            this.lblExponentialMean.Location = new System.Drawing.Point(475, 66);
            this.lblExponentialMean.Name = "lblExponentialMean";
            this.lblExponentialMean.Size = new System.Drawing.Size(43, 13);
            this.lblExponentialMean.TabIndex = 18;
            this.lblExponentialMean.Text = "Mean: -";
            // 
            // lblExponential
            // 
            this.lblExponential.AutoSize = true;
            this.lblExponential.Location = new System.Drawing.Point(475, 41);
            this.lblExponential.Name = "lblExponential";
            this.lblExponential.Size = new System.Drawing.Size(65, 13);
            this.lblExponential.TabIndex = 16;
            this.lblExponential.Text = "Exponential:";
            // 
            // lblProbability
            // 
            this.lblProbability.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProbability.AutoSize = true;
            this.lblProbability.Location = new System.Drawing.Point(1132, 37);
            this.lblProbability.Name = "lblProbability";
            this.lblProbability.Size = new System.Drawing.Size(39, 13);
            this.lblProbability.TabIndex = 20;
            this.lblProbability.Text = "P(X=1)";
            // 
            // lblPoissonProbability
            // 
            this.lblPoissonProbability.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPoissonProbability.AutoSize = true;
            this.lblPoissonProbability.Location = new System.Drawing.Point(1084, 66);
            this.lblPoissonProbability.Name = "lblPoissonProbability";
            this.lblPoissonProbability.Size = new System.Drawing.Size(53, 13);
            this.lblPoissonProbability.TabIndex = 21;
            this.lblPoissonProbability.Text = "Poisson: -";
            // 
            // lblExponentialProbability
            // 
            this.lblExponentialProbability.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExponentialProbability.AutoSize = true;
            this.lblExponentialProbability.Location = new System.Drawing.Point(1084, 90);
            this.lblExponentialProbability.Name = "lblExponentialProbability";
            this.lblExponentialProbability.Size = new System.Drawing.Size(71, 13);
            this.lblExponentialProbability.TabIndex = 22;
            this.lblExponentialProbability.Text = "Exponential: -";
            // 
            // lblSimulationStandardDeviation
            // 
            this.lblSimulationStandardDeviation.AutoSize = true;
            this.lblSimulationStandardDeviation.Location = new System.Drawing.Point(759, 116);
            this.lblSimulationStandardDeviation.Name = "lblSimulationStandardDeviation";
            this.lblSimulationStandardDeviation.Size = new System.Drawing.Size(105, 13);
            this.lblSimulationStandardDeviation.TabIndex = 26;
            this.lblSimulationStandardDeviation.Text = "Standard deviation: -";
            // 
            // lblSimulationVariance
            // 
            this.lblSimulationVariance.AutoSize = true;
            this.lblSimulationVariance.Location = new System.Drawing.Point(759, 90);
            this.lblSimulationVariance.Name = "lblSimulationVariance";
            this.lblSimulationVariance.Size = new System.Drawing.Size(58, 13);
            this.lblSimulationVariance.TabIndex = 24;
            this.lblSimulationVariance.Text = "Variance: -";
            // 
            // lblSimulationMean
            // 
            this.lblSimulationMean.AutoSize = true;
            this.lblSimulationMean.Location = new System.Drawing.Point(759, 66);
            this.lblSimulationMean.Name = "lblSimulationMean";
            this.lblSimulationMean.Size = new System.Drawing.Size(43, 13);
            this.lblSimulationMean.TabIndex = 25;
            this.lblSimulationMean.Text = "Mean: -";
            // 
            // lblSimulation
            // 
            this.lblSimulation.AutoSize = true;
            this.lblSimulation.Location = new System.Drawing.Point(759, 41);
            this.lblSimulation.Name = "lblSimulation";
            this.lblSimulation.Size = new System.Drawing.Size(58, 13);
            this.lblSimulation.TabIndex = 23;
            this.lblSimulation.Text = "Simulation:";
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 997);
            this.Controls.Add(this.lblSimulationStandardDeviation);
            this.Controls.Add(this.lblSimulationVariance);
            this.Controls.Add(this.lblSimulationMean);
            this.Controls.Add(this.lblSimulation);
            this.Controls.Add(this.lblExponentialProbability);
            this.Controls.Add(this.lblPoissonProbability);
            this.Controls.Add(this.lblProbability);
            this.Controls.Add(this.lblExponentialStandardDeviation);
            this.Controls.Add(this.lblExponentialVariance);
            this.Controls.Add(this.lblExponentialMean);
            this.Controls.Add(this.lblExponential);
            this.Controls.Add(this.lblPoissonStandardDeviation);
            this.Controls.Add(this.lblPoissonVariance);
            this.Controls.Add(this.lblPoissonMean);
            this.Controls.Add(this.gbParameters);
            this.Controls.Add(this.pbGraph);
            this.Controls.Add(this.lblPoisson);
            this.Name = "MainInterface";
            this.Text = "Probability Distribution Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.pbGraph)).EndInit();
            this.gbParameters.ResumeLayout(false);
            this.gbParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownAverage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbGraph;
        private System.Windows.Forms.GroupBox gbParameters;
        private System.Windows.Forms.NumericUpDown nUpDownInterval;
        private System.Windows.Forms.NumericUpDown nUpDownAverage;
        private System.Windows.Forms.NumericUpDown nUpDownEvents;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblPoisson;
        private System.Windows.Forms.Label lblPoissonVariance;
        private System.Windows.Forms.Label lblPoissonMean;
        private System.Windows.Forms.Label lblPoissonStandardDeviation;
        private System.Windows.Forms.Label lblExponentialStandardDeviation;
        private System.Windows.Forms.Label lblExponentialVariance;
        private System.Windows.Forms.Label lblExponentialMean;
        private System.Windows.Forms.Label lblExponential;
        private System.Windows.Forms.Label lblProbability;
        private System.Windows.Forms.Label lblPoissonProbability;
        private System.Windows.Forms.Label lblExponentialProbability;
        private System.Windows.Forms.Label lblSimulationStandardDeviation;
        private System.Windows.Forms.Label lblSimulationVariance;
        private System.Windows.Forms.Label lblSimulationMean;
        private System.Windows.Forms.Label lblSimulation;
    }
}

