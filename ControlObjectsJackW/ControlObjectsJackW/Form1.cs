/*
 * Created by: Jack Wright
 * Created on: 01-04-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Control Objects
 * This program uses a for each loop to change properties of different objects
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

namespace ControlObjectsJackW
{
    public partial class frmControlObjects : Form
    {
        public frmControlObjects()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            foreach (Control aControlObject in this.Controls)
            {
                //Changes the color of the button and the textbox to red
                aControlObject.BackColor = Color.Red;

                if (aControlObject.GetType() == typeof(ListBox))
                {
                    //Changes the color of the listbox to green
                    aControlObject.BackColor = Color.Green;
                }

                if (aControlObject.GetType() == typeof(Label))
                {
                    //Sets the color of the label to transparent
                    aControlObject.BackColor = Color.Transparent;

                    //Changes the text of the label
                    aControlObject.Text = "My name is Jack Wright";
                }
            }
        }
    }
}
