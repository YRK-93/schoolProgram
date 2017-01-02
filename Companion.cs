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

    class Companion
    {
        Button companionControl;
        CompanionType comanionType;
        List<string> statusImagesList;
        List<string> goodPhrases;
        List<string> badPhrases;
        int curStatus;

        public Companion()
        {

        }

        public Companion(PictureBox paren, ref Button ctrl, CompanionType ctp)
        {
            companionControl = ctrl;
            comanionType = ctp;
            statusImagesList = Initializator.GetStatusesList(ctp);
            goodPhrases = Initializator.GetGoodPhrasesList(ctp);
            badPhrases = Initializator.GetBadPhrasesList(ctp);
            curStatus = 0;

            companionControl.Parent = paren;
            companionControl.BackColor = Color.Transparent;
            companionControl.TabIndex = 0;
            companionControl.FlatAppearance.MouseOverBackColor = Color.Transparent;
            companionControl.FlatAppearance.MouseDownBackColor = Color.Transparent;
            companionControl.TabStop = false;
            companionControl.FlatStyle = FlatStyle.Flat;
            companionControl.FlatAppearance.BorderSize = 0;
            companionControl.BackgroundImage = ImagesStore.GetTransparentImage(statusImagesList[curStatus], Color.White);
            companionControl.BackgroundImageLayout = ImageLayout.Stretch;
            companionControl.Text = "";
        }

        private void SetStatusImage(int indx)
        {
            companionControl.BackgroundImage = ImagesStore.GetTransparentImage(statusImagesList[indx], Color.White);
        }

        public void Unhappy()
        {
            if (curStatus < (statusImagesList.Count - 1)) // The higher curStatus value, more sad companion will be
            {
                curStatus++;
                SetStatusImage(curStatus);
            }
        }

        public void Happy()
        {
            if (curStatus > 0) // The lower --> the happier
            {
                curStatus--;
                SetStatusImage(curStatus);
            }
        }

    }
}
