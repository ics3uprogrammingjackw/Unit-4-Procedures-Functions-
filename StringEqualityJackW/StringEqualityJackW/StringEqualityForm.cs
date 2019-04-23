/*
 * Created by: Jack Wright
 * Created on: 23-04-19
 * Created for: ICS3U Programming
 * Daily Assignment – Day #35 - String Equality
 * This program determines whether or not two stings are equal to each other by converting each of them to the same case
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

namespace StringEqualityJackW
{
    public partial class frmStringEquality : Form
    {
        public frmStringEquality()
        {
            InitializeComponent();
        }

        private bool StringsAreEqual(string case1, string case2)
        {
            //Creating boolean variable
            bool isEqual;

            //Determines whether the two strings are equal in length
            if (case1.Length == case2.Length)
            {
                //Converting strings to upper case
                case1 = case1.ToUpper();
                case2 = case2.ToUpper();

                if (case1 == case2)
                {
                    //If both strings are equal to each other the boolean variable is true 
                    isEqual = true; 
                }
                else
                {
                    //If both strings are not equal to each other the boolean variable is false
                    isEqual = false;
                }
            }
            else
            {
                //If the length is not equal the boolean variable is false
                isEqual = false;
            }
            //Returns the boolean variable
            return isEqual;
            
        }



        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Creates the boolean variable
            bool isEqual;

            //Collecting the two strings 
            string case1 = Convert.ToString(txtString1.Text);
            string case2 = Convert.ToString(txtString2.Text);

            //Calls the StringsAreEqual function
            isEqual = StringsAreEqual(case1, case2);

            //Checks if the boolean is true or false
            if (isEqual == true)
            {
                //Displays that the two strings are equal
                MessageBox.Show("These two strings are equal", "String Equality");
            }
            else
            {
                //Diisplays that the two strings are not equal
                MessageBox.Show("These two strings are not equal", "String Equality");
            }
        }
    }
}
