namespace Cellphone_Service
{
    partial class ChartForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartForm));
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChangeViewBtn = new System.Windows.Forms.Button();
            this.subscriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(22, 7);
            this.chart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series";
            series1.YValuesPerPoint = 2;
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(821, 596);
            this.chart.TabIndex = 0;
            title1.Name = "TitleForDoughtnut";
            title1.Text = "Subscription Services Distribution";
            this.chart.Titles.Add(title1);
            // 
            // ChangeViewBtn
            // 
            this.ChangeViewBtn.Location = new System.Drawing.Point(22, 612);
            this.ChangeViewBtn.Name = "ChangeViewBtn";
            this.ChangeViewBtn.Size = new System.Drawing.Size(821, 48);
            this.ChangeViewBtn.TabIndex = 1;
            this.ChangeViewBtn.Text = "Change View";
            this.ChangeViewBtn.UseVisualStyleBackColor = true;
            this.ChangeViewBtn.Click += new System.EventHandler(this.ChangeViewBtn_Click);
            // 
            // subscriptionBindingSource
            // 
            this.subscriptionBindingSource.DataSource = typeof(Cellphone_Service.Classes.Subscription);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 683);
            this.Controls.Add(this.ChangeViewBtn);
            this.Controls.Add(this.chart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ChartForm";
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.BindingSource subscriptionBindingSource;
        private System.Windows.Forms.Button ChangeViewBtn;
    }
}