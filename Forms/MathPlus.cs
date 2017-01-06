using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Windows.Forms;

namespace SHKOLA
{
    public partial class MathPlus : Form
    {
        public MathPlus()
        {
            InitializeComponent();
        }

        List<PicButton> btnsList;

        int originalTop;
        int originalLeft;
        int originalWidth;
        int originalHeight;

        int marginTop;
        int marginBot;
        int marginRight;
        int marginLeft;

        string curExercise;
        Companion pigCompanion;
        int companionMood;

        public MathPlus(int Top, int Left, int wd, int ht)
        {
            InitializeComponent();
            originalTop = Top;
            originalLeft = Left;
            originalWidth = wd;
            originalHeight = ht;
        }

        private void MathPlus_Load(object sender, EventArgs e)
        {
            //Form settings
            MathPlus mPlusForm = (MathPlus)sender;
            mPlusForm.CenterToScreen();
            mPlusForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            mPlusForm.Top = originalTop;
            mPlusForm.Left = originalLeft;
            mPlusForm.Width = originalWidth;
            mPlusForm.Height = originalHeight;

            // Margin settings
            UpdateMargins();

            // Background settings
            mathPlusBackground.Image = ImagesStore.GetImage("math_plus_background");
            mathPlusBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            Initializator.FitBackgroundImageToWindowSize(sender, mathPlusBackground);

            // Labels settings
            exercise.Parent = mathPlusBackground;
            Initializator.FitExerciseLabelToWindowSize(exercise,marginTop,marginLeft,GetFontSize());

            // Initial exercise
            SetExercise(exercise, ExerciseGenerator.GenPlusMinusExercise());
            
            // buttons settings
            btnsList = new List<PicButton>();
            btnsList.Add(new PicButton(ref btn0, PicButtonName.pbDigit0, "math_digit_0", "math_digit_0"));
            btnsList.Add(new PicButton(ref btn1, PicButtonName.pbDigit1, "math_digit_1", "math_digit_1"));
            btnsList.Add(new PicButton(ref btn2, PicButtonName.pbDigit2, "math_digit_2", "math_digit_2"));
            btnsList.Add(new PicButton(ref btn3, PicButtonName.pbDigit3, "math_digit_3", "math_digit_3"));
            btnsList.Add(new PicButton(ref btn4, PicButtonName.pbDigit4, "math_digit_4", "math_digit_4"));
            btnsList.Add(new PicButton(ref btn5, PicButtonName.pbDigit5, "math_digit_5", "math_digit_5"));
            btnsList.Add(new PicButton(ref btn6, PicButtonName.pbDigit6, "math_digit_6", "math_digit_6"));
            btnsList.Add(new PicButton(ref btn7, PicButtonName.pbDigit7, "math_digit_7", "math_digit_7"));
            btnsList.Add(new PicButton(ref btn8, PicButtonName.pbDigit8, "math_digit_8", "math_digit_8"));
            btnsList.Add(new PicButton(ref btn9, PicButtonName.pbDigit9, "math_digit_9", "math_digit_9"));
            btnsList.Add(new PicButton(ref btnErase, PicButtonName.pbMathExerciseErase, "math_button_erase", "math_button_erase"));
            btnsList.Add(new PicButton(mathPlusBackground, ref btnNext, PicButtonName.pbMathNextExercise, "math_button_next", "math_button_next",Color.White));
            //btnsList.Add(new PicButton(mPlusForm, ref btnToolTip, PicButtonName.pbCompanionToolTip, "pig_tooltip", "pig_tooltip", Color.White));

            foreach (PicButton pBtn in btnsList)
                UpdateButtonSizeLocation((Form)sender, pBtn);

            pigCompanion = new Companion(mathPlusBackground, ref btnPigCompanion, CompanionType.ctMathPig);
            UpdateCompanionSizeLocation();

            /*
            try
            {
                Mp3FileReader reader = new Mp3FileReader("res\\math_plus\\level_music.mp3");
                WaveOut waveOut = new WaveOut();
                waveOut.Init(reader);
                waveOut.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/

            // Set companion smile at the beginning
            companionMood = 0;
        }

        private void MathPlus_Resize(object sender, EventArgs e)
        {
            Form win = (Form)sender;
            Initializator.FitBackgroundImageToWindowSize(win, mathPlusBackground);
            Initializator.FitExerciseLabelToWindowSize(exercise,marginTop,marginLeft,GetFontSize());

            // Recalculate margins
            UpdateMargins();

            foreach (PicButton pBtn in btnsList)
                UpdateButtonSizeLocation(win, pBtn);

            UpdateCompanionSizeLocation();
        }

        private void UpdateButtonSizeLocation(Form win, PicButton btn)
        {
            int btnWidth = (int)(((win.Width - marginRight - marginLeft) / 11) * AppConstants.digitButtonWidthKoef);
            int spaceWidth = (int)(((win.Width - marginRight - marginLeft) / 11) * AppConstants.spaceWidthKoef);

            switch (btn.bName)
            {
                case PicButtonName.pbDigit0:
                case PicButtonName.pbDigit1:
                case PicButtonName.pbDigit2:
                case PicButtonName.pbDigit3:
                case PicButtonName.pbDigit4:
                case PicButtonName.pbDigit5:
                case PicButtonName.pbDigit6:
                case PicButtonName.pbDigit7:
                case PicButtonName.pbDigit8:
                case PicButtonName.pbDigit9:
                case PicButtonName.pbMathExerciseErase:
                    {
                        SetDigitButtonLocation(ref btn.pButton, btn.bName, btnWidth, win.Height, marginBot, marginLeft, spaceWidth);
                        break;
                    }
                case PicButtonName.pbMathNextExercise:
                    {
                        btn.pButton.Width = (int)(win.Width * AppConstants.topButtonWidthKoef);
                        btn.pButton.Height = btn.pButton.Width;
                        btn.pButton.Top = (int)(AppConstants.topButtonMarginKoef * win.Height);
                        btn.pButton.Left = (int)(win.Width - btn.pButton.Width - btn.pButton.Top);
                        break;
                    }
                case PicButtonName.pbCompanionToolTip:
                    {
                        btn.pButton.Left = (int)(win.Width * AppConstants.companionToolTipLeftMarginKoef);
                        btn.pButton.Width = (int)(win.Width - btn.pButton.Left - AppConstants.companionMarginFromWinBorder);
                        btn.pButton.Top = (int)(btnNext.Top + btnNext.Height + AppConstants.companionMarginFromWinBorder);
                        btn.pButton.Height = (int)(win.Height - btn.pButton.Top - (AppConstants.companionToolTipBottomMarginKoef * win.Height));
                        

                        break;
                    }
            }
        }

        private void UpdateCompanionSizeLocation()
        {
            btnPigCompanion.Left = btnErase.Left + btnErase.Width + AppConstants.companionMarginFromWinBorder;
            btnPigCompanion.Width = (int)(this.Width - btnPigCompanion.Left - AppConstants.companionMarginFromWinBorder);
            btnPigCompanion.Height = btnPigCompanion.Width;
            btnPigCompanion.Top = (int)(this.Height - btnPigCompanion.Height - 3 * AppConstants.companionMarginFromWinBorder);
        }

        private void SetDigitButtonLocation(ref Button digitBtn, PicButtonName name, int btnWd, int winHt, int mBot, int mLeft, int space)
        {
            int num = 0;
            switch (name)
            {
                case PicButtonName.pbDigit0: num = 0; break;
                case PicButtonName.pbDigit1: num = 1; break;
                case PicButtonName.pbDigit2: num = 2; break;
                case PicButtonName.pbDigit3: num = 3; break;
                case PicButtonName.pbDigit4: num = 4; break;
                case PicButtonName.pbDigit5: num = 5; break;
                case PicButtonName.pbDigit6: num = 6; break;
                case PicButtonName.pbDigit7: num = 7; break;
                case PicButtonName.pbDigit8: num = 8; break;
                case PicButtonName.pbDigit9: num = 9; break;
                case PicButtonName.pbMathExerciseErase: num = 10; break;
            }

            digitBtn.Width = btnWd;
            digitBtn.Height = btnWd;

            digitBtn.Top = (winHt - mBot - btnWd);
            digitBtn.Left = (mLeft + (btnWd + space) * num);
        }

        private void UpdateMargins()
        {
            marginTop = (int)(this.Height * AppConstants.marginTopKoef);
            marginBot = (int)(this.Height * AppConstants.marginBottomKoef);
            marginRight = (int)(this.Width * AppConstants.marginRightKoef);
            marginLeft = (int)(this.Width * AppConstants.marginLeftKoef);
        }

        private float GetFontSize()
        {
            return this.Height * AppConstants.fontSizeKoefficient;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            OnNextClicked();
        }

        private void OnNextClicked()
        {
            string exr = ExerciseGenerator.GenPlusMinusExercise();
            if (checkifAnswerCorrect())
                SetExercise(exercise, exr);
        }

        public void SetExercise(Label exrStr, string genString)
        {
            curExercise = genString;
            String[] exrElements = genString.Split(' ');
            exrStr.Text = exrElements[0] + " " + exrElements[1] + " " + exrElements[2] + " = ";
        }

        private bool checkifAnswerCorrect()
        {
            if (curExercise != exercise.Text)
            {
                AppStatistic.atemptsToAnswerWrong.Inc();
                companionMood++;

                int mistakes = AppStatistic.atemptsToAnswerWrong.ReadValue();

                switch (companionMood)
                {
                    case 3: { pigCompanion.Unhappy(); break; }
                    case 5: { pigCompanion.Unhappy(); break; }
                    case 7: { pigCompanion.Unhappy(); break; }
                    case 10: { pigCompanion.Unhappy(); break; }
                    case 12: { pigCompanion.Unhappy(); break; }
                    case 14: { pigCompanion.Unhappy(); break; }
                    case 16: { pigCompanion.Unhappy(); break; }
                    case 18: { pigCompanion.Unhappy(); break; }
                    case 20: { pigCompanion.Unhappy(); break; }
                }

                return false;
            }

            AppStatistic.rightAnswersCount.Inc();

            if (companionMood > 0)
                companionMood--;

            switch (companionMood)
            {
                case 3: { pigCompanion.Happy(); break; }
                case 5: { pigCompanion.Happy(); break; }
                case 7: { pigCompanion.Happy(); break; }
                case 10: { pigCompanion.Happy(); break; }
                case 12: { pigCompanion.Happy(); break; }
                case 14: { pigCompanion.Happy(); break; }
                case 16: { pigCompanion.Happy(); break; }
                case 18: { pigCompanion.Happy(); break; }
                case 20: { pigCompanion.Happy(); break; }
            }

            return true;
        }

        public void DigitClicked(Label exrStr, char digit)
        {
            if (exrStr.Text.Length < curExercise.Length)
                exrStr.Text = exrStr.Text + digit;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            DigitClicked(exercise, '0');
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            DigitClicked(exercise, '1');
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            DigitClicked(exercise, '2');
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            DigitClicked(exercise, '3');
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            DigitClicked(exercise, '4');
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            DigitClicked(exercise, '5');
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            DigitClicked(exercise, '6');
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            DigitClicked(exercise, '7');
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            DigitClicked(exercise, '8');
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            DigitClicked(exercise, '9');
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            OnErase();
        }

        private void OnErase()
        {
            char a = exercise.Text[exercise.Text.Length - 1];
            if (a != ' ')
                exercise.Text = exercise.Text.Remove(exercise.Text.Length - 1);
        }

        private void MathPlus_KeyUp(object sender, KeyEventArgs e)
        {
             switch(e.KeyCode)
             {
                 case Keys.D0: DigitClicked(exercise, '0'); break;
                 case Keys.D1: DigitClicked(exercise, '1'); break;
                 case Keys.D2: DigitClicked(exercise, '2'); break;
                 case Keys.D3: DigitClicked(exercise, '3'); break;
                 case Keys.D4: DigitClicked(exercise, '4'); break;
                 case Keys.D5: DigitClicked(exercise, '5'); break;
                 case Keys.D6: DigitClicked(exercise, '6'); break;
                 case Keys.D7: DigitClicked(exercise, '7'); break;
                 case Keys.D8: DigitClicked(exercise, '8'); break;
                 case Keys.D9: DigitClicked(exercise, '9'); break;
                 case Keys.Back: OnErase(); break;
                 case Keys.Enter: OnNextClicked(); break;
             }
        }
    }
}
