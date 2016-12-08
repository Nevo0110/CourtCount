namespace courtCount
{
    partial class mainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.smack = new System.Windows.Forms.Button();
            this.currentCount = new System.Windows.Forms.TextBox();
            this.displayAverage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.highscore = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // smack
            // 
            this.smack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.smack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smack.Location = new System.Drawing.Point(248, 27);
            this.smack.Name = "smack";
            this.smack.Size = new System.Drawing.Size(215, 89);
            this.smack.TabIndex = 0;
            this.smack.UseVisualStyleBackColor = true;
            this.smack.Click += new System.EventHandler(this.smack_Click);
            // 
            // currentCount
            // 
            this.currentCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.currentCount.Location = new System.Drawing.Point(302, 181);
            this.currentCount.Name = "currentCount";
            this.currentCount.ReadOnly = true;
            this.currentCount.Size = new System.Drawing.Size(106, 20);
            this.currentCount.TabIndex = 1;
            this.currentCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // displayAverage
            // 
            this.displayAverage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.displayAverage.Location = new System.Drawing.Point(302, 268);
            this.displayAverage.Name = "displayAverage";
            this.displayAverage.ReadOnly = true;
            this.displayAverage.Size = new System.Drawing.Size(106, 20);
            this.displayAverage.TabIndex = 2;
            this.displayAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Smacks";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Average Smacks";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 325);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Smacks";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(686, 161);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Blue",
            "Green",
            "Orange",
            "Purple",
            "Red",
            "Black",
            "Brown"});
            this.comboBox1.Location = new System.Drawing.Point(577, 267);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(608, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Graph Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(608, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Highscore";
            // 
            // highscore
            // 
            this.highscore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.highscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscore.ForeColor = System.Drawing.SystemColors.WindowText;
            this.highscore.Location = new System.Drawing.Point(577, 181);
            this.highscore.Name = "highscore";
            this.highscore.ReadOnly = true;
            this.highscore.Size = new System.Drawing.Size(121, 26);
            this.highscore.TabIndex = 9;
            this.highscore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 498);
            this.Controls.Add(this.highscore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayAverage);
            this.Controls.Add(this.currentCount);
            this.Controls.Add(this.smack);
            this.MinimumSize = new System.Drawing.Size(726, 537);
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.Text = "Court Count";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button smack;
        private System.Windows.Forms.TextBox currentCount;
        private System.Windows.Forms.TextBox displayAverage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox highscore;
    }
}

