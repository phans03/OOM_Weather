namespace Weather_History2
{
    partial class Weatherdata2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.plotbutton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AFchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sunchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tempchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rainchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AFchart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunchart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempchart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainchart)).BeginInit();
            this.SuspendLayout();
            // 
            // plotbutton
            // 
            this.plotbutton.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plotbutton.Location = new System.Drawing.Point(43, 588);
            this.plotbutton.Name = "plotbutton";
            this.plotbutton.Size = new System.Drawing.Size(166, 43);
            this.plotbutton.TabIndex = 0;
            this.plotbutton.Text = "PLOT";
            this.plotbutton.UseVisualStyleBackColor = true;
            this.plotbutton.Click += new System.EventHandler(this.plotbutton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 1;
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
            chartArea5.Name = "ChartArea1";
            this.AFchart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.AFchart.Legends.Add(legend5);
            this.AFchart.Location = new System.Drawing.Point(28, 41);
            this.AFchart.Name = "AFchart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.AFchart.Series.Add(series5);
            this.AFchart.Size = new System.Drawing.Size(500, 250);
            this.AFchart.TabIndex = 2;
            this.AFchart.Text = "AFchart";
            // 
            // sunchart
            // 
            chartArea6.Name = "ChartArea1";
            this.sunchart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.sunchart.Legends.Add(legend6);
            this.sunchart.Location = new System.Drawing.Point(561, 309);
            this.sunchart.Name = "sunchart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.sunchart.Series.Add(series6);
            this.sunchart.Size = new System.Drawing.Size(500, 250);
            this.sunchart.TabIndex = 3;
            this.sunchart.Text = "sunchart";
            // 
            // tempchart
            // 
            chartArea7.Name = "ChartArea1";
            this.tempchart.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.tempchart.Legends.Add(legend7);
            this.tempchart.Location = new System.Drawing.Point(30, 310);
            this.tempchart.Name = "tempchart";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.tempchart.Series.Add(series7);
            this.tempchart.Size = new System.Drawing.Size(500, 250);
            this.tempchart.TabIndex = 4;
            this.tempchart.Text = "tempchart";
            // 
            // rainchart
            // 
            chartArea8.Name = "ChartArea1";
            this.rainchart.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.rainchart.Legends.Add(legend8);
            this.rainchart.Location = new System.Drawing.Point(560, 39);
            this.rainchart.Name = "rainchart";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.rainchart.Series.Add(series8);
            this.rainchart.Size = new System.Drawing.Size(500, 250);
            this.rainchart.TabIndex = 5;
            this.rainchart.Text = "rainchart";
            // 
            // Weatherdata2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.rainchart);
            this.Controls.Add(this.tempchart);
            this.Controls.Add(this.sunchart);
            this.Controls.Add(this.AFchart);
            this.Controls.Add(this.plotbutton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Weatherdata2";
            this.Text = "Weatherdata2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AFchart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunchart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempchart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainchart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plotbutton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart AFchart;
        private System.Windows.Forms.DataVisualization.Charting.Chart sunchart;
        private System.Windows.Forms.DataVisualization.Charting.Chart tempchart;
        private System.Windows.Forms.DataVisualization.Charting.Chart rainchart;
    }
}

