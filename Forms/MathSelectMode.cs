using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SHKOLA.Properties;

namespace SHKOLA
{
    public partial class MathSelectMode : Form
    {

        public MathSelectMode()
        {
            InitializeComponent();
            Initilization();
        }

        public void Initilization()
        {
            // buttons settings
            MathSelectModeView.AddElement(new ButtonControl(ref this.button1, 0.2f, 0.3f, 0.4f, 0.16f, Resources.plusG, this));
        }

        private void MathSelectMode_Load(object sender, EventArgs e)
        {
            MathSelectModeView.Actualize(this);
            this.TopMost = false;
        }

        private void MathSelectMode_Resize(object sender, EventArgs e)
        {
            MathSelectModeView.Actualize(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MathSelectModeView.OnMathPlusClicked();
            this.Show();
        }
    }
}
