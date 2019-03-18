namespace FactorDoWhileJackW
{
    partial class frmFactorDoWhile
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lstCounter = new System.Windows.Forms.ListBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblFactorQuestion = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(230, 26);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(96, 20);
            this.txtInput.TabIndex = 2;
            // 
            // lstCounter
            // 
            this.lstCounter.FormattingEnabled = true;
            this.lstCounter.Location = new System.Drawing.Point(165, 108);
            this.lstCounter.Name = "lstCounter";
            this.lstCounter.Size = new System.Drawing.Size(120, 134);
            this.lstCounter.TabIndex = 3;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAnswer.Location = new System.Drawing.Point(162, 288);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(18, 20);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Text = "?";
            // 
            // lblFactorQuestion
            // 
            this.lblFactorQuestion.AutoSize = true;
            this.lblFactorQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblFactorQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFactorQuestion.ForeColor = System.Drawing.Color.Black;
            this.lblFactorQuestion.Location = new System.Drawing.Point(40, 24);
            this.lblFactorQuestion.Name = "lblFactorQuestion";
            this.lblFactorQuestion.Size = new System.Drawing.Size(184, 20);
            this.lblFactorQuestion.TabIndex = 5;
            this.lblFactorQuestion.Text = "Calculate the factorial of:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCalculate.Location = new System.Drawing.Point(166, 64);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(101, 25);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmFactorDoWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 485);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblFactorQuestion);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lstCounter);
            this.Controls.Add(this.txtInput);
            this.Name = "frmFactorDoWhile";
            this.Text = "Factorial Do While by Jack W";
            this.Load += new System.EventHandler(this.frmFactorDoWhile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox lstCounter;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblFactorQuestion;
        private System.Windows.Forms.Button btnCalculate;
    }
}

