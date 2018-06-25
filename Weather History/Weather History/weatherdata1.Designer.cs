namespace Weather_History
{
    partial class WeatherReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea21 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend21 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea22 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend22 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea23 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend23 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea24 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend24 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AFchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tempchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rainchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sunchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.plotbutton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AFchart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempchart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainchart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunchart)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // AFchart
            // 
            chartArea21.Name = "ChartArea1";
            this.AFchart.ChartAreas.Add(chartArea21);
            legend21.Name = "Legend1";
            this.AFchart.Legends.Add(legend21);
            this.AFchart.Location = new System.Drawing.Point(25, 56);
            this.AFchart.Name = "AFchart";
            series21.ChartArea = "ChartArea1";
            series21.Legend = "Legend1";
            series21.Name = "Series1";
            this.AFchart.Series.Add(series21);
            this.AFchart.Size = new System.Drawing.Size(500, 250);
            this.AFchart.TabIndex = 1;
            this.AFchart.Text = "AFchart";
            // 
            // tempchart
            // 
            chartArea22.Name = "ChartArea1";
            this.tempchart.ChartAreas.Add(chartArea22);
            legend22.Name = "Legend1";
            this.tempchart.Legends.Add(legend22);
            this.tempchart.Location = new System.Drawing.Point(25, 341);
            this.tempchart.Name = "tempchart";
            series22.ChartArea = "ChartArea1";
            series22.Legend = "Legend1";
            series22.Name = "Series1";
            this.tempchart.Series.Add(series22);
            this.tempchart.Size = new System.Drawing.Size(500, 250);
            this.tempchart.TabIndex = 2;
            this.tempchart.Text = "tempchart";
            // 
            // rainchart
            // 
            chartArea23.Name = "ChartArea1";
            this.rainchart.ChartAreas.Add(chartArea23);
            legend23.Name = "Legend1";
            this.rainchart.Legends.Add(legend23);
            this.rainchart.Location = new System.Drawing.Point(562, 54);
            this.rainchart.Name = "rainchart";
            series23.ChartArea = "ChartArea1";
            series23.Legend = "Legend1";
            series23.Name = "Series1";
            this.rainchart.Series.Add(series23);
            this.rainchart.Size = new System.Drawing.Size(500, 250);
            this.rainchart.TabIndex = 3;
            this.rainchart.Text = "rainchart";
            // 
            // sunchart
            // 
            chartArea24.Name = "ChartArea1";
            this.sunchart.ChartAreas.Add(chartArea24);
            legend24.Name = "Legend1";
            this.sunchart.Legends.Add(legend24);
            this.sunchart.Location = new System.Drawing.Point(563, 341);
            this.sunchart.Name = "sunchart";
            series24.ChartArea = "ChartArea1";
            series24.Legend = "Legend1";
            series24.Name = "Series1";
            this.sunchart.Series.Add(series24);
            this.sunchart.Size = new System.Drawing.Size(500, 250);
            this.sunchart.TabIndex = 4;
            this.sunchart.Text = "sunchart";
            // 
            // plotbutton
            // 
            this.plotbutton.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plotbutton.Location = new System.Drawing.Point(31, 602);
            this.plotbutton.Name = "plotbutton";
            this.plotbutton.Size = new System.Drawing.Size(155, 45);
            this.plotbutton.TabIndex = 5;
            this.plotbutton.Text = "PLOT";
            this.plotbutton.UseVisualStyleBackColor = true;
            this.plotbutton.Click += new System.EventHandler(this.plotbutton_Click);
            // 
            // WeatherReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.plotbutton);
            this.Controls.Add(this.sunchart);
            this.Controls.Add(this.rainchart);
            this.Controls.Add(this.tempchart);
            this.Controls.Add(this.AFchart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WeatherReport";
            this.Text = "WeatherReport";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AFchart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempchart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainchart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunchart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart AFchart;
        private System.Windows.Forms.DataVisualization.Charting.Chart tempchart;
        private System.Windows.Forms.DataVisualization.Charting.Chart rainchart;
        private System.Windows.Forms.DataVisualization.Charting.Chart sunchart;
        private System.Windows.Forms.Button plotbutton;
    }
}

