using GoldHunterAIGame.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GoldHunterAIGame
{
    public partial class ScoreBoard : Form
    {
        public ScoreBoard(List<Player> playerList)
        {
            InitializeComponent();
            _playerList = playerList;
        }

        private List<Player> _playerList = new List<Player>();

        private void ScoreBoard_Load(object sender, EventArgs e)
        {
            InstanceDock();

            Player playerA = _playerList.Where(p => p.playerdID == 1).SingleOrDefault();
            Player playerB = _playerList.Where(p => p.playerdID == 2).SingleOrDefault();
            Player playerC = _playerList.Where(p => p.playerdID == 3).SingleOrDefault();
            Player playerD = _playerList.Where(p => p.playerdID == 4).SingleOrDefault();

            WriteLabels(playerA, playerB, playerC, playerD);

            Player winnerPlayer = new Player();
            List<Player> tempList = _playerList.Where(p => p.stat == 5).ToList();
            if (tempList.Count() != 0)
            {
                winnerPlayer = tempList.Where(t => t.playerGold == tempList.Select(p => p.playerGold).Max()).FirstOrDefault();
            }
            else
            {
                winnerPlayer = _playerList.Where(p => p.stat == 1).SingleOrDefault();
            }

            winnerPlayerButton.Text = winnerPlayer.playerName;
            winnerPlayerButton.BackColor = (pictureBox1.Controls["btnPlayer" + winnerPlayer.playerName] as Button).BackColor;
            winnerPlayerButton.ForeColor = (pictureBox1.Controls["btnPlayer" + winnerPlayer.playerName] as Button).ForeColor;
        }

        private void WriteLabels(Player playerA, Player playerB, Player playerC, Player playerD)
        {
            txtStepPlayerA.Text = playerA.StepCount.ToString();
            txtStepPlayerB.Text = playerB.StepCount.ToString();
            txtStepPlayerC.Text = playerC.StepCount.ToString();
            txtStepPlayerD.Text = playerD.StepCount.ToString();

            txtSpendPlayerA.Text = playerA.spentGold.ToString();
            txtSpendPlayerB.Text = playerB.spentGold.ToString();
            txtSpendPlayerC.Text = playerC.spentGold.ToString();
            txtSpendPlayerD.Text = playerD.spentGold.ToString();

            txtRemainGoldA.Text = playerA.playerGold.ToString();
            txtRemainGoldB.Text = playerB.playerGold.ToString();
            txtRemainGoldC.Text = playerC.playerGold.ToString();
            txtRemainGoldD.Text = playerD.playerGold.ToString();

            txtCollectedGoldA.Text = playerA.collectedGold.ToString();
            txtCollectedGoldB.Text = playerB.collectedGold.ToString();
            txtCollectedGoldC.Text = playerC.collectedGold.ToString();
            txtCollectedGoldD.Text = playerD.collectedGold.ToString();
        }

        private void InstanceDock()
        {
            this.BackColor = Color.FromArgb(63, 25, 12);
            TransparencyKey = Color.FromArgb(63, 25, 12);

            btnPlayerA.Parent = pictureBox1;
            btnPlayerB.Parent = pictureBox1;
            btnPlayerC.Parent = pictureBox1;
            btnPlayerD.Parent = pictureBox1;

            label1.Parent = pictureBox1;
            label6.Parent = pictureBox1;
            label7.Parent = pictureBox1;
            label8.Parent = pictureBox1;
            label9.Parent = pictureBox1;

            winnerPlayerButton.Parent = pictureBox1;

            txtStepPlayerA.Parent = pictureBox1;
            txtStepPlayerB.Parent = pictureBox1;
            txtStepPlayerC.Parent = pictureBox1;
            txtStepPlayerD.Parent = pictureBox1;

            txtSpendPlayerA.Parent = pictureBox1;
            txtSpendPlayerB.Parent = pictureBox1;
            txtSpendPlayerC.Parent = pictureBox1;
            txtSpendPlayerD.Parent = pictureBox1;

            txtRemainGoldA.Parent = pictureBox1;
            txtRemainGoldB.Parent = pictureBox1;
            txtRemainGoldC.Parent = pictureBox1;
            txtRemainGoldD.Parent = pictureBox1;

            txtCollectedGoldA.Parent = pictureBox1;
            txtCollectedGoldB.Parent = pictureBox1;
            txtCollectedGoldC.Parent = pictureBox1;
            txtCollectedGoldD.Parent = pictureBox1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}