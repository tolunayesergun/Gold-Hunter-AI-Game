﻿namespace GoldHunterAIGame
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.textPlayerCCoin = new System.Windows.Forms.Label();
            this.textPlayerDCoin = new System.Windows.Forms.Label();
            this.textPlayerBCoin = new System.Windows.Forms.Label();
            this.textPlayerACoin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MoveTimer = new System.Windows.Forms.Timer(this.components);
            this.TurnTimer = new System.Windows.Forms.Timer(this.components);
            this.txtTimerSpeed = new System.Windows.Forms.Label();
            this.btnReplay = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.playerD = new System.Windows.Forms.Button();
            this.playerC = new System.Windows.Forms.Button();
            this.playerB = new System.Windows.Forms.Button();
            this.playerA = new System.Windows.Forms.Button();
            this.btnSpeedSlower = new System.Windows.Forms.PictureBox();
            this.btnPlayStop = new System.Windows.Forms.PictureBox();
            this.btnSpeedFaster = new System.Windows.Forms.PictureBox();
            this.goldCoin4 = new System.Windows.Forms.PictureBox();
            this.goldCoin3 = new System.Windows.Forms.PictureBox();
            this.goldCoin2 = new System.Windows.Forms.PictureBox();
            this.goldCoin1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSpeedSlower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlayStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSpeedFaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldCoin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldCoin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldCoin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldCoin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBoard
            // 
            this.pnlBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(25)))), ((int)(((byte)(12)))));
            this.pnlBoard.Controls.Add(this.btnSpeedSlower);
            this.pnlBoard.Controls.Add(this.btnPlayStop);
            this.pnlBoard.Controls.Add(this.btnSpeedFaster);
            this.pnlBoard.Controls.Add(this.textPlayerCCoin);
            this.pnlBoard.Controls.Add(this.textPlayerDCoin);
            this.pnlBoard.Controls.Add(this.txtTimerSpeed);
            this.pnlBoard.Controls.Add(this.goldCoin4);
            this.pnlBoard.Controls.Add(this.goldCoin3);
            this.pnlBoard.Controls.Add(this.textPlayerBCoin);
            this.pnlBoard.Controls.Add(this.goldCoin2);
            this.pnlBoard.Controls.Add(this.textPlayerACoin);
            this.pnlBoard.Controls.Add(this.goldCoin1);
            this.pnlBoard.Controls.Add(this.label5);
            this.pnlBoard.Controls.Add(this.label6);
            this.pnlBoard.Controls.Add(this.label7);
            this.pnlBoard.Controls.Add(this.label8);
            this.pnlBoard.Controls.Add(this.pictureBox2);
            this.pnlBoard.Location = new System.Drawing.Point(-1, 2);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(705, 719);
            this.pnlBoard.TabIndex = 0;
            this.pnlBoard.Resize += new System.EventHandler(this.pnlBoard_Resize);
            // 
            // textPlayerCCoin
            // 
            this.textPlayerCCoin.AutoSize = true;
            this.textPlayerCCoin.BackColor = System.Drawing.Color.Transparent;
            this.textPlayerCCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textPlayerCCoin.ForeColor = System.Drawing.Color.Gold;
            this.textPlayerCCoin.Location = new System.Drawing.Point(266, 167);
            this.textPlayerCCoin.Name = "textPlayerCCoin";
            this.textPlayerCCoin.Size = new System.Drawing.Size(43, 24);
            this.textPlayerCCoin.TabIndex = 10;
            this.textPlayerCCoin.Text = "200";
            // 
            // textPlayerDCoin
            // 
            this.textPlayerDCoin.AutoSize = true;
            this.textPlayerDCoin.BackColor = System.Drawing.Color.Transparent;
            this.textPlayerDCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textPlayerDCoin.ForeColor = System.Drawing.Color.Gold;
            this.textPlayerDCoin.Location = new System.Drawing.Point(361, 167);
            this.textPlayerDCoin.Name = "textPlayerDCoin";
            this.textPlayerDCoin.Size = new System.Drawing.Size(43, 24);
            this.textPlayerDCoin.TabIndex = 11;
            this.textPlayerDCoin.Text = "200";
            // 
            // textPlayerBCoin
            // 
            this.textPlayerBCoin.AutoSize = true;
            this.textPlayerBCoin.BackColor = System.Drawing.Color.Transparent;
            this.textPlayerBCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textPlayerBCoin.ForeColor = System.Drawing.Color.Gold;
            this.textPlayerBCoin.Location = new System.Drawing.Point(170, 167);
            this.textPlayerBCoin.Name = "textPlayerBCoin";
            this.textPlayerBCoin.Size = new System.Drawing.Size(43, 24);
            this.textPlayerBCoin.TabIndex = 9;
            this.textPlayerBCoin.Text = "200";
            // 
            // textPlayerACoin
            // 
            this.textPlayerACoin.AutoSize = true;
            this.textPlayerACoin.BackColor = System.Drawing.Color.Transparent;
            this.textPlayerACoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textPlayerACoin.ForeColor = System.Drawing.Color.Gold;
            this.textPlayerACoin.Location = new System.Drawing.Point(76, 167);
            this.textPlayerACoin.Name = "textPlayerACoin";
            this.textPlayerACoin.Size = new System.Drawing.Size(43, 24);
            this.textPlayerACoin.TabIndex = 8;
            this.textPlayerACoin.Text = "200";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(333, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Player D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(237, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Player C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(142, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Player B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Location = new System.Drawing.Point(46, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "Player A";
            // 
            // MoveTimer
            // 
            this.MoveTimer.Interval = 400;
            this.MoveTimer.Tick += new System.EventHandler(this.MoveA_Tick);
            // 
            // TurnTimer
            // 
            this.TurnTimer.Interval = 400;
            this.TurnTimer.Tick += new System.EventHandler(this.TurnTimer_Tick);
            // 
            // txtTimerSpeed
            // 
            this.txtTimerSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimerSpeed.BackColor = System.Drawing.Color.Transparent;
            this.txtTimerSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTimerSpeed.ForeColor = System.Drawing.Color.Gold;
            this.txtTimerSpeed.Location = new System.Drawing.Point(202, 312);
            this.txtTimerSpeed.Name = "txtTimerSpeed";
            this.txtTimerSpeed.Size = new System.Drawing.Size(71, 26);
            this.txtTimerSpeed.TabIndex = 20;
            this.txtTimerSpeed.Text = "1X";
            this.txtTimerSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReplay
            // 
            this.btnReplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReplay.BackColor = System.Drawing.SystemColors.Control;
            this.btnReplay.BackgroundImage = global::GoldHunterAIGame.Properties.Resources.btnReplay;
            this.btnReplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReplay.Location = new System.Drawing.Point(1131, 3);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(45, 45);
            this.btnReplay.TabIndex = 23;
            this.btnReplay.Tag = "";
            this.btnReplay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReplay.UseVisualStyleBackColor = false;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.BackColor = System.Drawing.SystemColors.Control;
            this.btnHome.BackgroundImage = global::GoldHunterAIGame.Properties.Resources.btnHome;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Location = new System.Drawing.Point(1182, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(45, 45);
            this.btnHome.TabIndex = 22;
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHomeClick);
            // 
            // playerD
            // 
            this.playerD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.playerD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playerD.BackgroundImage")));
            this.playerD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playerD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.playerD.ForeColor = System.Drawing.Color.White;
            this.playerD.Location = new System.Drawing.Point(878, 12);
            this.playerD.Name = "playerD";
            this.playerD.Size = new System.Drawing.Size(34, 36);
            this.playerD.TabIndex = 5;
            this.playerD.Text = "D";
            this.playerD.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.playerD.UseVisualStyleBackColor = false;
            // 
            // playerC
            // 
            this.playerC.BackColor = System.Drawing.Color.Crimson;
            this.playerC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playerC.BackgroundImage")));
            this.playerC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playerC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.playerC.ForeColor = System.Drawing.Color.White;
            this.playerC.Location = new System.Drawing.Point(838, 12);
            this.playerC.Name = "playerC";
            this.playerC.Size = new System.Drawing.Size(34, 36);
            this.playerC.TabIndex = 4;
            this.playerC.Text = "C";
            this.playerC.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.playerC.UseVisualStyleBackColor = false;
            // 
            // playerB
            // 
            this.playerB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.playerB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playerB.BackgroundImage")));
            this.playerB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.playerB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.playerB.Location = new System.Drawing.Point(798, 12);
            this.playerB.Name = "playerB";
            this.playerB.Size = new System.Drawing.Size(34, 36);
            this.playerB.TabIndex = 3;
            this.playerB.Text = "B";
            this.playerB.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.playerB.UseVisualStyleBackColor = false;
            // 
            // playerA
            // 
            this.playerA.BackColor = System.Drawing.Color.CornflowerBlue;
            this.playerA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playerA.BackgroundImage")));
            this.playerA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playerA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.playerA.ForeColor = System.Drawing.Color.White;
            this.playerA.Location = new System.Drawing.Point(758, 12);
            this.playerA.Name = "playerA";
            this.playerA.Size = new System.Drawing.Size(34, 36);
            this.playerA.TabIndex = 2;
            this.playerA.Text = "A";
            this.playerA.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.playerA.UseVisualStyleBackColor = false;
            // 
            // btnSpeedSlower
            // 
            this.btnSpeedSlower.AccessibleDescription = "1";
            this.btnSpeedSlower.Image = global::GoldHunterAIGame.Properties.Resources.buttonLeftSkip;
            this.btnSpeedSlower.Location = new System.Drawing.Point(142, 241);
            this.btnSpeedSlower.Name = "btnSpeedSlower";
            this.btnSpeedSlower.Size = new System.Drawing.Size(60, 60);
            this.btnSpeedSlower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSpeedSlower.TabIndex = 24;
            this.btnSpeedSlower.TabStop = false;
            this.btnSpeedSlower.Click += new System.EventHandler(this.speedSlower_Click);
            this.btnSpeedSlower.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnSpeedSlower.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnPlayStop
            // 
            this.btnPlayStop.AccessibleDescription = "2";
            this.btnPlayStop.Image = global::GoldHunterAIGame.Properties.Resources.playButton;
            this.btnPlayStop.Location = new System.Drawing.Point(209, 241);
            this.btnPlayStop.Name = "btnPlayStop";
            this.btnPlayStop.Size = new System.Drawing.Size(60, 60);
            this.btnPlayStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPlayStop.TabIndex = 23;
            this.btnPlayStop.TabStop = false;
            this.btnPlayStop.Click += new System.EventHandler(this.turnTimerControl_Click);
            this.btnPlayStop.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnPlayStop.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnSpeedFaster
            // 
            this.btnSpeedFaster.AccessibleDescription = "3";
            this.btnSpeedFaster.Image = global::GoldHunterAIGame.Properties.Resources.buttonSkip;
            this.btnSpeedFaster.Location = new System.Drawing.Point(275, 241);
            this.btnSpeedFaster.Name = "btnSpeedFaster";
            this.btnSpeedFaster.Size = new System.Drawing.Size(60, 60);
            this.btnSpeedFaster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSpeedFaster.TabIndex = 22;
            this.btnSpeedFaster.TabStop = false;
            this.btnSpeedFaster.Click += new System.EventHandler(this.speedFaster_Click);
            this.btnSpeedFaster.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnSpeedFaster.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // goldCoin4
            // 
            this.goldCoin4.Image = global::GoldHunterAIGame.Properties.Resources.goldCoin;
            this.goldCoin4.Location = new System.Drawing.Point(331, 163);
            this.goldCoin4.Name = "goldCoin4";
            this.goldCoin4.Size = new System.Drawing.Size(35, 29);
            this.goldCoin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goldCoin4.TabIndex = 19;
            this.goldCoin4.TabStop = false;
            // 
            // goldCoin3
            // 
            this.goldCoin3.Image = global::GoldHunterAIGame.Properties.Resources.goldCoin;
            this.goldCoin3.Location = new System.Drawing.Point(238, 163);
            this.goldCoin3.Name = "goldCoin3";
            this.goldCoin3.Size = new System.Drawing.Size(35, 29);
            this.goldCoin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goldCoin3.TabIndex = 18;
            this.goldCoin3.TabStop = false;
            // 
            // goldCoin2
            // 
            this.goldCoin2.Image = global::GoldHunterAIGame.Properties.Resources.goldCoin;
            this.goldCoin2.Location = new System.Drawing.Point(142, 163);
            this.goldCoin2.Name = "goldCoin2";
            this.goldCoin2.Size = new System.Drawing.Size(35, 29);
            this.goldCoin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goldCoin2.TabIndex = 17;
            this.goldCoin2.TabStop = false;
            // 
            // goldCoin1
            // 
            this.goldCoin1.Image = global::GoldHunterAIGame.Properties.Resources.goldCoin;
            this.goldCoin1.Location = new System.Drawing.Point(48, 163);
            this.goldCoin1.Name = "goldCoin1";
            this.goldCoin1.Size = new System.Drawing.Size(35, 29);
            this.goldCoin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goldCoin1.TabIndex = 16;
            this.goldCoin1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(406, 90);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(491, 384);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::GoldHunterAIGame.Properties.Resources.GameBG1;
            this.pictureBox1.Location = new System.Drawing.Point(316, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(925, 719);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 714);
            this.Controls.Add(this.btnReplay);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.playerD);
            this.Controls.Add(this.playerC);
            this.Controls.Add(this.playerB);
            this.Controls.Add(this.playerA);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gold Hunter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.Load += new System.EventHandler(this.Game_Load);
            this.pnlBoard.ResumeLayout(false);
            this.pnlBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSpeedSlower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlayStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSpeedFaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldCoin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldCoin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldCoin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldCoin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Button playerA;
        private System.Windows.Forms.Button playerB;
        private System.Windows.Forms.Button playerC;
        private System.Windows.Forms.Button playerD;
        private System.Windows.Forms.Timer MoveTimer;
        private System.Windows.Forms.Timer TurnTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label textPlayerACoin;
        private System.Windows.Forms.Label textPlayerDCoin;
        private System.Windows.Forms.Label textPlayerCCoin;
        private System.Windows.Forms.Label textPlayerBCoin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox goldCoin1;
        private System.Windows.Forms.PictureBox goldCoin4;
        private System.Windows.Forms.PictureBox goldCoin3;
        private System.Windows.Forms.PictureBox goldCoin2;
        private System.Windows.Forms.Label txtTimerSpeed;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnReplay;
        private System.Windows.Forms.PictureBox btnSpeedSlower;
        private System.Windows.Forms.PictureBox btnPlayStop;
        private System.Windows.Forms.PictureBox btnSpeedFaster;
    }
}