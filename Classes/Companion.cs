﻿using System.Windows.Forms;
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
        Image picture;

        public Companion()
        {

        }

        public Companion(Form paren, ref Button ctrl, Image img, float topR, float leftR, float widthR, float heightR)
        {
            compParent = paren;
            baseCtrl = ctrl;
            picture = img;

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
            btn.BackgroundImage = picture;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Text = "";
        }
    }
}
