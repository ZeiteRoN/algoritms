namespace Lab2
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
            this.arrayType.SuspendLayout();
            this.sortType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // bubbleSort
            // 
            this.bubbleSort.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bubbleSort.Size = new System.Drawing.Size(67, 20);
            this.bubbleSort.Tag = "merge";
            this.bubbleSort.Text = "Merge";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.richTextBox1.Size = new System.Drawing.Size(105, 229);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.richTextBox2.Size = new System.Drawing.Size(104, 229);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
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
    }
}