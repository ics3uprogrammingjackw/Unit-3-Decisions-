namespace SumOfNumbersJackW
{
    partial class frmSumOfNumbers
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblQuestion.Location = new System.Drawing.Point(25, 59);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(381, 20);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Enter a number you want the sum of to be calculated";
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(412, 59);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(100, 20);
            this.txtSum.TabIndex = 1;
            this.txtSum.TextChanged += new System.EventHandler(this.txtSum_TextChanged);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSum.Location = new System.Drawing.Point(266, 228);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(59, 20);
            this.lblSum.TabIndex = 2;
            this.lblSum.Text = "Sum = ";
            // 
            // frmSumOfNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 380);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.lblQuestion);
            this.Name = "frmSumOfNumbers";
            this.Text = "Sum of Numbers by Jack W";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label lblSum;
    }
}

