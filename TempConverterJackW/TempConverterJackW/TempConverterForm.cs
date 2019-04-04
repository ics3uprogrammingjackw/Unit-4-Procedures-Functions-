/*
 * Created by: Jack Wright
 * Created on: 04-04-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Temperature Converter
 * This program calculates the temperature in Fahrenheit given a temp in Celsius
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

namespace TempConverterJackW
{
    public partial class frmTempConverter : Form
    {
        public frmTempConverter()
        {
            InitializeComponent();
        }

        //Declaring variables
        Double userCel;
        double fahrenheit;

        private void ConvertToFar(double fahrenheit)
        {
            //Calculates temperature in fahrenheit
            fahrenheit = (userCel * 9 / 5) + 32;

            //Display the fahrenheit
            lblAnswer.Text = "The temperature in Fahrenheit is: " + fahrenheit + "°";

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Get user input
            userCel = Convert.ToDouble(txtCelsius.Text);

            //Calling calculation function
            this.ConvertToFar(fahrenheit);

        }
    }
}
