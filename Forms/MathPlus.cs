using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Windows.Forms;

namespace SHKOLA
{
    public partial class MathPlus : Form
    {
        private void MathPlus_Load(object sender, EventArgs e)
        {
            btnNext.Focus();
            Actualize();
            this.TopMost = false;
        }

        private void MathPlus_Resize(object sender, EventArgs e)
        {
            Actualize();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            OnNextClicked();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            ProcessKey(Keys.D0);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ProcessKey(Keys.D1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ProcessKey(Keys.D2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ProcessKey(Keys.D3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ProcessKey(Keys.D4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ProcessKey(Keys.D5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ProcessKey(Keys.D6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ProcessKey(Keys.D7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ProcessKey(Keys.D8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ProcessKey(Keys.D9);
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            ProcessKey(Keys.Back);
        }

        private void MathPlus_KeyUp(object sender, KeyEventArgs e)
        {
            ProcessKey(e.KeyCode);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
