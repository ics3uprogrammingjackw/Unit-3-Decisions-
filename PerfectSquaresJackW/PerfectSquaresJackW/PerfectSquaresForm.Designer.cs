namespace PerfectSquaresJackW
{
    partial class frmPerfectSquares
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.numEndValue = new System.Windows.Forms.NumericUpDown();
            this.lstPerfectSquares = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numEndValue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(142, 47);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 40);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Start";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // numEndValue
            // 
            this.numEndValue.Location = new System.Drawing.Point(142, 128);
            this.numEndValue.Name = "numEndValue";
            this.numEndValue.Size = new System.Drawing.Size(120, 20);
            this.numEndValue.TabIndex = 1;
            // 
            // lstPerfectSquares
            // 
            this.lstPerfectSquares.FormattingEnabled = true;
            this.lstPerfectSquares.Location = new System.Drawing.Point(142, 188);
            this.lstPerfectSquares.Name = "lstPerfectSquares";
            this.lstPerfectSquares.Size = new System.Drawing.Size(120, 95);
            this.lstPerfectSquares.TabIndex = 2;
            // 
            // frmPerfectSquares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 406);
            this.Controls.Add(this.lstPerfectSquares);
            this.Controls.Add(this.numEndValue);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmPerfectSquares";
            this.Text = "Perfect Squares by Jack W";
            ((System.ComponentModel.ISupportInitialize)(this.numEndValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.NumericUpDown numEndValue;
        private System.Windows.Forms.ListBox lstPerfectSquares;
    }
}

