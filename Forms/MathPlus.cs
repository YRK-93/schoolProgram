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
        public MathPlus()
        {
            InitializeComponent();
            Initilization();
        }

        public void Initilization()
        {
            // buttons settings
            MathPlusView.AddElement(new ButtonControl(ref this.btnNext, AppConstants.topButtonMarginKoef, (0.9f - AppConstants.topButtonMarginKoef), 0.1f, 0.12f, "math_button_next", this));
            MathPlusView.AddElement(new ButtonControl(ref this.btnBack, AppConstants.topButtonMarginKoef, AppConstants.topButtonMarginKoef, 0.1f, 0.12f, "math_button_back", this));
            HorizontalButtonsPane btnsPane = new HorizontalButtonsPane(this, 0.8f, 0.06f, 0.62f, 0.1f, HorizPanelAlign.hEvenly);
            btnsPane.AddButtonOnPane(ref btn0, "math_digit_0");
            btnsPane.AddButtonOnPane(ref btn1, "math_digit_1");
            btnsPane.AddButtonOnPane(ref btn2, "math_digit_2");
            btnsPane.AddButtonOnPane(ref btn3, "math_digit_3");
            btnsPane.AddButtonOnPane(ref btn4, "math_digit_4");
            btnsPane.AddButtonOnPane(ref btn5, "math_digit_5");
            btnsPane.AddButtonOnPane(ref btn6, "math_digit_6");
            btnsPane.AddButtonOnPane(ref btn7, "math_digit_7");
            btnsPane.AddButtonOnPane(ref btn8, "math_digit_8");
            btnsPane.AddButtonOnPane(ref btn9, "math_digit_9");
            btnsPane.AddButtonOnPane(ref btnErase, "math_button_erase");
            MathPlusView.AddElement(btnsPane);

            MathPlusView.AddCompanion(new Companion(this, ref btnPigCompanion, "belka", 0.6f, 0.68f, 0.3f, 0.3f));
            MathPlusView.AddBoard(new Blackboard(ref exercise, 0.17f, 0.06f, 0.62f, 0.6f));
        }

        private void MathPlus_Load(object sender, EventArgs e)
        {
            MathPlusView.Actualize(this);
            this.TopMost = false;
        }

        private void MathPlus_Resize(object sender, EventArgs e)
        {
            MathPlusView.Actualize(this);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            MathPlusView.OnNextClicked();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            MathPlusView.ProcessKey(Keys.D0);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MathPlusView.ProcessKey(Keys.D1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MathPlusView.ProcessKey(Keys.D2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MathPlusView.ProcessKey(Keys.D3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            MathPlusView.ProcessKey(Keys.D4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            MathPlusView.ProcessKey(Keys.D5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            MathPlusView.ProcessKey(Keys.D6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            MathPlusView.ProcessKey(Keys.D7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            MathPlusView.ProcessKey(Keys.D8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            MathPlusView.ProcessKey(Keys.D9);
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            MathPlusView.ProcessKey(Keys.Back);
        }

        private void MathPlus_KeyUp(object sender, KeyEventArgs e)
        {
            MathPlusView.ProcessKey(e.KeyCode);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
