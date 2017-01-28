using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SHKOLA.Properties;

namespace SHKOLA
{
    partial class MathPlus
    {
        Blackboard mathBoard;
        ResultMessage resMessage;
        bool examMode, multiplyMode;
        List<WinElement> controlsList;

        public MathPlus(MathWindowMode winMode)
        {
            InitializeComponent();
            applieWinMode(winMode);

            // Initialization
            controlsList = new List<WinElement>();
            controlsList.Add(new ButtonControl(ref this.btnNext, AppConstants.topButtonMarginKoef, (0.9f - AppConstants.topButtonMarginKoef), 0.1f, 0.12f, Resources.btnNext, this));
            controlsList.Add(new ButtonControl(ref this.btnBack, AppConstants.topButtonMarginKoef, AppConstants.topButtonMarginKoef, 0.1f, 0.12f, Resources.btnBack, this));
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
            controlsList.Add(btnsPane);
            controlsList.Add(new Companion(this, ref btnPigCompanion, Resources.belka, 0.6f, 0.685f, 0.3f, 0.3f));

            mathBoard = new Blackboard(examMode, multiplyMode, ref btnBoard, 0.5f, 0.06f, 0.62f, 200.0f, Resources.paper, this);
            controlsList.Add(mathBoard);

            resMessage = new ResultMessage(ref btnMsg, AppConstants.topButtonMarginKoef, 0.4f, 0.3f, 0.12f, this);
            controlsList.Add(resMessage);
        }

        private void applieWinMode(MathWindowMode winMode)
        {
            switch (winMode)
            {
                case MathWindowMode.mmPlusMinusExam: { examMode = true; multiplyMode = false; break; }
                case MathWindowMode.mmPlusMinusTraining: { examMode = false; multiplyMode = false; break; }
                case MathWindowMode.mmMultiplyTraining: { examMode = false; multiplyMode = true; break; }
                case MathWindowMode.mmMultiplyExam: { examMode = true; multiplyMode = true; break; }
            }
        }

        void Actualize()
        {
            if (controlsList != null)
                foreach (WinElement wElem in controlsList)
                    wElem.OnUpdate(this);
        }

        public void OnNextClicked()
        {
            if (mathBoard.isAnswerRight())
            {
                if (!examMode)
                    resMessage.ShowRight();
                if (mathBoard.isExcerciseLeft())
                    mathBoard.ShowNextExercise();
                else
                {
                    ExamResults er = new ExamResults(mathBoard.getUserAnswersList());
                    er.ShowDialog();
                    this.Close(); // Close form MathPlus, when form with examination results will closed
                }
            }
            else if (!examMode)
                resMessage.ShowWrong();
        }

        public void ProcessKey(Keys key)
        {
            mathBoard.ProcessButtonClick(key);

            // In the other case if space or enter pressed, next button automatically will clicked, because of focus
        }
    }
}
