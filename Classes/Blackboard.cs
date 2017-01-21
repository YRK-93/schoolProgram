using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SHKOLA
{
    class Blackboard : ButtonControl
    {
        Excercise currentExecrise;
        float fontSize; // 93 x 71

        public Blackboard(ref Button controlFounder, float topR, float leftR, float widthR, float heightR, Image backImg, Form cParent = null):
            base(ref controlFounder, topR, leftR, widthR, heightR, backImg, cParent)
        {
            baseCtrl = controlFounder;
            topRatio = topR;
            leftRatio = leftR;
            widthRatio = widthR;
            heightRatio = heightR;
            SetRightStyle();
            SetRightFont();
            ShowNextExercise();
        }

        private void SetRightFont()
        {
            fontSize = 120.0f;
            baseCtrl.Font = new Font("Arial", fontSize, FontStyle.Bold);
        }

        public void ShowNextExercise()
        {
            currentExecrise = ExerciseGenerator.GenPlusMinusExercise();
            baseCtrl.Text = currentExecrise.getEquation();
        }

        public bool isAnswerRight()
        {
            return baseCtrl.Text == (currentExecrise.ToString());
        }

        private bool isDigitCode(Keys code)
        {
            switch (code)
            {
                case Keys.D0: 
                case Keys.D1: 
                case Keys.D2:
                case Keys.D3:
                case Keys.D4:
                case Keys.D5:
                case Keys.D6:
                case Keys.D7:
                case Keys.D8:
                case Keys.D9: return true;
            }
            return false;
        }

        private char GetDigitByKeyCode(Keys code)
        {
            switch (code)
            {
                case Keys.D0: return '0';
                case Keys.D1: return '1';
                case Keys.D2: return '2';
                case Keys.D3: return '3';
                case Keys.D4: return '4';
                case Keys.D5: return '5';
                case Keys.D6: return '6';
                case Keys.D7: return '7';
                case Keys.D8: return '8';
                case Keys.D9: return '9';
            }
            return ' ';
        }

        public void ProcessButtonClick(Keys keyCode)
        {
            if (keyCode == Keys.Back)
            {
                char a = baseCtrl.Text[baseCtrl.Text.Length - 1];
                if (a != ' ')
                    baseCtrl.Text = baseCtrl.Text.Remove(baseCtrl.Text.Length - 1);
            }

            if (isDigitCode(keyCode))
            {
                if (baseCtrl.Text.Length < currentExecrise.ToString().Length)
                    baseCtrl.Text = baseCtrl.Text + GetDigitByKeyCode(keyCode);
            }
        }
    }
}
