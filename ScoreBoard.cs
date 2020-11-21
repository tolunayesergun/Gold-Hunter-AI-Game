using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldHunterAIGame
{
    public partial class ScoreBoard : Form
    {
        public ScoreBoard()
        {
            InitializeComponent();

        }


        private void ScoreBoard_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(63, 25, 12);
            TransparencyKey = Color.FromArgb(63, 25, 12);

            playerA.Parent = pictureBox1;
            playerB.Parent = pictureBox1;
            playerC.Parent = pictureBox1;
            playerD.Parent = pictureBox1;

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
