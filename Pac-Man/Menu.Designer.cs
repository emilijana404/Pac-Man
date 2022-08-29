
namespace Pac_Man
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.ghost4 = new System.Windows.Forms.PictureBox();
            this.ghost3 = new System.Windows.Forms.PictureBox();
            this.ghost1 = new System.Windows.Forms.PictureBox();
            this.ghost2 = new System.Windows.Forms.PictureBox();
            this.pacman1 = new System.Windows.Forms.PictureBox();
            this.logo2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ghost4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Black;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(413, 325);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(147, 55);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRules
            // 
            this.btnRules.BackColor = System.Drawing.Color.Black;
            this.btnRules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRules.FlatAppearance.BorderSize = 0;
            this.btnRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRules.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRules.ForeColor = System.Drawing.Color.White;
            this.btnRules.Location = new System.Drawing.Point(359, 409);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(266, 55);
            this.btnRules.TabIndex = 7;
            this.btnRules.Text = "Instructions";
            this.btnRules.UseVisualStyleBackColor = false;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // ghost4
            // 
            this.ghost4.Image = global::Pac_Man.Properties.Resources.pacman_orange;
            this.ghost4.Location = new System.Drawing.Point(581, 247);
            this.ghost4.Name = "ghost4";
            this.ghost4.Size = new System.Drawing.Size(62, 34);
            this.ghost4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ghost4.TabIndex = 8;
            this.ghost4.TabStop = false;
            // 
            // ghost3
            // 
            this.ghost3.Image = global::Pac_Man.Properties.Resources.pacman_red;
            this.ghost3.Location = new System.Drawing.Point(531, 247);
            this.ghost3.Name = "ghost3";
            this.ghost3.Size = new System.Drawing.Size(62, 34);
            this.ghost3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ghost3.TabIndex = 5;
            this.ghost3.TabStop = false;
            // 
            // ghost1
            // 
            this.ghost1.Image = global::Pac_Man.Properties.Resources.pacman_pink;
            this.ghost1.Location = new System.Drawing.Point(434, 247);
            this.ghost1.Name = "ghost1";
            this.ghost1.Size = new System.Drawing.Size(62, 34);
            this.ghost1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ghost1.TabIndex = 4;
            this.ghost1.TabStop = false;
            // 
            // ghost2
            // 
            this.ghost2.Image = global::Pac_Man.Properties.Resources.pacman_green;
            this.ghost2.Location = new System.Drawing.Point(483, 247);
            this.ghost2.Name = "ghost2";
            this.ghost2.Size = new System.Drawing.Size(62, 34);
            this.ghost2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ghost2.TabIndex = 3;
            this.ghost2.TabStop = false;
            // 
            // pacman1
            // 
            this.pacman1.Image = global::Pac_Man.Properties.Resources.pacman_right;
            this.pacman1.Location = new System.Drawing.Point(377, 247);
            this.pacman1.Name = "pacman1";
            this.pacman1.Size = new System.Drawing.Size(62, 34);
            this.pacman1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pacman1.TabIndex = 2;
            this.pacman1.TabStop = false;
            // 
            // logo2
            // 
            this.logo2.Image = global::Pac_Man.Properties.Resources.pacman_logo;
            this.logo2.Location = new System.Drawing.Point(150, 52);
            this.logo2.Name = "logo2";
            this.logo2.Size = new System.Drawing.Size(683, 229);
            this.logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo2.TabIndex = 1;
            this.logo2.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.ghost4);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.ghost3);
            this.Controls.Add(this.ghost1);
            this.Controls.Add(this.ghost2);
            this.Controls.Add(this.pacman1);
            this.Controls.Add(this.logo2);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.ghost4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo2;
        private System.Windows.Forms.PictureBox pacman1;
        private System.Windows.Forms.PictureBox ghost2;
        private System.Windows.Forms.PictureBox ghost1;
        private System.Windows.Forms.PictureBox ghost3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.PictureBox ghost4;
    }
}