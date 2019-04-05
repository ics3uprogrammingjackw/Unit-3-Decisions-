namespace RockPapSciJackW
{
    partial class frmRockPaperScissors
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
            this.grbUserChoice = new System.Windows.Forms.GroupBox();
            this.radUserScissors = new System.Windows.Forms.RadioButton();
            this.radUserPaper = new System.Windows.Forms.RadioButton();
            this.radUserRock = new System.Windows.Forms.RadioButton();
            this.grbCompChoices = new System.Windows.Forms.GroupBox();
            this.radCompScissors = new System.Windows.Forms.RadioButton();
            this.radCompPaper = new System.Windows.Forms.RadioButton();
            this.radCompRock = new System.Windows.Forms.RadioButton();
            this.lblDecisions = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.grbUserChoice.SuspendLayout();
            this.grbCompChoices.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbUserChoice
            // 
            this.grbUserChoice.Controls.Add(this.radUserScissors);
            this.grbUserChoice.Controls.Add(this.radUserPaper);
            this.grbUserChoice.Controls.Add(this.radUserRock);
            this.grbUserChoice.Location = new System.Drawing.Point(77, 61);
            this.grbUserChoice.Name = "grbUserChoice";
            this.grbUserChoice.Size = new System.Drawing.Size(234, 213);
            this.grbUserChoice.TabIndex = 0;
            this.grbUserChoice.TabStop = false;
            this.grbUserChoice.Text = "User Choices";
            // 
            // radUserScissors
            // 
            this.radUserScissors.AutoSize = true;
            this.radUserScissors.Location = new System.Drawing.Point(27, 137);
            this.radUserScissors.Name = "radUserScissors";
            this.radUserScissors.Size = new System.Drawing.Size(64, 17);
            this.radUserScissors.TabIndex = 2;
            this.radUserScissors.TabStop = true;
            this.radUserScissors.Text = "Scissors";
            this.radUserScissors.UseVisualStyleBackColor = true;
            // 
            // radUserPaper
            // 
            this.radUserPaper.AutoSize = true;
            this.radUserPaper.Location = new System.Drawing.Point(27, 84);
            this.radUserPaper.Name = "radUserPaper";
            this.radUserPaper.Size = new System.Drawing.Size(53, 17);
            this.radUserPaper.TabIndex = 1;
            this.radUserPaper.TabStop = true;
            this.radUserPaper.Text = "Paper";
            this.radUserPaper.UseVisualStyleBackColor = true;
            // 
            // radUserRock
            // 
            this.radUserRock.AutoSize = true;
            this.radUserRock.Location = new System.Drawing.Point(27, 39);
            this.radUserRock.Name = "radUserRock";
            this.radUserRock.Size = new System.Drawing.Size(51, 17);
            this.radUserRock.TabIndex = 0;
            this.radUserRock.TabStop = true;
            this.radUserRock.Text = "Rock";
            this.radUserRock.UseVisualStyleBackColor = true;
            // 
            // grbCompChoices
            // 
            this.grbCompChoices.Controls.Add(this.radCompScissors);
            this.grbCompChoices.Controls.Add(this.radCompPaper);
            this.grbCompChoices.Controls.Add(this.radCompRock);
            this.grbCompChoices.Location = new System.Drawing.Point(77, 314);
            this.grbCompChoices.Name = "grbCompChoices";
            this.grbCompChoices.Size = new System.Drawing.Size(234, 253);
            this.grbCompChoices.TabIndex = 1;
            this.grbCompChoices.TabStop = false;
            this.grbCompChoices.Text = "Computer Choices";
            // 
            // radCompScissors
            // 
            this.radCompScissors.AutoSize = true;
            this.radCompScissors.Location = new System.Drawing.Point(49, 148);
            this.radCompScissors.Name = "radCompScissors";
            this.radCompScissors.Size = new System.Drawing.Size(64, 17);
            this.radCompScissors.TabIndex = 4;
            this.radCompScissors.TabStop = true;
            this.radCompScissors.Text = "Scissors";
            this.radCompScissors.UseVisualStyleBackColor = true;
            // 
            // radCompPaper
            // 
            this.radCompPaper.AutoSize = true;
            this.radCompPaper.Location = new System.Drawing.Point(49, 92);
            this.radCompPaper.Name = "radCompPaper";
            this.radCompPaper.Size = new System.Drawing.Size(53, 17);
            this.radCompPaper.TabIndex = 3;
            this.radCompPaper.TabStop = true;
            this.radCompPaper.Text = "Paper";
            this.radCompPaper.UseVisualStyleBackColor = true;
            // 
            // radCompRock
            // 
            this.radCompRock.AutoSize = true;
            this.radCompRock.Location = new System.Drawing.Point(49, 35);
            this.radCompRock.Name = "radCompRock";
            this.radCompRock.Size = new System.Drawing.Size(51, 17);
            this.radCompRock.TabIndex = 2;
            this.radCompRock.TabStop = true;
            this.radCompRock.Text = "Rock";
            this.radCompRock.UseVisualStyleBackColor = true;
            // 
            // lblDecisions
            // 
            this.lblDecisions.AutoSize = true;
            this.lblDecisions.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblDecisions.Location = new System.Drawing.Point(379, 283);
            this.lblDecisions.Name = "lblDecisions";
            this.lblDecisions.Size = new System.Drawing.Size(159, 29);
            this.lblDecisions.TabIndex = 2;
            this.lblDecisions.Text = "Who will win?";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(414, 331);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWinner.Location = new System.Drawing.Point(434, 410);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(0, 20);
            this.lblWinner.TabIndex = 4;
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 579);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblDecisions);
            this.Controls.Add(this.grbCompChoices);
            this.Controls.Add(this.grbUserChoice);
            this.Name = "frmRockPaperScissors";
            this.Text = "Rock Paper Scissors by Jack W";
            this.Load += new System.EventHandler(this.frmRockPaperScissors_Load);
            this.grbUserChoice.ResumeLayout(false);
            this.grbUserChoice.PerformLayout();
            this.grbCompChoices.ResumeLayout(false);
            this.grbCompChoices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUserChoice;
        private System.Windows.Forms.RadioButton radUserScissors;
        private System.Windows.Forms.RadioButton radUserPaper;
        private System.Windows.Forms.RadioButton radUserRock;
        private System.Windows.Forms.GroupBox grbCompChoices;
        private System.Windows.Forms.RadioButton radCompScissors;
        private System.Windows.Forms.RadioButton radCompPaper;
        private System.Windows.Forms.RadioButton radCompRock;
        private System.Windows.Forms.Label lblDecisions;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblWinner;
    }
}

