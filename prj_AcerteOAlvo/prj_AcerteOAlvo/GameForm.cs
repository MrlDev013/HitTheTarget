using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_AcerteOAlvo
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();

            MessageBox.Show("Your mission is to move the piece and hit the blue box on the screen top!\n" +
                "When you hit the blue box, click on the submit button to verify your try!", 
                "Objectives", MessageBoxButtons.OK);
        }
        int PixelQ = 10; //Movement size

        #region UpButton
        private void btn_Up_Click(object sender, EventArgs e)
        {
            if (pct_Player.Top - PixelQ >= 0)
            {
                pct_Player.Top -= PixelQ;
                locationVerificator();
            }
        }
        #endregion

        #region LeftButton
        private void btn_Left_Click(object sender, EventArgs e)
        {
            if (pct_Player.Left - PixelQ >= 0)
            {
                pct_Player.Left -= PixelQ;
                locationVerificator();
            }
        }
        #endregion

        #region DownButton
        private void btn_Down_Click(object sender, EventArgs e)
        {
            if (pct_Player.Top + PixelQ <= ClientSize.Height)
            {
                if(pct_Player.Top < 360)
                {
                    pct_Player.Top += PixelQ;
                    locationVerificator();
                }
            }
        }
        #endregion

        #region RightButton
        private void btn_Right_Click(object sender, EventArgs e)
        {
            if (pct_Player.Left + PixelQ <= ClientSize.Width)
            {
                pct_Player.Left += PixelQ;
                locationVerificator();
            }            
        }
        #endregion
        public void locationVerificator()
        {
            if (pct_Player.Location.X >= 570 && pct_Player.Location.Y >= 10)
            {
                btn_Submit.Enabled = true;
                btn_Submit.Visible = true;
            }
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You won!");
        }
    }
}
