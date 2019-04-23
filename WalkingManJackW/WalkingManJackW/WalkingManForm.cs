/*

 * Created by: Jack Wright

 * Created on: March 25th 2019

 * Created for: ICS3U Programming

 * Daily Assignment – Day #21 - Walking Man

 * This program displays a man walking 

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

        private void GeneratePictureBox(int x, int y)
        {
            PictureBox tmpPicMan = new PictureBox();
            Point pntPic = new System.Drawing.Point(x, y);

            tmpPicMan.Location = pntPic;

            tmpPicMan.Image = Properties.Resources.walk1;

            tmpPicMan.SizeMode = PictureBoxSizeMode.StretchImage;

            tmpPicMan.ClientSize = new Size(Properties.Resources.walk1.Width, Properties.Resources.walk1.Height);

            tmpPicMan.Click += new System.EventHandler(PictureBox_Click);

            this.Controls.Add(tmpPicMan);
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox tmpPicMan = (PictureBox)sender;

            Console.WriteLine("Picture box (" + tmpPicMan.Location.X + ", " + tmpPicMan.Location.Y + ") was clicked.");

            //Declare local variables

            const byte MAX_FRAMES = 10;

            int pictureFrameCounter = 1;



            //Continue the loop while the frame counter has not reached the max number of frames

            while (pictureFrameCounter < MAX_FRAMES + 1)
            {

                if (pictureFrameCounter == 1)
                {

                    this.picWalkingMan.Image = Properties.Resources.walk1;

                }



                else if (pictureFrameCounter == 2)
                {

                    this.picWalkingMan.Image = Properties.Resources.walk2;

                }



                else if (pictureFrameCounter == 3)
                {

                    this.picWalkingMan.Image = Properties.Resources.walk3;

                }



                else if (pictureFrameCounter == 4)
                {

                    this.picWalkingMan.Image = Properties.Resources.walk4;

                }



                else if (pictureFrameCounter == 5)
                {

                    this.picWalkingMan.Image = Properties.Resources.walk5;

                }



                else if (pictureFrameCounter == 6)
                {

                    this.picWalkingMan.Image = Properties.Resources.walk6;

                }



                else if (pictureFrameCounter == 7)
                {

                    this.picWalkingMan.Image = Properties.Resources.walk7;

                }



                else if (pictureFrameCounter == 8)
                {

                    this.picWalkingMan.Image = Properties.Resources.walk8;

                }



                else if (pictureFrameCounter == 9)
                {

                    this.picWalkingMan.Image = Properties.Resources.walk9;

                }



                else if (pictureFrameCounter == 10)
                {

                    this.picWalkingMan.Image = Properties.Resources.walk10;

                }



                //Increment the counter

                pictureFrameCounter++;



                //Refresh the screen

                this.Refresh();



                //Pause the loop for 100 milliseconds 

                Thread.Sleep(100);

            }

            private void GeneratePictureBoxes()
            {
                GeneratePictureBox(12, 12);
                GeneratePictureBox(366, 12);
                GeneratePictureBox(366, 261);
                GeneratePictureBox(12, 261);


            }


            private void btnWalk_Click(object sender, EventArgs e)
            {
                GeneratePictureBoxes();

            

            }

            private void frmWalkingMan_Load(object sender, EventArgs e)
            {

            }
        }
    }
}
    

