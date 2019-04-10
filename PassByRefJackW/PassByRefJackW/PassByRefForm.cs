using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassByRefJackW
{
    public partial class frmPassByRef : Form
    {
        public frmPassByRef()
        {
            InitializeComponent();
        }

        private void Round(ref double number, int inputDecimal)
        {
            number = number * (10 ^ inputDecimal);

            number = number + 0.5;

            Math.Truncate(number);

            number = number / (10 ^ inputDecimal);

            MessageBox.Show("The rounded number is: " + number, "Rounded number");

        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(txtNumber.Text);
            int inputDecimal = Convert.ToInt32(nudDecimal.Value);

            Round(ref number, inputDecimal);
        }
    }
}
