/*
     * Created by: Jack Wright
     * Created on: 27-2-19
     * Created for: ICS3U Programming
     * Daily Assignment – Day #17 - Random Number Guessing Game
     * This program generates a random number than makes the user select a number  and tells them whether their guess was correct or incorrect.
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
using System.Media;

namespace NumGuessJackW
{
    public partial class frmNumGuess : Form
    {
        //Declaring variables and constants
        double guess;
        Random randomNumberGenerator = new Random();
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 10;
        int correctNumber;

        public frmNumGuess()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //Hides play button
            btnPlay.Hide();

            //Hides checkmark if player got it right the last play
            picCheckmarkX.Hide();

            //Clears the textbox from previous play
            txtGuess.Text = "";

            //Generates the random number
            correctNumber = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

            //Enabling controls
            btnCheck.Show();
            lblQuestion.Show();
            txtGuess.Show();


        }

        private void frmNumGuess_Load(object sender, EventArgs e)
        {
            //Disabling controls until play is clicked
            picCheckmarkX.Hide();
            btnCheck.Hide();
            lblQuestion.Hide();
            txtGuess.Hide();
            btnPlay.Show();
        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {
            //Hides checkmark/x
            picCheckmarkX.Hide();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Gets user guess
            guess = Convert.ToDouble(txtGuess.Text);

            if (guess == correctNumber)
            {
                //Displays checkmark
                this.picCheckmarkX.Image = Properties.Resources.checkmark;
                picCheckmarkX.Show();

                //Plays correct sound
                SoundPlayer corrrect = new SoundPlayer(@"nice-work.wav");
                corrrect.Play();

                //Disables controls and displays play button
                btnCheck.Hide();
                lblQuestion.Hide();                
                btnPlay.Show();
            }

            else
            {
                //Displays x
                this.picCheckmarkX.Image = Properties.Resources.red_x;
                picCheckmarkX.Show();

                //Plays incorrect sound
                SoundPlayer incorrrect = new SoundPlayer(@"maybe-next-time.wav");
                incorrrect.Play();
            }



        }

        
    }
}
