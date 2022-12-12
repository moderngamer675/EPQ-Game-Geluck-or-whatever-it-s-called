using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Possible_EPQ
{
    public partial class frm_homeScreen : Form
    {
        public frm_homeScreen()
        {
            InitializeComponent();
        }

        private void btn_playButtonHover(object sender, EventArgs e)
        {
            btn_playButton.Font = new Font("Lucida Sans Unicode", 78, FontStyle.Bold);
        }

        private void btn_playButtonLeave(object sender, EventArgs e)
        {
            btn_playButton.Font = new Font("Lucida Sans Unicode", 72, FontStyle.Bold);
        }

        private void btn_quitButtonHover(object sender, EventArgs e)
        {
            btn_quitButton.Font = new Font("Lucida Sans Unicode", 78, FontStyle.Bold);
        }

        private void btn_quitButtonLeave(object sender, EventArgs e)
        {
            btn_quitButton.Font = new Font("Lucida Sans Unicode", 72, FontStyle.Bold);
        }

        private void btn_quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_playButton_Click(object sender, EventArgs e)
        {
            GameUI game = new GameUI();
            this.Hide();
            game.Show();
        }
    }
}
