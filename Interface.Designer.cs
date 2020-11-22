namespace GoldHunterAIGame
{
    partial class Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            this.btnAyarlar = new System.Windows.Forms.PictureBox();
            this.btnStartGame = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTargetCostD = new System.Windows.Forms.TextBox();
            this.txtTargetCostC = new System.Windows.Forms.TextBox();
            this.txtTargetCostB = new System.Windows.Forms.TextBox();
            this.txtTargetCostA = new System.Windows.Forms.TextBox();
            this.txtMoveCostD = new System.Windows.Forms.TextBox();
            this.txtMoveCostC = new System.Windows.Forms.TextBox();
            this.txtMoveCostB = new System.Windows.Forms.TextBox();
            this.txtMoveCostA = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtStartingGold = new System.Windows.Forms.TextBox();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSecretRate = new System.Windows.Forms.TextBox();
            this.txtGoldRate = new System.Windows.Forms.TextBox();
            this.txtAreaY = new System.Windows.Forms.TextBox();
            this.txtAreaX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnAyarlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.settingsPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.AccessibleName = "2";
            this.btnAyarlar.BackColor = System.Drawing.Color.Transparent;
            this.btnAyarlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAyarlar.Image = global::GoldHunterAIGame.Properties.Resources.btnAyarlar;
            this.btnAyarlar.Location = new System.Drawing.Point(483, 445);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(288, 68);
            this.btnAyarlar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAyarlar.TabIndex = 2;
            this.btnAyarlar.TabStop = false;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            this.btnAyarlar.MouseEnter += new System.EventHandler(this.btnStartGame_MouseEnter);
            this.btnAyarlar.MouseLeave += new System.EventHandler(this.btnStartGame_MouseLeave);
            // 
            // btnStartGame
            // 
            this.btnStartGame.AccessibleName = "1";
            this.btnStartGame.BackColor = System.Drawing.Color.Transparent;
            this.btnStartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartGame.Image = global::GoldHunterAIGame.Properties.Resources.btnPlay;
            this.btnStartGame.Location = new System.Drawing.Point(483, 352);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(285, 75);
            this.btnStartGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStartGame.TabIndex = 1;
            this.btnStartGame.TabStop = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            this.btnStartGame.MouseEnter += new System.EventHandler(this.btnStartGame_MouseEnter);
            this.btnStartGame.MouseLeave += new System.EventHandler(this.btnStartGame_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GoldHunterAIGame.Properties.Resources.InterfaceBG;
            this.pictureBox1.Location = new System.Drawing.Point(-32, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1267, 713);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.settingsPanel.Controls.Add(this.btnSaveSettings);
            this.settingsPanel.Controls.Add(this.groupBox3);
            this.settingsPanel.Controls.Add(this.groupBox2);
            this.settingsPanel.Controls.Add(this.groupBox1);
            this.settingsPanel.Location = new System.Drawing.Point(-5, 352);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(1240, 361);
            this.settingsPanel.TabIndex = 3;
            this.settingsPanel.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel11);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtTargetCostD);
            this.groupBox3.Controls.Add(this.txtTargetCostC);
            this.groupBox3.Controls.Add(this.txtTargetCostB);
            this.groupBox3.Controls.Add(this.txtTargetCostA);
            this.groupBox3.Controls.Add(this.txtMoveCostD);
            this.groupBox3.Controls.Add(this.txtMoveCostC);
            this.groupBox3.Controls.Add(this.txtMoveCostB);
            this.groupBox3.Controls.Add(this.txtMoveCostA);
            this.groupBox3.Controls.Add(this.panel10);
            this.groupBox3.Controls.Add(this.panel9);
            this.groupBox3.Controls.Add(this.panel8);
            this.groupBox3.Controls.Add(this.panel7);
            this.groupBox3.Controls.Add(this.panel6);
            this.groupBox3.Controls.Add(this.panel5);
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(650, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(578, 262);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Oyuncu Maliyet Ayarları";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Gray;
            this.panel11.Location = new System.Drawing.Point(15, 41);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(553, 2);
            this.panel11.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(17, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "Oyuncu Adı";
            // 
            // txtTargetCostD
            // 
            this.txtTargetCostD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTargetCostD.Location = new System.Drawing.Point(497, 184);
            this.txtTargetCostD.Name = "txtTargetCostD";
            this.txtTargetCostD.Size = new System.Drawing.Size(56, 26);
            this.txtTargetCostD.TabIndex = 28;
            this.txtTargetCostD.Text = "20";
            this.txtTargetCostD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTargetCostD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAreaX_KeyPress);
            // 
            // txtTargetCostC
            // 
            this.txtTargetCostC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTargetCostC.Location = new System.Drawing.Point(414, 184);
            this.txtTargetCostC.Name = "txtTargetCostC";
            this.txtTargetCostC.Size = new System.Drawing.Size(56, 26);
            this.txtTargetCostC.TabIndex = 27;
            this.txtTargetCostC.Text = "15";
            this.txtTargetCostC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTargetCostC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAreaX_KeyPress);
            // 
            // txtTargetCostB
            // 
            this.txtTargetCostB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTargetCostB.Location = new System.Drawing.Point(331, 184);
            this.txtTargetCostB.Name = "txtTargetCostB";
            this.txtTargetCostB.Size = new System.Drawing.Size(56, 26);
            this.txtTargetCostB.TabIndex = 26;
            this.txtTargetCostB.Text = "10";
            this.txtTargetCostB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTargetCostB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAreaX_KeyPress);
            // 
            // txtTargetCostA
            // 
            this.txtTargetCostA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTargetCostA.Location = new System.Drawing.Point(248, 184);
            this.txtTargetCostA.Name = "txtTargetCostA";
            this.txtTargetCostA.Size = new System.Drawing.Size(56, 26);
            this.txtTargetCostA.TabIndex = 25;
            this.txtTargetCostA.Text = "5";
            this.txtTargetCostA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTargetCostA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAreaX_KeyPress);
            // 
            // txtMoveCostD
            // 
            this.txtMoveCostD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMoveCostD.Location = new System.Drawing.Point(497, 124);
            this.txtMoveCostD.Name = "txtMoveCostD";
            this.txtMoveCostD.Size = new System.Drawing.Size(56, 26);
            this.txtMoveCostD.TabIndex = 24;
            this.txtMoveCostD.Text = "5";
            this.txtMoveCostD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMoveCostD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAreaX_KeyPress);
            // 
            // txtMoveCostC
            // 
            this.txtMoveCostC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMoveCostC.Location = new System.Drawing.Point(414, 124);
            this.txtMoveCostC.Name = "txtMoveCostC";
            this.txtMoveCostC.Size = new System.Drawing.Size(56, 26);
            this.txtMoveCostC.TabIndex = 23;
            this.txtMoveCostC.Text = "5";
            this.txtMoveCostC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMoveCostC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAreaX_KeyPress);
            // 
            // txtMoveCostB
            // 
            this.txtMoveCostB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMoveCostB.Location = new System.Drawing.Point(331, 124);
            this.txtMoveCostB.Name = "txtMoveCostB";
            this.txtMoveCostB.Size = new System.Drawing.Size(56, 26);
            this.txtMoveCostB.TabIndex = 22;
            this.txtMoveCostB.Text = "5";
            this.txtMoveCostB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMoveCostB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAreaX_KeyPress);
            // 
            // txtMoveCostA
            // 
            this.txtMoveCostA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMoveCostA.Location = new System.Drawing.Point(248, 124);
            this.txtMoveCostA.Name = "txtMoveCostA";
            this.txtMoveCostA.Size = new System.Drawing.Size(56, 26);
            this.txtMoveCostA.TabIndex = 11;
            this.txtMoveCostA.Text = "5";
            this.txtMoveCostA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMoveCostA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAreaX_KeyPress);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Gray;
            this.panel10.Location = new System.Drawing.Point(400, 43);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(2, 186);
            this.panel10.TabIndex = 21;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gray;
            this.panel9.Location = new System.Drawing.Point(317, 43);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(2, 186);
            this.panel9.TabIndex = 20;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.Location = new System.Drawing.Point(483, 42);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(2, 186);
            this.panel8.TabIndex = 19;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.Location = new System.Drawing.Point(566, 43);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(2, 186);
            this.panel7.TabIndex = 19;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Location = new System.Drawing.Point(234, 42);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(2, 186);
            this.panel6.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(15, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 186);
            this.panel5.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(15, 227);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(553, 2);
            this.panel4.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(15, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(553, 2);
            this.panel3.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(15, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 2);
            this.panel2.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(518, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "D";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(435, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "C";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(352, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "B";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(269, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(17, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Hedef Belirleme Maliyeti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(17, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Hamle Maliyeti";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtStartingGold);
            this.groupBox2.Controls.Add(this.txtStep);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(366, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 262);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Genel Oyuncu Ayarları";
            // 
            // txtStartingGold
            // 
            this.txtStartingGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStartingGold.Location = new System.Drawing.Point(95, 203);
            this.txtStartingGold.Name = "txtStartingGold";
            this.txtStartingGold.Size = new System.Drawing.Size(84, 26);
            this.txtStartingGold.TabIndex = 10;
            this.txtStartingGold.Text = "200";
            this.txtStartingGold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStartingGold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAreaX_KeyPress);
            // 
            // txtStep
            // 
            this.txtStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStep.Location = new System.Drawing.Point(95, 88);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(84, 26);
            this.txtStep.TabIndex = 9;
            this.txtStep.Text = "3";
            this.txtStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAreaX_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(69, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Başlangıç Altını";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(42, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Maksimum Adım Sayısı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSecretRate);
            this.groupBox1.Controls.Add(this.txtGoldRate);
            this.groupBox1.Controls.Add(this.txtAreaY);
            this.groupBox1.Controls.Add(this.txtAreaX);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 262);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oyun Alanı Ayarları";
            // 
            // txtSecretRate
            // 
            this.txtSecretRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSecretRate.Location = new System.Drawing.Point(215, 207);
            this.txtSecretRate.Name = "txtSecretRate";
            this.txtSecretRate.Size = new System.Drawing.Size(100, 26);
            this.txtSecretRate.TabIndex = 8;
            this.txtSecretRate.Text = "10";
            this.txtSecretRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSecretRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAreaX_KeyPress);
            // 
            // txtGoldRate
            // 
            this.txtGoldRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGoldRate.Location = new System.Drawing.Point(215, 151);
            this.txtGoldRate.Name = "txtGoldRate";
            this.txtGoldRate.Size = new System.Drawing.Size(100, 26);
            this.txtGoldRate.TabIndex = 7;
            this.txtGoldRate.Text = "20";
            this.txtGoldRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGoldRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAreaX_KeyPress);
            // 
            // txtAreaY
            // 
            this.txtAreaY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAreaY.Location = new System.Drawing.Point(215, 96);
            this.txtAreaY.Name = "txtAreaY";
            this.txtAreaY.Size = new System.Drawing.Size(100, 26);
            this.txtAreaY.TabIndex = 6;
            this.txtAreaY.Text = "20";
            this.txtAreaY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAreaY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAreaX_KeyPress);
            // 
            // txtAreaX
            // 
            this.txtAreaX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAreaX.Location = new System.Drawing.Point(215, 43);
            this.txtAreaX.Name = "txtAreaX";
            this.txtAreaX.Size = new System.Drawing.Size(100, 26);
            this.txtAreaX.TabIndex = 5;
            this.txtAreaX.Text = "20";
            this.txtAreaX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAreaX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAreaX_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(16, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gizli Altın Oranı (%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Altın Oranı (%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oyun Alanı Yüksekliği";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oyun Alanı Genişliği";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.BackColor = System.Drawing.Color.LightCyan;
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSaveSettings.Location = new System.Drawing.Point(488, 304);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(265, 35);
            this.btnSaveSettings.TabIndex = 5;
            this.btnSaveSettings.Text = "Kaydet";
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 711);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.btnAyarlar);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gold Hunter";
            this.Load += new System.EventHandler(this.Interface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAyarlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnStartGame;
        private System.Windows.Forms.PictureBox btnAyarlar;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtTargetCostD;
        private System.Windows.Forms.TextBox txtTargetCostC;
        private System.Windows.Forms.TextBox txtTargetCostB;
        private System.Windows.Forms.TextBox txtTargetCostA;
        private System.Windows.Forms.TextBox txtMoveCostD;
        private System.Windows.Forms.TextBox txtMoveCostC;
        private System.Windows.Forms.TextBox txtMoveCostB;
        private System.Windows.Forms.TextBox txtMoveCostA;
        private System.Windows.Forms.TextBox txtStartingGold;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.TextBox txtSecretRate;
        private System.Windows.Forms.TextBox txtGoldRate;
        private System.Windows.Forms.TextBox txtAreaY;
        private System.Windows.Forms.TextBox txtAreaX;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSaveSettings;
    }
}

