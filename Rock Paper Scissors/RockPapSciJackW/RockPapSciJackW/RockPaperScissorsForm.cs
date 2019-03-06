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
        //Declaring global variables
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 10;
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


        }
    }
}
