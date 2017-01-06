using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SHKOLA
{
    enum PicButtonName
    {
        pbMath,
        pbMathModePlus,
        pbDigit0,
        pbDigit1,
        pbDigit2,
        pbDigit3,
        pbDigit4,
        pbDigit5,
        pbDigit6,
        pbDigit7,
        pbDigit8,
        pbDigit9,
        pbMathNextExercise,
        pbMathExerciseErase,
        pbCompanionToolTip
    }

    class PicButton
    {
        public PicButtonName bName;
        public Button pButton;
        string imgOnStart;
        string imgOnSelect;
        Color transpColor;
        Control pbParentForm;

        public PicButton()
        {
            
        }

        public PicButton(ref Button bt, PicButtonName bname, string imgGr, string imgYel)
        {
            bName = bname;
            pButton = bt;
            imgOnStart = imgGr;
            imgOnSelect = imgYel;
            SetRightButtonStyle();
        }

        public PicButton(Control parenControl, ref Button bt, PicButtonName bname, string imgGr, string imgYel, Color transparentColor)
        {
            bName = bname;
            pButton = bt;
            imgOnStart = imgGr;
            imgOnSelect = imgYel;
            transpColor = transparentColor;
            pbParentForm = parenControl;
            SetRightTransparentButtonStyle();
        }

        private void SetRightButtonStyle()
        {
            pButton.TabStop = false;
            pButton.FlatStyle = FlatStyle.Flat;
            pButton.FlatAppearance.BorderSize = 0;
            pButton.BackgroundImage = ImagesStore.GetImage(imgOnStart);
            pButton.BackgroundImageLayout = ImageLayout.Stretch;
            pButton.Text = "";
        }

        private void SetRightTransparentButtonStyle()
        {
            pButton.Parent = pbParentForm;
            pButton.BackColor = Color.Transparent;
            pButton.TabIndex = 0;
            pButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            pButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            pButton.TabStop = false;
            pButton.FlatStyle = FlatStyle.Flat;
            pButton.FlatAppearance.BorderSize = 0;
            pButton.BackgroundImage = ImagesStore.GetTransparentImage(imgOnStart, transpColor);
            pButton.BackgroundImageLayout = ImageLayout.Stretch;
            pButton.Text = "";
        }
    }
}
