namespace GoldHunterAIGame
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
            this.resultBox = new System.Windows.Forms.TextBox();
            this.MoveTimer = new System.Windows.Forms.Timer(this.components);
            this.TurnTimer = new System.Windows.Forms.Timer(this.components);
            this.playerD = new System.Windows.Forms.Button();
            this.playerC = new System.Windows.Forms.Button();
            this.playerB = new System.Windows.Forms.Button();
            this.playerA = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBoard
            // 
            this.pnlBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBoard.Location = new System.Drawing.Point(-1, 2);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(705, 719);
            this.pnlBoard.TabIndex = 0;
            this.pnlBoard.Resize += new System.EventHandler(this.pnlBoard_Resize);
            // 
            // resultBox
            // 
            this.resultBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resultBox.Location = new System.Drawing.Point(719, 80);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(465, 26);
            this.resultBox.TabIndex = 6;
            // 
            // MoveTimer
            // 
            this.MoveTimer.Interval = 200;
            this.MoveTimer.Tick += new System.EventHandler(this.MoveA_Tick);
            // 
            // TurnTimer
            // 
            this.TurnTimer.Tick += new System.EventHandler(this.TurnTimer_Tick);
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::GoldHunterAIGame.Properties.Resources.coal_mine_landscape_1308_17082;
            this.pictureBox1.Location = new System.Drawing.Point(312, 2);
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
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.playerD);
            this.Controls.Add(this.playerC);
            this.Controls.Add(this.playerB);
            this.Controls.Add(this.playerA);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Button playerA;
        private System.Windows.Forms.Button playerB;
        private System.Windows.Forms.Button playerC;
        private System.Windows.Forms.Button playerD;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Timer MoveTimer;
        private System.Windows.Forms.Timer TurnTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}