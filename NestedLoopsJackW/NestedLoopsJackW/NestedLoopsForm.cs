/*
 * Created by: Jack Wright
 * Created on: 03-04-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #28 - Alphabet Nested Loops
 * This program uses nested loops to show conversions of capital letters to lowercase letters
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

namespace NestedLoopsJackW
{
    public partial class frmNestedLoops : Form
    {
        public frmNestedLoops()
        {
            InitializeComponent();
        }

        private void frmNestedLoops_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Declaring variables
            string capital;
            string lowercase;
            int counter1;
            int counter2;

            //Clears items on the listbox
            lstAlphabet.Items.Clear();

            for(counter1 = 65; counter1 <= 90; counter1++)
            {
                //Convert counter to its respective letter in unicode
                capital = Char.ConvertFromUtf32(counter1);

                

                for (counter2 = 97; counter2 <= 122; counter2++)
                {
                    ////Convert counter to its respective letter in unicode
                    lowercase = Char.ConvertFromUtf32(counter2);

                    //Displays converted letters in the listbox
                    lstAlphabet.Items.Add(capital + "-> " + lowercase);

                }

            }


        }
    }
}
