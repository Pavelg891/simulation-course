namespace lab11
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonLaunch = new System.Windows.Forms.Button();
            this.labelHeight = new System.Windows.Forms.Label();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAngle = new System.Windows.Forms.NumericUpDown();
            this.labelAngle = new System.Windows.Forms.Label();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.numericUpDownSize = new System.Windows.Forms.NumericUpDown();
            this.labelSize = new System.Windows.Forms.Label();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numericUpDowndt = new System.Windows.Forms.NumericUpDown();
            this.labeldt = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Step = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Range = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxHeight1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FInalSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowndt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLaunch
            // 
            this.buttonLaunch.Location = new System.Drawing.Point(440, 13);
            this.buttonLaunch.Name = "buttonLaunch";
            this.buttonLaunch.Size = new System.Drawing.Size(75, 23);
            this.buttonLaunch.TabIndex = 0;
            this.buttonLaunch.Text = "Launch";
            this.buttonLaunch.UseVisualStyleBackColor = true;
            this.buttonLaunch.Click += new System.EventHandler(this.buttonLaunch_Click);
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(21, 15);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(49, 16);
            this.labelHeight.TabIndex = 2;
            this.labelHeight.Text = "Height:";
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(76, 13);
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownHeight.TabIndex = 3;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownAngle
            // 
            this.numericUpDownAngle.Location = new System.Drawing.Point(76, 41);
            this.numericUpDownAngle.Name = "numericUpDownAngle";
            this.numericUpDownAngle.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownAngle.TabIndex = 5;
            this.numericUpDownAngle.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // labelAngle
            // 
            this.labelAngle.AutoSize = true;
            this.labelAngle.Location = new System.Drawing.Point(21, 43);
            this.labelAngle.Name = "labelAngle";
            this.labelAngle.Size = new System.Drawing.Size(45, 16);
            this.labelAngle.TabIndex = 4;
            this.labelAngle.Text = "Angle:";
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(76, 69);
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownSpeed.TabIndex = 7;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(21, 71);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(51, 16);
            this.labelSpeed.TabIndex = 6;
            this.labelSpeed.Text = "Speed:";
            // 
            // numericUpDownSize
            // 
            this.numericUpDownSize.DecimalPlaces = 1;
            this.numericUpDownSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownSize.Location = new System.Drawing.Point(275, 13);
            this.numericUpDownSize.Name = "numericUpDownSize";
            this.numericUpDownSize.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownSize.TabIndex = 9;
            this.numericUpDownSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(220, 15);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(36, 16);
            this.labelSize.TabIndex = 8;
            this.labelSize.Text = "Size:";
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(275, 41);
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownWeight.TabIndex = 11;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(220, 43);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(52, 16);
            this.labelWeight.TabIndex = 10;
            this.labelWeight.Text = "Weight:";
            // 
            // chart1
            // 
            chartArea5.AxisX.Maximum = 100D;
            chartArea5.AxisX.Minimum = 0D;
            chartArea5.AxisY.Maximum = 20D;
            chartArea5.AxisY.Minimum = 0D;
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(24, 114);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(548, 300);
            this.chart1.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numericUpDowndt
            // 
            this.numericUpDowndt.DecimalPlaces = 4;
            this.numericUpDowndt.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDowndt.Location = new System.Drawing.Point(275, 69);
            this.numericUpDowndt.Name = "numericUpDowndt";
            this.numericUpDowndt.Size = new System.Drawing.Size(120, 22);
            this.numericUpDowndt.TabIndex = 14;
            this.numericUpDowndt.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // labeldt
            // 
            this.labeldt.AutoSize = true;
            this.labeldt.Location = new System.Drawing.Point(220, 71);
            this.labeldt.Name = "labeldt";
            this.labeldt.Size = new System.Drawing.Size(38, 16);
            this.labeldt.TabIndex = 13;
            this.labeldt.Text = "Step:";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(440, 43);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 15;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Step,
            this.Range,
            this.maxHeight1,
            this.FInalSpeed});
            this.dataGridView1.Location = new System.Drawing.Point(578, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(508, 300);
            this.dataGridView1.TabIndex = 16;
            // 
            // Step
            // 
            this.Step.HeaderText = "Step, s";
            this.Step.MinimumWidth = 6;
            this.Step.Name = "Step";
            this.Step.Width = 80;
            // 
            // Range
            // 
            this.Range.HeaderText = "Range, m";
            this.Range.MinimumWidth = 6;
            this.Range.Name = "Range";
            // 
            // maxHeight1
            // 
            this.maxHeight1.HeaderText = "Max Height, m";
            this.maxHeight1.MinimumWidth = 6;
            this.maxHeight1.Name = "maxHeight1";
            // 
            // FInalSpeed
            // 
            this.FInalSpeed.HeaderText = "Final Speed, m/s";
            this.FInalSpeed.MinimumWidth = 6;
            this.FInalSpeed.Name = "FInalSpeed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.numericUpDowndt);
            this.Controls.Add(this.labeldt);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.numericUpDownWeight);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.numericUpDownSize);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.numericUpDownSpeed);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.numericUpDownAngle);
            this.Controls.Add(this.labelAngle);
            this.Controls.Add(this.numericUpDownHeight);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.buttonLaunch);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowndt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLaunch;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownAngle;
        private System.Windows.Forms.Label labelAngle;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.NumericUpDown numericUpDownSize;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numericUpDowndt;
        private System.Windows.Forms.Label labeldt;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Step;
        private System.Windows.Forms.DataGridViewTextBoxColumn Range;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxHeight1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FInalSpeed;
    }
}

