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
    public partial class MessageBox : Form
    {
        public MessageBox()
        {
            InitializeComponent();

            pbQuestion.Image = Properties.Resources.question_mark;
        }

        static MessageBox newMessageBox;

        public void ShowBox(string txtMessage, string txtDesc)
        {
            newMessageBox = new MessageBox();
            newMessageBox.lblMessage.Text = txtMessage;
            newMessageBox.ShowDialog();
        }
    }
}
