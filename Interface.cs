using GoldHunterAIGame.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GoldHunterAIGame
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        private void Interface_Load(object sender, EventArgs e)
        {
            btnStartGame.Parent = pictureBox1;
            btnAyarlar.Parent = pictureBox1;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            SettingsModel set = new SettingsModel();
            set.areaXSize = Convert.ToInt32(txtAreaX.Text);
            set.areaYSize = Convert.ToInt32(txtAreaY.Text);
            set.goldRate = Convert.ToInt32(txtGoldRate.Text);
            set.secretGoldRate = Convert.ToInt32(txtSecretRate.Text);
            set.playerTotalGold = Convert.ToInt32(txtStartingGold.Text);
            set.turnMoveMAX = Convert.ToInt32(txtStep.Text);

            set.findTargetCost[0] = Convert.ToInt32(txtTargetCostA.Text);
            set.turnCost[0] = Convert.ToInt32(txtMoveCostA.Text);
            set.findTargetCost[1] = Convert.ToInt32(txtTargetCostB.Text);
            set.turnCost[1] = Convert.ToInt32(txtMoveCostB.Text);
            set.findTargetCost[2] = Convert.ToInt32(txtTargetCostC.Text);
            set.turnCost[2] = Convert.ToInt32(txtMoveCostC.Text);
            set.findTargetCost[3] = Convert.ToInt32(txtTargetCostD.Text);
            set.turnCost[3] = Convert.ToInt32(txtMoveCostD.Text);

            Game newGame = new Game(this,set);
            newGame.Show();
            this.Hide();
        }

        private void btnStartGame_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pcr = (PictureBox)sender;
            pcr.Size = new Size(285, 75);
            if (pcr.AccessibleName == "1") pcr.Location = new Point(483, 352);
            else pcr.Location = new Point(483, 445);
        }

        private void btnStartGame_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pcr = (PictureBox)sender;
            pcr.Size = new Size(295, 85);
            if (pcr.AccessibleName == "1") pcr.Location = new Point(478, 347);
            else pcr.Location = new Point(478, 440);
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = false;
        }

        private void txtAreaX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}