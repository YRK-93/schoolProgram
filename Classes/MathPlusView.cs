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
        static bool examMode;

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

        static public void SetExamMode()
        {
            examMode = true;
        }

        static public bool isExamMode()
        {
            return examMode;
        }

        static public void OnNextClicked()
        {
            /*if (mathBoard.isAnswerRight())
            {
                if (!examMode)
                    resMessage.ShowRight();
                if (mathBoard.isExcerciseLeft())
                    mathBoard.ShowNextExercise();
                else
                {

                }
            }
            else if (!examMode)
                resMessage.ShowWrong();*/
            ExamResults er = new ExamResults();
            er.ShowDialog();
        }

        static public void ProcessKey(Keys key)
        {
            mathBoard.ProcessButtonClick(key);

            if (key == Keys.Enter)
                OnNextClicked();
        }
    }
}
