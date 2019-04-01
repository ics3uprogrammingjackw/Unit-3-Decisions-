namespace ControlObjectsJackW
{
    partial class frmControlObjects
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.lbJackW = new System.Windows.Forms.Label();
            this.lstColor = new System.Windows.Forms.ListBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(102, 104);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lbJackW
            // 
            this.lbJackW.AutoSize = true;
            this.lbJackW.Location = new System.Drawing.Point(45, 32);
            this.lbJackW.Name = "lbJackW";
            this.lbJackW.Size = new System.Drawing.Size(94, 13);
            this.lbJackW.TabIndex = 1;
            this.lbJackW.Text = "What is my name?";
            // 
            // lstColor
            // 
            this.lstColor.FormattingEnabled = true;
            this.lstColor.Location = new System.Drawing.Point(91, 154);
            this.lstColor.Name = "lstColor";
            this.lstColor.Size = new System.Drawing.Size(120, 95);
            this.lstColor.TabIndex = 2;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(91, 66);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 3;
            // 
            // frmControlObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lstColor);
            this.Controls.Add(this.lbJackW);
            this.Controls.Add(this.btnPlay);
            this.Name = "frmControlObjects";
            this.Text = "Control Objects by Jack W";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lbJackW;
        private System.Windows.Forms.ListBox lstColor;
        private System.Windows.Forms.TextBox txtColor;
    }
}

