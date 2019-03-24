namespace ChocolateBoxesJackW
{
    partial class frmChocolateBoxes
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
            this.txtNumberof = new System.Windows.Forms.TextBox();
            this.lblBoxes = new System.Windows.Forms.Label();
            this.lblPrize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtNumberof
            // 
            this.txtNumberof.Location = new System.Drawing.Point(450, 118);
            this.txtNumberof.Name = "txtNumberof";
            this.txtNumberof.Size = new System.Drawing.Size(100, 20);
            this.txtNumberof.TabIndex = 2;
            this.txtNumberof.TextChanged += new System.EventHandler(this.txtNumberof_TextChanged);
            // 
            // lblBoxes
            // 
            this.lblBoxes.AutoSize = true;
            this.lblBoxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBoxes.Location = new System.Drawing.Point(225, 118);
            this.lblBoxes.Name = "lblBoxes";
            this.lblBoxes.Size = new System.Drawing.Size(219, 20);
            this.lblBoxes.TabIndex = 3;
            this.lblBoxes.Text = "How many boxes did you sell?";
            // 
            // lblPrize
            // 
            this.lblPrize.AutoSize = true;
            this.lblPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrize.Location = new System.Drawing.Point(387, 270);
            this.lblPrize.Name = "lblPrize";
            this.lblPrize.Size = new System.Drawing.Size(0, 20);
            this.lblPrize.TabIndex = 4;
            // 
            // frmChocolateBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPrize);
            this.Controls.Add(this.lblBoxes);
            this.Controls.Add(this.txtNumberof);
            this.Name = "frmChocolateBoxes";
            this.Text = "Chocolate Boxes by Jack W";
            this.Load += new System.EventHandler(this.frmChocolateBoxes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtNumberof;
        private System.Windows.Forms.Label lblBoxes;
        private System.Windows.Forms.Label lblPrize;
    }
}

