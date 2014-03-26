﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Prototype
{
    public partial class TaichiFitness : Form
    {
        private static PictureBox kinectVideo;
        //Singleton VideoFeed for Kinect
        public static PictureBox KinectVideoInstance
        {
            get
            {
               return kinectVideo;
            }
        }
       
       // Cursor myCursor;
        Kinect kinect;
        public TaichiFitness()
        {
            InitializeComponent();
            FileIO fileIO = new FileIO();
            kinect = new Kinect(new Point(this.pictureBoxKinectVideoStream.Width, this.pictureBoxKinectVideoStream.Height));
            kinectVideo = this.pictureBoxKinectVideoStream;
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.mainMenuPanel.Show();
            this.moveListPanel.Hide();
            this.highscorePanel.Hide();
            this.gamePanel.Hide();
        }

        public void updateKinectVideoStream(Bitmap Videoframe)
        {
            ///this.pictureBoxKinectVideoStream.Image = this.kinect.kinectVideoBitmap;
        }
        private void play_Click(object sender, EventArgs e)
        {
            this.mainMenuPanel.Hide();
            this.moveListPanel.Show();
            this.highscorePanel.Hide();
            this.gamePanel.Hide();

        }
        private void exit_Click(object sender, EventArgs e)
        {
            // Play GoodBye
            //this.mainMenuTableLayout.Hide();

            DialogResult dialog = MessageBox.Show("Are you sure that you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                kinect.closeKinect();
                Application.ExitThread();
            }

        }

        private void highscorePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelGameMode.Text == this.buttonForm1.Text)
            {
                this.moveListPanel.Hide();
                this.mainMenuPanel.Hide();
                this.highscorePanel.Hide();
                this.gamePanel.Show();
                this.labelGameMode.Text = this.buttonForm2.Text;
                this.videoTutorial.URL = "./misc/preparation.wmv";
            }
            else if (labelGameMode.Text == this.buttonForm2.Text)
            {
                this.moveListPanel.Hide();
                this.mainMenuPanel.Hide();
                this.highscorePanel.Hide();
                this.gamePanel.Show();
                this.labelGameMode.Text = this.buttonForm3.Text;
                this.videoTutorial.URL = "./misc/preparation.wmv";
            }
            else if (labelGameMode.Text == this.buttonForm3.Text)
            {
                this.moveListPanel.Hide();
                this.mainMenuPanel.Hide();
                this.highscorePanel.Hide();
                this.gamePanel.Show();
                this.labelGameMode.Text = this.buttonForm1.Text;
                this.videoTutorial.URL = "./misc/preparation.wmv";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void startTutorial_Click(object sender, EventArgs e)
        {
            this.moveListPanel.Hide();
            this.mainMenuPanel.Hide();
            this.highscorePanel.Hide();
            this.gamePanel.Show();
            this.labelGameMode.Text = "Tutorial";
            //this.videoTutorial.settings.autoStart = false;
            this.videoTutorial.URL = "./misc/tutorial.wmv";
        }
        private void startForm1_Click(object sender, EventArgs e)
        {
            this.moveListPanel.Hide();
            this.mainMenuPanel.Hide();
            this.highscorePanel.Hide();
            this.gamePanel.Show();
            this.labelGameMode.Text = this.buttonForm1.Text;
            this.videoTutorial.URL = "./misc/preparation.wmv";
        }
        private void startForm2_Click(object sender, EventArgs e)
        {
            this.moveListPanel.Hide();
            this.mainMenuPanel.Hide();
            this.highscorePanel.Hide();
            this.gamePanel.Show();
            this.labelGameMode.Text = this.buttonForm2.Text;
            this.videoTutorial.URL = "./misc/preparation.wmv";
        }
        private void startForm3_Click(object sender, EventArgs e)
        {
            this.moveListPanel.Hide();
            this.mainMenuPanel.Hide();
            this.highscorePanel.Hide();
            this.gamePanel.Show();
            this.labelGameMode.Text = this.buttonForm3.Text;
            this.videoTutorial.URL = "./misc/preparation.wmv";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.moveListPanel.Hide();
            this.mainMenuPanel.Show();
            this.highscorePanel.Hide();
            this.gamePanel.Hide();
        }

        private void shuffle_Click(object sender, EventArgs e)
        {
            string temp = buttonForm1.Text;
            buttonForm1.Text = buttonForm2.Text;
            buttonForm2.Text = buttonForm3.Text;
            buttonForm3.Text = temp;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void videoTutorial_EndOfStream(object sender, AxWMPLib._WMPOCXEvents_EndOfStreamEvent e)
        {
            if (this.labelGameMode.Text == "Tutorial")
            {
                this.moveListPanel.Hide();
                this.mainMenuPanel.Show();
                this.highscorePanel.Hide();
                this.gamePanel.Hide();
            }
            else
            {
                this.moveListPanel.Hide();
                this.mainMenuPanel.Hide();
                this.highscorePanel.Show();
                this.gamePanel.Hide();
            }

        }

        private void videoTutorial_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 1)
            {
                if (this.labelGameMode.Text == "Tutorial")
                {
                    this.moveListPanel.Hide();
                    this.mainMenuPanel.Show();
                    this.highscorePanel.Hide();
                    this.gamePanel.Hide();
                }
                else
                {
                    this.moveListPanel.Hide();
                    this.mainMenuPanel.Hide();
                    this.highscorePanel.Show();
                    this.gamePanel.Hide();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mainMenuTableLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TaichiFitness_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Are you sure that you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.ExitThread();﻿
            }

            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void labelGameMode_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.moveListPanel.Hide();
            this.mainMenuPanel.Show();
            this.highscorePanel.Hide();
            this.gamePanel.Hide();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void kinectVideoTimer_Tick(object sender, EventArgs e)
        {
            this.pictureBoxKinectVideoStream.Image = kinect.updateKinect();            
        }

    }
}
