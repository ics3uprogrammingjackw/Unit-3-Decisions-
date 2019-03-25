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

        Double userNumber;
        Double sumCounter;
        Double sumAnswer;

        private void txtSum_TextChanged(object sender, EventArgs e)
        {
            userNumber = Convert.ToDouble(txtSum);

            for (sumCounter = 1; sumCounter <= userNumber;)
            {




            }




        }
    }
}
