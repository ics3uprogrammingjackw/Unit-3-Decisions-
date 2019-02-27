/*
     * Created by: Jack Wright
     * Created on: 27-2-19
     * Created for: ICS3U Programming
     * Daily Assignment – Day #16 - Number Guessing Game
     * This program makes the user select a number  and tells them whether their guess was correct or incorrect.
    */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumGuessJackW
{
    public partial class frmNumGuess : Form
    {
        const double number = 6;
        double guess;
       
        public frmNumGuess()
        {
            InitializeComponent();
        }

        private void frmNumGuess_Load(object sender, EventArgs e)
        {
            picCheckmarkX.Hide();
        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {
            picCheckmarkX.Hide();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            guess = Convert.ToDouble(txtGuess.Text);
            if (guess == number)
            {
                this.picCheckmarkX.Image = Properties.Resources.checkmark;
                picCheckmarkX.Show();
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Correct Answer Sound Effect.mp3");
                player.Play();
            }

            else
            {
                this.picCheckmarkX.Image = Properties.Resources.red_x;
                picCheckmarkX.Show();
            }



        }
    }
}
