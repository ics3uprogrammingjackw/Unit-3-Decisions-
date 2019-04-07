/*
 * Created by: Jack Wright
 * Created on: 07-04-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #22 - Perfect Squares
 * This program determines whether a user input is a perfect square
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

namespace PerfectSquaresJackW
{
    public partial class frmPerfectSquares : Form
    {
        public frmPerfectSquares()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declare local variables
            int endingValue;
            int value = 1;
            Double squareRootAsDouble;
            int squareRootAsInteger;

            //Clear the listbox
            lstPerfectSquares.Items.Clear();

            // get the users end value from the numeric up down
            endingValue = Convert.ToInt32(this.numEndValue.Value);

            while (value <= endingValue)
            {
                // take the square root of the value
                squareRootAsDouble = Math.Sqrt(value);

                // convert the double to an integer
                squareRootAsInteger = Convert.ToInt32(squareRootAsDouble);
                 
                //Determine if its a perfect square 
                if (squareRootAsInteger == squareRootAsDouble)
                {
                    //tell the user that this number is a perfect square
                    this.lstPerfectSquares.Items.Add(value + " is a perfect square");
                }

                //Refresh the screen
                this.Refresh();

                // increment the value
                value = value + 1;
            }
        }
    }
}
