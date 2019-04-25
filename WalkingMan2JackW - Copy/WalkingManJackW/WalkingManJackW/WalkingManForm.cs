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

            private void btnWalk_Click(object sender, EventArgs e)
            {
                GeneratePictureBoxes();
            }
        public void GeneratePictureBoxes()
        {
                GeneratePictureBox(12, 12);
                GeneratePictureBox(366, 12);
                GeneratePictureBox(366, 261);
                GeneratePictureBox(12, 261);


        }

        }

    }
}
    

