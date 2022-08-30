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
    public partial class Game : Form
    {
        bool goUp, goDown, goLeft, goRight, isGameOver;

        int score, playerSpeed, redGhostSpeed, greenGhostSpeed, pinkGhostX, pinkGhostY, orangeGhostX, orangeGhostY, pbMoveSpeed, pbMove2Speed, life;

        int timerMax = 0;

        public Game()
        {
            InitializeComponent();

            gbGameOver.Hide();

            pacman.Image = Properties.Resources.pacman_right;
            greenGhost.Image = Properties.Resources.pacman_green;
            redGhost.Image = Properties.Resources.pacman_red;
            pinkGhost.Image = Properties.Resources.pacman_pink;
            orangeGhost.Image = Properties.Resources.pacman_orange;

            life1.Image = Properties.Resources.pacman;
            life2.Image = Properties.Resources.pacman;
            life3.Image = Properties.Resources.pacman;

            foreach (Control control in this.Controls)
            {
                if (control is PictureBox pictureBox && (string)control.Tag == "circle")
                {
                    pictureBox.Image = Properties.Resources.white_circle;
                    pictureBox.BringToFront();
                }
            }

            foreach (Control control in this.Controls)
            {
                if (control is PictureBox pictureBox && (string)control.Tag == "cherry")
                {
                    pictureBox.Image = Properties.Resources.cherry;
                }
            }

            foreach (Control control in this.Controls)
            {
                if (control is PictureBox pictureBox && (string)control.Tag == "ghost")
                {
                    pictureBox.BringToFront();
                }
            }

            foreach (Control control in this.Controls)
            {
                if (control is PictureBox pictureBox && (string)control.Tag == "wall")
                {
                    pictureBox.BringToFront();
                }
            }

            gbGameOver.BringToFront();

            lblValue.Text = Properties.Settings.Default.high_score;

            gameReset();
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                gbGameOver.Hide();
                gameReset();
            }
            if (e.KeyCode == Keys.Escape)
            {
                MessageBox messageBox = new MessageBox();

                if (messageBox.ShowDialog() == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    this.ActiveControl = null;
                }
            }
            if (e.KeyCode == Keys.R && (life == 1 || life == 2))
            {
                gameReset();
            }
        }

        private void life_index()
        {
            if (life == 1)
            {
                life3.Visible = false;
            }

            if (life == 2)
            {
                life2.Visible = false;
            }

            if (life == 3)
            {
                life1.Visible = false;

                SoundPlayer audio = new SoundPlayer(Pac_Man.Properties.Resources.pacman_death);
                audio.Play();

                gameOver();
            }
        }

        private void gameTimer(object sender, EventArgs e)
        {
            lblScore.Text = "Score: " + score;

            if (score > Int32.Parse(Properties.Settings.Default.high_score))
            {
                lblValue.Text = score.ToString();
                Properties.Settings.Default.high_score = lblValue.Text;
                Properties.Settings.Default.Save();
            }

            if (score == 100)
            {
                SoundPlayer audio = new SoundPlayer(Pac_Man.Properties.Resources.pacman_win);
                audio.Play();

                isGameOver = true;

                lblValue.Text = "100";
                lblValue.Location = new Point(41, 504);

                timer.Stop();
                gbGameOver.Show();
                lblOver.Hide();
            }

            if (timerMax > 0 && timerMax < 10) { }

            else
            {

                if (goLeft == true)
                {
                    pacman.Left -= playerSpeed;
                    pacman.Image = Properties.Resources.pacman_left;
                }

                if (goRight == true)
                {
                    pacman.Left += playerSpeed;
                    pacman.Image = Properties.Resources.pacman_right;
                }

                if (goDown == true)
                {
                    pacman.Top += playerSpeed;
                    pacman.Image = Properties.Resources.pacman_down;
                }

                if (goUp == true)
                {
                    pacman.Top -= playerSpeed;
                    pacman.Image = Properties.Resources.pacman_up;
                }

                if (pacman.Left < -10)
                {
                    pacman.Left = 1000;
                }
                if (pacman.Left > 1000)
                {
                    pacman.Left = -10;
                }

                if (pacman.Top < -10)
                {
                    pacman.Top = 550;
                }
                if (pacman.Top > 550)
                {
                    pacman.Top = 0;
                }
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "circle" && x.Visible == true)
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            SoundPlayer audio = new SoundPlayer(Pac_Man.Properties.Resources.pacman_chomp);
                            audio.Play();

                            score += 1;
                            x.Visible = false;
                        }
                    }

                    if ((string)x.Tag == "cherry" && x.Visible == true)
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            SoundPlayer audio = new SoundPlayer(Pac_Man.Properties.Resources.pacman_eatfruit);
                            audio.Play();

                            score += 15;
                            x.Visible = false;
                        }
                    }

                    if ((string)x.Tag == "wall")
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            SoundPlayer audio = new SoundPlayer(Pac_Man.Properties.Resources.pacman_hit);
                            audio.Play();

                            PacmanTimer();

                            pacman.Location = new Point(24, 244);
                            life += 1;
                            life_index();
                        }

                        if (pinkGhost.Bounds.IntersectsWith(x.Bounds))
                        {
                            pinkGhostX = -pinkGhostX;
                        }
                    }

                    if ((string)x.Tag == "ghost")
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            SoundPlayer audio = new SoundPlayer(Pac_Man.Properties.Resources.pacman_hit);
                            audio.Play();

                            PacmanTimer();

                            pacman.Location = new Point(24, 244);
                            life += 1;
                            life_index();
                        }
                    }
                }
            }

            greenGhost.Left -= greenGhostSpeed;

            if (greenGhost.Bounds.IntersectsWith(pbGreen1.Bounds) || greenGhost.Bounds.IntersectsWith(pbGreen2.Bounds))
            {
                greenGhostSpeed = -greenGhostSpeed;
            }

            redGhost.Left += redGhostSpeed;

            if (redGhost.Bounds.IntersectsWith(pbRed1.Bounds) || redGhost.Bounds.IntersectsWith(pbRed2.Bounds))
            {
                redGhostSpeed = -redGhostSpeed;
            }


            pinkGhost.Left -= pinkGhostX;
            pinkGhost.Top -= pinkGhostY;


            if (pinkGhost.Top < 0 || pinkGhost.Top > 410)
            {
                pinkGhostY = -pinkGhostY;
            }

            if (pinkGhost.Left < 0 || pinkGhost.Left > 805)
            {
                pinkGhostX = -pinkGhostX;
            }

            if (pinkGhost.Bounds.IntersectsWith(pbTop.Bounds) || pinkGhost.Bounds.IntersectsWith(cherry1.Bounds))
            {
                pinkGhostY = -pinkGhostY;
            }


            if (orangeGhost.Left == 421 && orangeGhost.Top > 180)
            {
                orangeGhost.Top -= orangeGhostY;
            }

            if (orangeGhost.Left >= 421 && orangeGhost.Top <= 180 && orangeGhost.Left <= 650)
            {
                orangeGhost.Top = 180;
                orangeGhost.Left += orangeGhostX;
            }

            if (orangeGhost.Left >= 650 && orangeGhost.Top <= 310)
            {
                orangeGhost.Top += orangeGhostY;
            }

            if (orangeGhost.Left >= 421 && orangeGhost.Top >= 310)
            {
                orangeGhost.Left -= orangeGhostX;
            }

            pbMove.Top += pbMoveSpeed;

            if (pbMove.Bounds.IntersectsWith(pbUp.Bounds) || pbMove.Bounds.IntersectsWith(pbDown.Bounds))
            {
                pbMoveSpeed = -pbMoveSpeed;
            }

            pbMove2.Top += pbMove2Speed;

            if (pbMove2.Bounds.IntersectsWith(pbGreen1.Bounds) || pbMove2.Bounds.IntersectsWith(pbDown2.Bounds))
            {
                pbMove2Speed = -pbMove2Speed;
            }
        }

        private void gameReset()
        {
            gbGameOver.Hide();

            lblScore.Text = "Score: 0";
            score = 0;
            life = 0;

            timerMax = 11;

            greenGhostSpeed = 6;
            redGhostSpeed = 5;
            pinkGhostX = 5;
            pinkGhostY = 6;
            orangeGhostX = 6;
            orangeGhostY = 10;

            playerSpeed = 8;

            pbMoveSpeed = 2;
            pbMove2Speed = 2;

            isGameOver = false;

            pacman.Left = 24;
            pacman.Top = 244;

            greenGhost.Left = 401;
            greenGhost.Top = 49;

            redGhost.Left = 351;
            redGhost.Top = 452;

            pinkGhost.Left = 736;
            pinkGhost.Top = 239;

            orangeGhost.Left = 421;
            orangeGhost.Top = 310;

            pbMove.Left = 870;
            pbMove.Top = 265;

            pbMove2.Left = 143;
            pbMove2.Top = 158;

            timer.Start();

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Visible = true;
                }
            }
        }

        private void gameOver()
        {
            isGameOver = true;

            pacman.Visible = true;

            timer.Stop();
            gbGameOver.Show();
            lblWin.Hide();

            lblScore.Text = "Score: " + score;
        }

        private void HighScore()
        {
            int zero = 0;
            lblValue.Text = zero.ToString();
            Properties.Settings.Default.high_score = lblValue.Text;
            Properties.Settings.Default.Save();
        }

        private void PacmanTimer()
        {
            if (blinkTimer.Enabled == false)
            {
                blinkTimer.Interval = 80;
                blinkTimer.Tick += new EventHandler(blinkTimer_Tick);

                timerMax = 0;

                blinkTimer.Start();
            }
            else
            {
                timerMax = 0;
            }
        }

        private void blinkTimer_Tick(object sender, EventArgs e)
        {
            if (timerMax < 10)
            {
                pacman.Visible = !pacman.Visible;
                timerMax++;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            MessageBox messageBox = new MessageBox();

            if (messageBox.ShowDialog() == DialogResult.Yes)
            {
                HighScore();
                Application.Exit();
            }
            else
            {
                this.ActiveControl = null;
            }
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            HighScore();
        }
    }
}
