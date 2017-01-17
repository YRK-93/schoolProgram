using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SHKOLA
{
    enum CompanionType
    {
        ctMathPig,
        ctOther
    }

    class Companion : WinElement
    {
        Form compParent;
        string imageStr;

        public Companion()
        {

        }

        public Companion(Form paren, ref Button ctrl, string img, float topR, float leftR, float widthR, float heightR)
        {
            compParent = paren;
            baseCtrl = ctrl;
            imageStr = img;

            topRatio = topR;
            leftRatio = leftR;
            widthRatio = widthR;
            heightRatio = heightR;
            SetRightStyle();
        }

        public override void SetRightStyle() 
        {
            Button btn = (Button)baseCtrl;
            btn.Parent = compParent;
            btn.BackColor = Color.Transparent;
            btn.TabIndex = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn.TabStop = false;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackgroundImage = ImagesStore.GetImage(imageStr, Color.White);
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Text = "";
        }
    }
}
