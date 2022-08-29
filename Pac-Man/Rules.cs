using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pac_Man
{
    public partial class Rules : Form
    {
        public Rules()
        {
            InitializeComponent();

            point1.Image = Properties.Resources.white_circle;
            points10.Image = Properties.Resources.cherry;
            life.Image = Properties.Resources.pacman;
            ghost.Image = Properties.Resources.pacman_red;
            directions.Image = Properties.Resources.keyboard;
            pacman2.Image = Properties.Resources.pacman_eating;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
    }
}
