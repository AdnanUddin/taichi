﻿using System.Windows.Forms;
using System.Drawing;
namespace Computer_Prototype
{
    partial class TaichiFitness
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaichiFitness));
            this.tutorialButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.mainMenuTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.moveListPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonForm1 = new System.Windows.Forms.Button();
            this.buttonForm2 = new System.Windows.Forms.Button();
            this.buttonForm3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.button7 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelGameMode = new System.Windows.Forms.Label();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.pictureBoxKinectVideoStream = new System.Windows.Forms.PictureBox();
            this.videoTutorial = new AxWMPLib.AxWindowsMediaPlayer();
            this.highscorePanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.pictureBoxScore = new System.Windows.Forms.PictureBox();
            this.kinectTimer = new System.Windows.Forms.Timer(this.components);
            this.timerMoves = new System.Windows.Forms.Timer(this.components);
            this.label_kinectinfo = new System.Windows.Forms.Label();
            this.mainMenuTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainMenuPanel.SuspendLayout();
            this.moveListPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKinectVideoStream)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoTutorial)).BeginInit();
            this.highscorePanel.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScore)).BeginInit();
            this.SuspendLayout();
            // 
            // tutorialButton
            // 
            this.tutorialButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tutorialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorialButton.Location = new System.Drawing.Point(115, 345);
            this.tutorialButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tutorialButton.Name = "tutorialButton";
            this.tutorialButton.Size = new System.Drawing.Size(849, 80);
            this.tutorialButton.TabIndex = 0;
            this.tutorialButton.Text = "Learn How to Play";
            this.tutorialButton.UseVisualStyleBackColor = true;
            this.tutorialButton.Click += new System.EventHandler(this.startTutorial_Click);
            // 
            // playButton
            // 
            this.playButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(115, 453);
            this.playButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(849, 82);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play Game";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.play_Click);
            // 
            // quitButton
            // 
            this.quitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quitButton.BackColor = System.Drawing.Color.White;
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(115, 566);
            this.quitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(849, 82);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.exit_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.titleLabel.Location = new System.Drawing.Point(311, 0);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(458, 65);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Tai Chi Fitness";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // mainMenuTableLayout
            // 
            this.mainMenuTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainMenuTableLayout.AutoSize = true;
            this.mainMenuTableLayout.BackColor = System.Drawing.Color.Transparent;
            this.mainMenuTableLayout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainMenuTableLayout.BackgroundImage")));
            this.mainMenuTableLayout.ColumnCount = 1;
            this.mainMenuTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainMenuTableLayout.Controls.Add(this.titleLabel, 0, 0);
            this.mainMenuTableLayout.Controls.Add(this.tutorialButton, 0, 2);
            this.mainMenuTableLayout.Controls.Add(this.playButton, 0, 3);
            this.mainMenuTableLayout.Controls.Add(this.quitButton, 0, 4);
            this.mainMenuTableLayout.Controls.Add(this.pictureBox1, 0, 1);
            this.mainMenuTableLayout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuTableLayout.Location = new System.Drawing.Point(-20, -3);
            this.mainMenuTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.mainMenuTableLayout.Name = "mainMenuTableLayout";
            this.mainMenuTableLayout.RowCount = 5;
            this.mainMenuTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.26605F));
            this.mainMenuTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.73395F));
            this.mainMenuTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.mainMenuTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.mainMenuTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.mainMenuTableLayout.Size = new System.Drawing.Size(1080, 660);
            this.mainMenuTableLayout.TabIndex = 4;
            this.mainMenuTableLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.mainMenuTableLayout_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 70);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1072, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.Controls.Add(this.mainMenuTableLayout);
            this.mainMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.mainMenuPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(1051, 652);
            this.mainMenuPanel.TabIndex = 5;
            // 
            // moveListPanel
            // 
            this.moveListPanel.Controls.Add(this.tableLayoutPanel3);
            this.moveListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moveListPanel.Location = new System.Drawing.Point(0, 0);
            this.moveListPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.moveListPanel.Name = "moveListPanel";
            this.moveListPanel.Size = new System.Drawing.Size(1051, 652);
            this.moveListPanel.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel3.BackgroundImage")));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.48936F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.510638F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 482F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1051, 652);
            this.tableLayoutPanel3.TabIndex = 0;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.buttonForm1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonForm2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.buttonForm3, 0, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 143);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1042, 472);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // buttonForm1
            // 
            this.buttonForm1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForm1.Location = new System.Drawing.Point(210, 23);
            this.buttonForm1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonForm1.Name = "buttonForm1";
            this.buttonForm1.Size = new System.Drawing.Size(621, 117);
            this.buttonForm1.TabIndex = 0;
            this.buttonForm1.Text = "Commencing/Preparation";
            this.buttonForm1.UseVisualStyleBackColor = true;
            this.buttonForm1.Click += new System.EventHandler(this.startForm1_Click);
            // 
            // buttonForm2
            // 
            this.buttonForm2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForm2.Location = new System.Drawing.Point(210, 182);
            this.buttonForm2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonForm2.Name = "buttonForm2";
            this.buttonForm2.Size = new System.Drawing.Size(621, 125);
            this.buttonForm2.TabIndex = 1;
            this.buttonForm2.Text = "White Crane Spreads Wings";
            this.buttonForm2.UseVisualStyleBackColor = true;
            this.buttonForm2.Click += new System.EventHandler(this.startForm2_Click);
            // 
            // buttonForm3
            // 
            this.buttonForm3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonForm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForm3.Location = new System.Drawing.Point(210, 341);
            this.buttonForm3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonForm3.Name = "buttonForm3";
            this.buttonForm3.Size = new System.Drawing.Size(621, 116);
            this.buttonForm3.TabIndex = 2;
            this.buttonForm3.Text = "The Yang Style Rollout";
            this.buttonForm3.UseVisualStyleBackColor = true;
            this.buttonForm3.Click += new System.EventHandler(this.startForm3_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.09915F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.90085F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 359F));
            this.tableLayoutPanel5.Controls.Add(this.button7, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.button6, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1043, 117);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(710, 5);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(329, 107);
            this.button7.TabIndex = 2;
            this.button7.Text = "Shuffle";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.shuffle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(380, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 117);
            this.label5.TabIndex = 0;
            this.label5.Text = "List of Forms";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(4, 5);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(365, 107);
            this.button6.TabIndex = 1;
            this.button6.Text = "Back";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.backButton_Click);
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.tableLayoutPanel1);
            this.gamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePanel.Location = new System.Drawing.Point(0, 0);
            this.gamePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(1051, 652);
            this.gamePanel.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 558F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.videoTutorial, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1051, 652);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.labelGameMode, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonAbort, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxKinectVideoStream, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label_kinectinfo, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 493F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(485, 642);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // labelGameMode
            // 
            this.labelGameMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGameMode.AutoSize = true;
            this.labelGameMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameMode.Location = new System.Drawing.Point(12, 2);
            this.labelGameMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGameMode.Name = "labelGameMode";
            this.labelGameMode.Size = new System.Drawing.Size(461, 39);
            this.labelGameMode.TabIndex = 0;
            this.labelGameMode.Text = "Follow the avatar on the right";
            this.labelGameMode.Click += new System.EventHandler(this.labelGameMode_Click);
            // 
            // buttonAbort
            // 
            this.buttonAbort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAbort.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbort.Location = new System.Drawing.Point(3, 47);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonAbort.Size = new System.Drawing.Size(479, 78);
            this.buttonAbort.TabIndex = 1;
            this.buttonAbort.Text = "Abort Game ";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // pictureBoxKinectVideoStream
            // 
            this.pictureBoxKinectVideoStream.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxKinectVideoStream.Location = new System.Drawing.Point(3, 153);
            this.pictureBoxKinectVideoStream.Name = "pictureBoxKinectVideoStream";
            this.pictureBoxKinectVideoStream.Size = new System.Drawing.Size(479, 444);
            this.pictureBoxKinectVideoStream.TabIndex = 2;
            this.pictureBoxKinectVideoStream.TabStop = false;
            // 
            // videoTutorial
            // 
            this.videoTutorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoTutorial.Enabled = true;
            this.videoTutorial.Location = new System.Drawing.Point(497, 5);
            this.videoTutorial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.videoTutorial.Name = "videoTutorial";
            this.videoTutorial.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoTutorial.OcxState")));
            this.videoTutorial.Size = new System.Drawing.Size(550, 642);
            this.videoTutorial.TabIndex = 2;
            this.videoTutorial.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.videoTutorial_PlayStateChange);
            this.videoTutorial.EndOfStream += new AxWMPLib._WMPOCXEvents_EndOfStreamEventHandler(this.videoTutorial_EndOfStream);
            this.videoTutorial.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // highscorePanel
            // 
            this.highscorePanel.Controls.Add(this.tableLayoutPanel6);
            this.highscorePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.highscorePanel.Location = new System.Drawing.Point(0, 0);
            this.highscorePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.highscorePanel.Name = "highscorePanel";
            this.highscorePanel.Size = new System.Drawing.Size(1051, 652);
            this.highscorePanel.TabIndex = 7;
            this.highscorePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.highscorePanel_Paint);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel6.BackgroundImage")));
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 569F));
            this.tableLayoutPanel6.Controls.Add(this.button2, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.button1, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.labelScore, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.pictureBoxScore, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, -3);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.95918F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1080, 660);
            this.tableLayoutPanel6.TabIndex = 4;
            this.tableLayoutPanel6.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel6_Paint);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(548, 564);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(495, 74);
            this.button2.TabIndex = 3;
            this.button2.Text = "Back To Main Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.backButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(549, 460);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(492, 77);
            this.button1.TabIndex = 2;
            this.button1.Text = "Continue with next form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.nextForm_Click);
            // 
            // labelScore
            // 
            this.labelScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.White;
            this.labelScore.Location = new System.Drawing.Point(91, 377);
            this.labelScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(329, 73);
            this.labelScore.TabIndex = 0;
            this.labelScore.Text = "Good Job!";
            this.labelScore.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBoxScore
            // 
            this.pictureBoxScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxScore.Location = new System.Drawing.Point(4, 95);
            this.pictureBoxScore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxScore.Name = "pictureBoxScore";
            this.pictureBoxScore.Size = new System.Drawing.Size(503, 181);
            this.pictureBoxScore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxScore.TabIndex = 4;
            this.pictureBoxScore.TabStop = false;
            this.pictureBoxScore.Click += new System.EventHandler(this.pictureBoxScore_Click);
            // 
            // kinectTimer
            // 
            this.kinectTimer.Enabled = true;
            this.kinectTimer.Interval = 50;
            this.kinectTimer.Tick += new System.EventHandler(this.kinectVideoTimer_Tick);
            // 
            // timerMoves
            // 
            this.timerMoves.Tick += new System.EventHandler(this.timerMoves_Tick);
            // 
            // label_kinectinfo
            // 
            this.label_kinectinfo.AutoSize = true;
            this.label_kinectinfo.Location = new System.Drawing.Point(3, 622);
            this.label_kinectinfo.Name = "label_kinectinfo";
            this.label_kinectinfo.Size = new System.Drawing.Size(134, 20);
            this.label_kinectinfo.TabIndex = 3;
            this.label_kinectinfo.Text = "kinect information";
            // 
            // TaichiFitness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1051, 652);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.highscorePanel);
            this.Controls.Add(this.mainMenuPanel);
            this.Controls.Add(this.moveListPanel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TaichiFitness";
            this.Text = "Taichi Fitness";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaichiFitness_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainMenuTableLayout.ResumeLayout(false);
            this.mainMenuTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainMenuPanel.ResumeLayout(false);
            this.mainMenuPanel.PerformLayout();
            this.moveListPanel.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKinectVideoStream)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoTutorial)).EndInit();
            this.highscorePanel.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tutorialButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TableLayoutPanel mainMenuTableLayout;
        private System.Windows.Forms.Panel mainMenuPanel;
        private System.Windows.Forms.Panel highscorePanel;
        private System.Windows.Forms.Panel moveListPanel;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelGameMode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button buttonForm1;
        private System.Windows.Forms.Button buttonForm2;
        private System.Windows.Forms.Button buttonForm3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private AxWMPLib.AxWindowsMediaPlayer videoTutorial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PictureBox pictureBoxScore;
        private Button buttonAbort;
        private PictureBox pictureBoxKinectVideoStream;
        public Timer kinectTimer;
        private Timer timerMoves;
        private Label label_kinectinfo;
    }
}

