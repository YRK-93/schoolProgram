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
        public MainForm()
        {
            InitializeComponent();
            Initilization();
        }

        public void Initilization()
        {
            // buttons settings
            MainView.AddElement(new ButtonControl(ref this.button1, 0.2f, 0.3f, 0.4f, 0.16f, "main_math_button_g", this));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainView.Actualize(this);
            this.TopMost = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            MainView.Actualize(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainView.OnMathClicked();
            this.Show();
        }
    }
}
