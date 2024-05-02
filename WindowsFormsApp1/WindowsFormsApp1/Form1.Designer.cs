
namespace WindowsFormsApp1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tBpath = new System.Windows.Forms.TextBox();
            this.btOpenFile = new System.Windows.Forms.Button();
            this.lBdata = new System.Windows.Forms.ListBox();
            this.FilterButton = new System.Windows.Forms.Button();
            this.WriteButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tBpath
            // 
            this.tBpath.Location = new System.Drawing.Point(12, 12);
            this.tBpath.Name = "tBpath";
            this.tBpath.ReadOnly = true;
            this.tBpath.Size = new System.Drawing.Size(388, 20);
            this.tBpath.TabIndex = 0;
            // 
            // btOpenFile
            // 
            this.btOpenFile.Location = new System.Drawing.Point(406, 10);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btOpenFile.TabIndex = 1;
            this.btOpenFile.Text = "Открыть";
            this.btOpenFile.UseVisualStyleBackColor = true;
            this.btOpenFile.Click += new System.EventHandler(this.btOpenFile_Click);
            // 
            // lBdata
            // 
            this.lBdata.FormattingEnabled = true;
            this.lBdata.Location = new System.Drawing.Point(12, 38);
            this.lBdata.Name = "lBdata";
            this.lBdata.Size = new System.Drawing.Size(469, 277);
            this.lBdata.TabIndex = 2;
            // 
            // FilterButton
            // 
            this.FilterButton.Enabled = false;
            this.FilterButton.Location = new System.Drawing.Point(12, 321);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(230, 23);
            this.FilterButton.TabIndex = 3;
            this.FilterButton.Text = "Фильтрация";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // WriteButton
            // 
            this.WriteButton.Enabled = false;
            this.WriteButton.Location = new System.Drawing.Point(251, 321);
            this.WriteButton.Name = "WriteButton";
            this.WriteButton.Size = new System.Drawing.Size(230, 23);
            this.WriteButton.TabIndex = 4;
            this.WriteButton.Text = "Построение графика";
            this.WriteButton.UseVisualStyleBackColor = true;
            this.WriteButton.Click += new System.EventHandler(this.WriteButton_Click);
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(12, 350);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(469, 215);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 577);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.WriteButton);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.lBdata);
            this.Controls.Add(this.btOpenFile);
            this.Controls.Add(this.tBpath);
            this.Name = "Form1";
            this.Text = "Лб5";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBpath;
        private System.Windows.Forms.Button btOpenFile;
        private System.Windows.Forms.ListBox lBdata;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button WriteButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

