using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SHKOLA
{
    class MathPlusView : BaseView
    {
        static Blackboard mathBoard;
        static ResultMessage resMessage;

        static public void AddBoard(Blackboard brd)
        {
            if (brd != null)
            {
                mathBoard = brd;
                AddElement(brd);
            }
        }

        static public void AddResultMessage(ResultMessage rmsg)
        {
            if (rmsg != null)
            {
                resMessage = rmsg;
                AddElement(rmsg);
            }
        }

        static public void OnNextClicked()
        {
            if (mathBoard.isAnswerRight())
            {
                resMessage.ShowRight();
                mathBoard.ShowNextExercise();
            }
            else
                resMessage.ShowWrong();
        }

        static public void ProcessKey(Keys key)
        {
            mathBoard.ProcessButtonClick(key);

            if (key == Keys.Enter)
                OnNextClicked();
        }
    }
}
