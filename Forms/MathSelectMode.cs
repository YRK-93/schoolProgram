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
            btnPlus.ForeColor = Color.White;
            btnPlusExam.ForeColor = Color.White;
            Font fnt = new Font("Arial", 45.0f, FontStyle.Bold);
            MathSelectModeView.AddElement(new ButtonControl(ref this.btnPlus, 0.2f, 0.2f, 0.6f, 0.1f, Resources.plusG, this, "Тренировка на тему сложение", fnt));
            MathSelectModeView.AddElement(new ButtonControl(ref this.btnPlusExam, 0.3f, 0.2f, 0.6f, 0.1f, Resources.plusG, this, "Контроль на тему сложение", fnt));
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

        private void btnPlusExam_Click(object sender, EventArgs e)
        {
            this.Hide();
            MathPlusView.EnableExamMode();
            MathSelectModeView.OnMathPlusClicked();
            this.Show();
        }
    }
}
