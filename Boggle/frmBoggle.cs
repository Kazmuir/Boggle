// Kazmuir Long Kenneth Griffin
// 3/24/20
// CIS 3309 Project 3 Boggle Game
//
// Boggle Windows Form Class
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boggle
{
    public partial class frmBoggle : Form
    {
        public frmBoggle()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            pcbxBoggleSet.Visible = false;
            btnPlay.Enabled = false;
            pnlInstructions.Visible = true;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {

        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            btnStartGame.Visible = false;
            pnlBoard.Visible = true;
            lblEnterWords.Visible = true;
        }
    }
}
