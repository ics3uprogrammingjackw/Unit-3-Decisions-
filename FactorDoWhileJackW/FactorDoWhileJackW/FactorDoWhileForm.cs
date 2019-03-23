using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorDoWhileJackW
{
    public partial class frmFactorDoWhile : Form
    {
        public frmFactorDoWhile()
        {
            InitializeComponent();
        }

        private void frmFactorDoWhile_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Double factorialAnswer;
            Double factorialNumber;
            Double factorialCounter;

            lstCounter.Items.Clear();

            factorialAnswer = 1;

            factorialNumber = Convert.ToDouble(txtInput.Text);

            factorialCounter = 0;

            do
            {

                factorialCounter = factorialCounter + 1;

                lstCounter.Items.Add(factorialCounter);

                factorialAnswer = factorialCounter * factorialAnswer;



            } while (factorialCounter != factorialNumber);

            lblAnswer.Text = txtInput.Text + "! = " + Convert.ToString(factorialAnswer);


        }
    }
}
