/*
 * Created by: Jack Wright
 * Created on: 15-04-19
 * Created for: ICS3U Programming
 * Daily Assignment – Day #31 - Percentage Program
 * This program calculates the percentage of an inputed grade level
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

namespace PercentageProgramJackW
{
    public partial class frmPercentageProgram : Form
    {
        public frmPercentageProgram()
        {
            InitializeComponent();
        }

        //Declares global percentage variable
        int percentage;

        private int CalculatePercentage(string level)
        {
            
            switch(level)
            {
                //Sets percentage to the mark that cooresponds with whatever grade level the user inputed
                case "4++":
                    percentage = 98;
                    break;
                case "4+":
                    percentage = 95;
                    break;
                case "4":
                    percentage = 87;
                    break;
                case "4-":
                    percentage = 83;
                    break;
                case "3+":
                    percentage = 78;
                    break;
                case "3":
                    percentage = 75;
                    break;
                case "3-":
                    percentage = 72;
                    break;
                case "2+":
                    percentage = 68;
                    break;
                case "2":
                    percentage = 65;
                    break;
                case "2-":
                    percentage = 62;
                    break;
                case "1+":
                    percentage = 58;
                    break;
                case "1":
                    percentage = 55;
                    break;
                case "1-":
                    percentage = 52;
                    break;
                case "0+":
                    percentage = 45;
                    break;
                case "0":
                    percentage = 40;
                    break;
                case "0-":
                    percentage = 35;
                    break;
                case "0--":
                    percentage = 30;
                    break;
                case "0---":
                    percentage = 20;
                    break;
                case "0----":
                    percentage = 10;
                    break;
                default:
                    percentage = -1;
                    break;
                    
            }
            //Returning percentage to the button procedure
            return (percentage);
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            //gets user input
            string level = txtMark.Text;

            //Declaring variables
            int mark;

            //Calling CalculatePercentage function
            mark = CalculatePercentage(level);

            //Displays percentage cooresponding to inputed grade level
            MessageBox.Show("The percentage of your mark is: " + mark + "%", "Percentage");
        }
    }
}
