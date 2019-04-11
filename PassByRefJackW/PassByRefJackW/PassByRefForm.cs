/*
 * Created by: Jack Wright
 * Created on: 10-04-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #29 - Passing by reference
 * This program rounds an inputed number to the decimal place of the users choice
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
            //Multiply the input by 10 to the power of what decimal place it should be rounded by 
            number = number * (Math.Pow(10, inputDecimal));

            //Add 0.5 to the input
            number = number + 0.5;

            // Get rid of all the decimals left
            number = Math.Truncate(number);

            //Divides the input by 10 to the power of how many decimals it should be rounded by
            number = number / (Math.Pow(10, inputDecimal));

            //Displays the answer in the message box
            MessageBox.Show("The rounded number is: " + number, "Rounded number");

        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Gets user inputs of the number they want rounded and how many decimals it should be rounded by
            double number = Convert.ToDouble(txtNumber.Text);
            int inputDecimal = Convert.ToInt32(nudDecimal.Value);

            //Calls the Round function and passes the address of the number and how many decimals it should be rounded by 
            Round(ref number, inputDecimal);
        }
    }
}
