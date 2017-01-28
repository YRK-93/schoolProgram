using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SHKOLA
{
    public partial class MainForm : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            Actualize();
            this.TopMost = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Actualize();
        }

        private void btnMath_Click(object sender, EventArgs e)
        {
            OnMathClicked();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            OnOptionsCliked();
        }
    }
}
