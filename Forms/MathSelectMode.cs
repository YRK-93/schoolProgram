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
    public partial class MathSelectMode : Form
    {
        List<PicButton> btnsList;

        public MathSelectMode()
        {
            InitializeComponent();
        }

        int originalTop;
        int originalLeft;
        int originalWidth;
        int originalHeight;

        public MathSelectMode(int Top, int Left, int wd, int ht)
        {
            InitializeComponent();
            originalTop = Top;
            originalLeft = Left;
            originalWidth = wd;
            originalHeight = ht;
        }

        private void MathSelectMode_Load(object sender, EventArgs e)
        {
            //Form settings
            MathSelectMode mSM = (MathSelectMode)sender;
            mSM.CenterToScreen();
            mSM.FormBorderStyle = FormBorderStyle.FixedDialog;
            mSM.Top = originalTop;
            mSM.Left = originalLeft;
            mSM.Width = originalWidth;
            mSM.Height = originalHeight;

            // Background settings
            mathModeBackground.Image = ImagesStore.GetImage("math_mode_background");
            mathModeBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            Initializator.FitBackgroundImageToWindowSize(sender, mathModeBackground);

            // buttons settings
            btnsList = new List<PicButton>();
            btnsList.Add(new PicButton(ref button1, PicButtonName.pbMathModePlus, "math_mode_button_plus_g", "math_mode_button_plus_y"));
            foreach (PicButton pBtn in btnsList)
                UpdateButtonSizeLocation((Form)sender, pBtn);
        }

        private void MathSelectMode_Resize(object sender, EventArgs e)
        {
            Initializator.FitBackgroundImageToWindowSize(sender, mathModeBackground);
            foreach (PicButton pBtn in btnsList)
                UpdateButtonSizeLocation((Form)sender, pBtn);
        }

        private void UpdateButtonSizeLocation(Form win, PicButton btn)
        {
            int marginTop = (int)(win.Height * 0.2);
            //int marginBot = 100;

            switch (btn.bName)
            {
                case PicButtonName.pbMathModePlus:
                    {
                        btn.pButton.Width = (int)(win.Width * 0.4);
                        btn.pButton.Height = (int)(win.Height * 0.16);

                        btn.pButton.Top = (int)(marginTop + (/*numberFromTop*/1 - 1) * btn.pButton.Height);
                        btn.pButton.Left = (int)((win.Width * 0.5) - (btn.pButton.Width * 0.5));
                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mathForm = new MathPlus(this.Top, this.Left, this.Width, this.Height);
            mathForm.ShowDialog();
            this.Close();
        }
    }
}
