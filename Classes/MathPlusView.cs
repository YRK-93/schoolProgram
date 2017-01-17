using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SHKOLA
{
    class MathPlusView : BaseView
    {
        static Companion pigCompanion;
        static Blackboard mathBoard;

        static public void AddCompanion(Companion cmp)
        {
            if (cmp != null)
            {
                pigCompanion = cmp;
                AddElement(cmp);
            }
        }

        static public void AddBoard(Blackboard brd)
        {
            if (brd != null)
            {
                mathBoard = brd;
                AddElement(brd);
            }
        }

        static public void OnNextClicked()
        {
            if (mathBoard.isAnswerRight())
            {
                System.Media.SystemSounds.Asterisk.Play();
                mathBoard.ShowNextExercise();
            }
            else
            {
                System.Media.SystemSounds.Hand.Play();   
            }
        }

        static public void ProcessKey(Keys key)
        {
            mathBoard.ProcessButtonClick(key);

            if (key == Keys.Enter)
                OnNextClicked();
        }
    }
}
