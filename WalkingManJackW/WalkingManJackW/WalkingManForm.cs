/*
 * Created by: Jack Wright
 * Created on: April 25th 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Dynamic Picture Boxes
 * This program dynamically creates 4 picture boxes and displays a man walking when the picture box is clicked
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
using System.Threading;

namespace WalkingManJackW
{
    public partial class frmWalkingMan : Form
    {
        public frmWalkingMan()
        {
            InitializeComponent();
        }

        private void picWalkingMan_Click(object sender, EventArgs e)
        {

        }

        private void frmWalkingMan_Load(object sender, EventArgs e)
        {
            lblInstructions.Hide();
        }



        private void GeneratePictureBox(int x, int y)
        {
            //Creating the picture boxes with their respective location
            PictureBox tmpPicMan = new PictureBox();
            Point pntPic = new System.Drawing.Point(x, y);

            //Setting the picture box location to the generated point
            tmpPicMan.Location = pntPic;

            //Setting the original image for the picture box
            tmpPicMan.Image = Properties.Resources.walk1;

            //Stretching the image to the size of the picture box
            tmpPicMan.SizeMode = PictureBoxSizeMode.StretchImage;

            //Making the width and height of the picture box the same as the image
            tmpPicMan.ClientSize = new Size(Properties.Resources.walk1.Width, Properties.Resources.walk1.Height);

            //Adding the event listener for when the picture box is clicked
            tmpPicMan.Click += new System.EventHandler(PictureBox_Click);

            //Adding the picture box to the form 
            this.Controls.Add(tmpPicMan);
        }

        public void GeneratePictureBoxes()
        {
            //Calling the GeneratePictureBox function and passing it an x and y coordinate
            GeneratePictureBox(12, 12);
            GeneratePictureBox(366, 12);
            GeneratePictureBox(366, 261);
            GeneratePictureBox(12, 261);
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            //Cast the sender object into a picture box
            PictureBox tmpPicMan = (PictureBox)sender;

            //Declare local variables
            const byte MAX_FRAMES = 10;

            //Creating the counter
            int pictureFrameCounter = 1;



            //Continue the loop while the frame counter has not reached the max number of frames
            while (pictureFrameCounter < MAX_FRAMES + 1)
            {

                if (pictureFrameCounter == 1)
                {
                    //Setting the picture box to the image that cooresponds with what the counter is at
                    tmpPicMan.Image = Properties.Resources.walk1;

                }



                else if (pictureFrameCounter == 2)
                {
                    //Setting the picture box to the image that cooresponds with what the counter is at
                    tmpPicMan.Image = Properties.Resources.walk2;

                }



                else if (pictureFrameCounter == 3)
                {
                    //Setting the picture box to the image that cooresponds with what the counter is at
                    tmpPicMan.Image = Properties.Resources.walk3;

                }



                else if (pictureFrameCounter == 4)
                {
                    //Setting the picture box to the image that cooresponds with what the counter is at
                    tmpPicMan.Image = Properties.Resources.walk4;

                }



                else if (pictureFrameCounter == 5)
                {
                    //Setting the picture box to the image that cooresponds with what the counter is at
                    tmpPicMan.Image = Properties.Resources.walk5;

                }

                else if (pictureFrameCounter == 6)
                {
                    //Setting the picture box to the image that cooresponds with what the counter is at
                    tmpPicMan.Image = Properties.Resources.walk6;

                }

                else if (pictureFrameCounter == 7)
                {
                    //Setting the picture box to the image that cooresponds with what the counter is at
                    tmpPicMan.Image = Properties.Resources.walk7;

                }

                else if (pictureFrameCounter == 8)
                {
                    //Setting the picture box to the image that cooresponds with what the counter is at
                    tmpPicMan.Image = Properties.Resources.walk8;

                }

                else if (pictureFrameCounter == 9)
                {
                    //Setting the picture box to the image that cooresponds with what the counter is at
                    tmpPicMan.Image = Properties.Resources.walk9;

                }

                else if (pictureFrameCounter == 10)
                {
                    //Setting the picture box to the image that cooresponds with what the counter is at
                    tmpPicMan.Image = Properties.Resources.walk10;

                }

                //Increment the counter
                pictureFrameCounter++;

                //Refresh the screen
                this.Refresh();

                //Pause the loop for 100 milliseconds 
                Thread.Sleep(100);
            }

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //Shows the instructions
            lblInstructions.Show();

            //Calling the function to create the picture boxes
            GeneratePictureBoxes();
        }

        
    }
}
    

