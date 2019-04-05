/*
 * Created by: Jack Wright
 * Created on: 25-02-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #18 - Rock Paper Scissors 
 * This program lets the user play a game of rock paper scissors against the computer.
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

namespace RockPapSciJackW
{
    public partial class frmRockPaperScissors : Form
    {
        //Declaring global constants
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 3;
        Random randomNumberGenerator;

        public frmRockPaperScissors()
        {
            InitializeComponent();

            //Creates the random number generator
            randomNumberGenerator = new Random();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            int playerChoice;
            int computerChoice;
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 3;
            if (radUserRock.Checked == true)
            {
                playerChoice = ROCK;
            }
            else if (radUserPaper.Checked == true)
            {
                playerChoice = PAPER;
            }
            else if (radUserScissors.Checked == true)
            {
                playerChoice = SCISSORS;
            }
            else
            {
                playerChoice = 0;
            }

            computerChoice = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

            if (computerChoice == ROCK)
            {
                this.radCompRock.Checked = true;
            }
            else if (computerChoice == PAPER)
            {
                this.radCompPaper.Checked = true;
            }
            else if (computerChoice == SCISSORS)
            {
                this.radCompScissors.Checked = true;
            }

            if (computerChoice == ROCK)
            {
                if (playerChoice == ROCK)
                {
                    lblWinner.Text = "Its a tie!";
                }
                else if (playerChoice == PAPER)
                {
                    lblWinner.Text = "You win";
                }

                else if (playerChoice == SCISSORS)
                {
                    lblWinner.Text = "You lose";
                }
            }

            if (computerChoice == PAPER)
            {
                if (playerChoice == PAPER)
                {
                    lblWinner.Text = "Its a tie!";
                }
                else if (playerChoice == SCISSORS)
                {
                    lblWinner.Text = "You win";
                }

                else if (playerChoice == ROCK)
                {
                    lblWinner.Text = "You lose";
                }
            }

            if (computerChoice == SCISSORS)
            {
                if (playerChoice == SCISSORS)
                {
                    lblWinner.Text = "Its a tie!";
                }
                else if (playerChoice == ROCK)
                {
                    lblWinner.Text = "You win";
                }

                else if (playerChoice == PAPER)
                {
                    lblWinner.Text = "You lose";
                }
            }


        }

        private void frmRockPaperScissors_Load(object sender, EventArgs e)
        {

        }
    }
}
