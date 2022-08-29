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
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();

            this.Opacity = 0;

            logo1.Image = Properties.Resources.pacman_logo;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity < 100)
            {
                Opacity += 0.5;
                progressBar.Increment(4);
            }

            if (progressBar.Value == 100)
            {   
                timer1.Stop();
                Menu menu = new Menu();
                this.Hide();
                menu.ShowDialog();
                this.Close();
            }
        }
    }
}
