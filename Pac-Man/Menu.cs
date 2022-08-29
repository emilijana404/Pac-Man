using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Media;

namespace Pac_Man
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            SoundPlayer audio = new SoundPlayer(Pac_Man.Properties.Resources.pacman_beginning);
            audio.Play();

            logo2.Image = Properties.Resources.pacman_logo;
            pacman1.Image = Properties.Resources.pacman;
            ghost1.Image = Properties.Resources.pacman_pink;
            ghost2.Image = Properties.Resources.pacman_green;
            ghost3.Image = Properties.Resources.pacman_red;
            ghost4.Image = Properties.Resources.pacman_orange;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            this.Hide();
            game.ShowDialog();
            this.Close();
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            Rules rules = new Rules();
            this.Hide();
            rules.ShowDialog();
            this.Close();
        }
    }
}
