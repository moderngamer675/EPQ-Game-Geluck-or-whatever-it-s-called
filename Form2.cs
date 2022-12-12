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
    public partial class frm_settings : Form
    {
        public frm_settings()
        {
            InitializeComponent();
        }

        private void btn_returnHomeScreen_Click(object sender, EventArgs e)
        {
            frm_homeScreen homeScreen = new frm_homeScreen();
            this.Close();
            homeScreen.Show();
        }

        private void btn_returnHomeScreenHover(object sender, EventArgs e)
        {
            btn_returnHomeScreen.Font = new Font("Lucida Sans Unicode", 31, FontStyle.Bold);
        }

        private void btn_returnHomeScreenLeave(object sender, EventArgs e)
        {
            btn_returnHomeScreen.Font = new Font("Lucida Sans Unicode", 30, FontStyle.Bold);
        }

        private void backgroundColour_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fontColour_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void language_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
