/*
 * Created by: Jack Wright
 * Created on: 28-03-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #23 - Sum of Numbers
 * This program calculates the sum of a user inputted number
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

namespace SumOfNumbersJackW
{
    public partial class frmSumOfNumbers : Form
    {
        public frmSumOfNumbers()
        {
            InitializeComponent();
        }

        //Declaring variables
        Double userNumber;
        Double sumCounter;
        Double sumAnswer = 0;

        private void txtSum_TextChanged(object sender, EventArgs e)
        {
            //Gets user input
            userNumber = Convert.ToDouble(txtSum.Text);

            for (sumCounter = 1; sumCounter <= userNumber; sumCounter++)
            {
                //Calulates sum of number
                sumAnswer = sumAnswer + sumCounter;


            }

            //Displays answer
            lblSum.Text = Convert.ToString(sumAnswer);




        }
    }
}
