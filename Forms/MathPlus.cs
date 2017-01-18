using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Windows.Forms;
using SHKOLA.Properties;

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
            MathPlusView.AddElement(new ButtonControl(ref this.btnNext, AppConstants.topButtonMarginKoef, (0.9f - AppConstants.topButtonMarginKoef), 0.1f, 0.12f, Resources.btnNext, this));
            MathPlusView.AddElement(new ButtonControl(ref this.btnBack, AppConstants.topButtonMarginKoef, AppConstants.topButtonMarginKoef, 0.1f, 0.12f, Resources.btnBack, this));
            HorizontalButtonsPane btnsPane = new HorizontalButtonsPane(this, 0.8f, 0.06f, 0.62f, 0.1f, HorizPanelAlign.hEvenly);
            btnsPane.AddButtonOnPane(ref btn0, Resources.digit0);
            btnsPane.AddButtonOnPane(ref btn1, Resources.digit1);
            btnsPane.AddButtonOnPane(ref btn2, Resources.digit2);
            btnsPane.AddButtonOnPane(ref btn3, Resources.digit3);
            btnsPane.AddButtonOnPane(ref btn4, Resources.digit4);
            btnsPane.AddButtonOnPane(ref btn5, Resources.digit5);
            btnsPane.AddButtonOnPane(ref btn6, Resources.digit6);
            btnsPane.AddButtonOnPane(ref btn7, Resources.digit7);
            btnsPane.AddButtonOnPane(ref btn8, Resources.digit8);
            btnsPane.AddButtonOnPane(ref btn9, Resources.digit9);
            btnsPane.AddButtonOnPane(ref btnErase, Resources.btnErase);
            MathPlusView.AddElement(btnsPane);
            MathPlusView.AddElement(new Companion(this, ref btnPigCompanion, Resources.belka, 0.6f, 0.68f, 0.3f, 0.3f));
            MathPlusView.AddBoard(new Blackboard(ref btnBoard, 0.17f, 0.06f, 0.62f, 0.6f, Resources.paper, this));
            MathPlusView.AddResultMessage(new ResultMessage(ref btnMsg, AppConstants.topButtonMarginKoef, 0.4f, 0.3f, 0.12f, Resources.btnMathY, this));
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
