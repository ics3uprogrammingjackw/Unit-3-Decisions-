/*
 * Created by: Jack Wright
 * Created on: 02-04-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #24 - Unicode
 * This program converts capital letter A-Z into their hexadecimal value and lists the letter next to its value.
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

namespace UnicodeJackW
{
    public partial class frmUnicode : Form
    {
        public frmUnicode()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Declaring variables
            string uniLetter;
            int counter = 65;

            //Clears items on the list
            lstUnicode.Items.Clear();

            for(counter = 65; counter <= 90; counter++)
            {
                //Converts value into its respective letter
                uniLetter = Char.ConvertFromUtf32(counter);

                //Displays outcome in the listbox
                lstUnicode.Items.Add(uniLetter + "->" + counter);

            }
        }
    }
}
