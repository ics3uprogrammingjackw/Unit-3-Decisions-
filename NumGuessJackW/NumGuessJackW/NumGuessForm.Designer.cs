namespace NumGuessJackW
{
    partial class frmNumGuess
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
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.picCheckmarkX = new System.Windows.Forms.PictureBox();
            this.btnCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckmarkX)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblQuestion.Location = new System.Drawing.Point(12, 52);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(187, 15);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "PIck a number between 1 and 10";
            // 
            // txtGuess
            // 
            this.txtGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtGuess.Location = new System.Drawing.Point(205, 49);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(71, 21);
            this.txtGuess.TabIndex = 1;
            this.txtGuess.TextChanged += new System.EventHandler(this.txtGuess_TextChanged);
            // 
            // picCheckmarkX
            // 
            this.picCheckmarkX.Image = global::NumGuessJackW.Properties.Resources.checkmark;
            this.picCheckmarkX.Location = new System.Drawing.Point(145, 172);
            this.picCheckmarkX.Name = "picCheckmarkX";
            this.picCheckmarkX.Size = new System.Drawing.Size(100, 50);
            this.picCheckmarkX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCheckmarkX.TabIndex = 2;
            this.picCheckmarkX.TabStop = false;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(15, 106);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(116, 39);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // frmNumGuess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.picCheckmarkX);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblQuestion);
            this.Name = "frmNumGuess";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmNumGuess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCheckmarkX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.PictureBox picCheckmarkX;
        private System.Windows.Forms.Button btnCheck;
    }
}

