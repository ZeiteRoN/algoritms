namespace algoritms
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.arrayType = new System.Windows.Forms.GroupBox();
            this.random = new System.Windows.Forms.RadioButton();
            this.descending = new System.Windows.Forms.RadioButton();
            this.rising = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.sortType = new System.Windows.Forms.GroupBox();
            this.insertionSort = new System.Windows.Forms.RadioButton();
            this.bubbleSort = new System.Windows.Forms.RadioButton();
            this.sortButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.research = new System.Windows.Forms.Button();
            this.arrayType.SuspendLayout();
            this.sortType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter range";
            // 
            // arrayType
            // 
            this.arrayType.Controls.Add(this.random);
            this.arrayType.Controls.Add(this.descending);
            this.arrayType.Controls.Add(this.rising);
            this.arrayType.Location = new System.Drawing.Point(29, 84);
            this.arrayType.Name = "arrayType";
            this.arrayType.Size = new System.Drawing.Size(87, 103);
            this.arrayType.TabIndex = 2;
            this.arrayType.TabStop = false;
            this.arrayType.Text = "Array Type";
            // 
            // random
            // 
            this.random.AutoSize = true;
            this.random.Location = new System.Drawing.Point(7, 68);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(65, 17);
            this.random.TabIndex = 2;
            this.random.TabStop = true;
            this.random.Text = "Random";
            this.random.UseVisualStyleBackColor = true;
            // 
            // descending
            // 
            this.descending.AutoSize = true;
            this.descending.Location = new System.Drawing.Point(7, 44);
            this.descending.Name = "descending";
            this.descending.Size = new System.Drawing.Size(48, 17);
            this.descending.TabIndex = 1;
            this.descending.TabStop = true;
            this.descending.Text = "N - 1";
            this.descending.UseVisualStyleBackColor = true;
            // 
            // rising
            // 
            this.rising.AutoSize = true;
            this.rising.Checked = true;
            this.rising.Location = new System.Drawing.Point(7, 20);
            this.rising.Name = "rising";
            this.rising.Size = new System.Drawing.Size(48, 17);
            this.rising.TabIndex = 0;
            this.rising.TabStop = true;
            this.rising.Text = "1 - N";
            this.rising.UseVisualStyleBackColor = true;
            this.rising.CheckedChanged += new System.EventHandler(this.rising_CheckedChanged);
            // 
            // sortType
            // 
            this.sortType.Controls.Add(this.insertionSort);
            this.sortType.Controls.Add(this.bubbleSort);
            this.sortType.Location = new System.Drawing.Point(154, 84);
            this.sortType.Name = "sortType";
            this.sortType.Size = new System.Drawing.Size(79, 103);
            this.sortType.TabIndex = 3;
            this.sortType.TabStop = false;
            this.sortType.Text = "Sort Type";
            // 
            // insertionSort
            // 
            this.insertionSort.AutoSize = true;
            this.insertionSort.Location = new System.Drawing.Point(7, 44);
            this.insertionSort.Name = "insertionSort";
            this.insertionSort.Size = new System.Drawing.Size(65, 17);
            this.insertionSort.TabIndex = 1;
            this.insertionSort.Tag = "insertion";
            this.insertionSort.Text = "Insertion";
            this.insertionSort.UseVisualStyleBackColor = true;
            // 
            // bubbleSort
            // 
            this.bubbleSort.AutoSize = true;
            this.bubbleSort.Checked = true;
            this.bubbleSort.Location = new System.Drawing.Point(7, 20);
            this.bubbleSort.Name = "bubbleSort";
            this.bubbleSort.Size = new System.Drawing.Size(58, 17);
            this.bubbleSort.TabIndex = 0;
            this.bubbleSort.TabStop = true;
            this.bubbleSort.Tag = "bubble";
            this.bubbleSort.Text = "Bubble";
            this.bubbleSort.UseVisualStyleBackColor = true;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(154, 394);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(75, 23);
            this.sortButton.TabIndex = 4;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(36, 208);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(80, 153);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(154, 208);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(79, 153);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(341, 31);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "BubbleSort";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "InsertionSort";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(345, 300);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // research
            // 
            this.research.Location = new System.Drawing.Point(341, 394);
            this.research.Name = "research";
            this.research.Size = new System.Drawing.Size(75, 23);
            this.research.TabIndex = 8;
            this.research.Text = "Research";
            this.research.UseVisualStyleBackColor = true;
            this.research.Click += new System.EventHandler(this.research_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.research);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.sortType);
            this.Controls.Add(this.arrayType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.arrayType.ResumeLayout(false);
            this.arrayType.PerformLayout();
            this.sortType.ResumeLayout(false);
            this.sortType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.TextBox textBox1;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.GroupBox arrayType;
        protected System.Windows.Forms.RadioButton random;
        protected System.Windows.Forms.RadioButton descending;
        protected System.Windows.Forms.RadioButton rising;
        protected System.ComponentModel.BackgroundWorker backgroundWorker1;
        protected System.Windows.Forms.GroupBox sortType;
        protected System.Windows.Forms.RadioButton insertionSort;
        protected System.Windows.Forms.RadioButton bubbleSort;
        protected System.Windows.Forms.Button sortButton;
        protected System.Windows.Forms.RichTextBox richTextBox1;
        protected System.Windows.Forms.RichTextBox richTextBox2;
        protected System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        protected System.Windows.Forms.Button research;
    }
}

