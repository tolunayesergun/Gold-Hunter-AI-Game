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
            Game newGame = new Game(this);
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