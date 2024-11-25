namespace Lab4
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
            // insertionSort
            // 
            this.insertionSort.Size = new System.Drawing.Size(101, 17);
            this.insertionSort.Tag = "randomquicksort";
            this.insertionSort.Text = "Rand QuickSort";
            // 
            // bubbleSort
            // 
            this.bubbleSort.Size = new System.Drawing.Size(75, 17);
            this.bubbleSort.Tag = "quicksort";
            this.bubbleSort.Text = "Quick Sort";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
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

