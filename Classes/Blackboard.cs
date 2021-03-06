﻿using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace SHKOLA
{
    class Blackboard : ButtonControl
    {
        List<Excercise> execrisesList;
        Excercise curExercise;
        List<Answer> userAnswers;
        bool examMode, isMultiplyMode;
        float fontSize; // 93 x 71
        int currentExcNum;

        public Blackboard(bool isExamMode, bool isMultMode, ref Button controlFounder, float topR, float leftR, float widthR, float heightR, Image backImg, Form cParent = null):
            base(ref controlFounder, topR, leftR, widthR, heightR, backImg, cParent)
        {
            examMode = isExamMode;
            isMultiplyMode = isMultMode;
            baseCtrl = controlFounder;
            topRatio = topR;
            leftRatio = leftR;
            widthRatio = widthR;
            heightRatio = heightR;
            currentExcNum = -1;

            if (examMode)
                execrisesList = ExerciseGenerator.GenPlusMinusExamExercises(isMultiplyMode);

            userAnswers = new List<Answer>();
            
            SetRightStyle();
            SetRightFont();
            ShowNextExercise();
        }

        private void SetRightFont()
        {
            fontSize = 120.0f;
            baseCtrl.Font = new Font("Arial", fontSize, FontStyle.Bold);
        }

        private void GetNextExcercise()
        {
            if (examMode)
            {
                if (examMode && curExercise != execrisesList[execrisesList.Count - 1])
                    currentExcNum++;
                curExercise = execrisesList[currentExcNum];
            }
            else 
                curExercise = isMultiplyMode ? ExerciseGenerator.GenMultiplTabExcercise() : ExerciseGenerator.GenPlusMinusExercise();
        }

        public void ShowNextExercise()
        {
            GetNextExcercise();
            baseCtrl.Text = curExercise.getEquation();
        }

        public bool isExcerciseLeft()
        {
            return !(examMode && curExercise == execrisesList[execrisesList.Count - 1]);
        }

        public bool isAnswerRight()
        {
            if (baseCtrl.Text == curExercise.getEquation())
                return false;

            if (examMode)
                userAnswers.Add(new Answer(baseCtrl.Text));
            return examMode ? true : baseCtrl.Text == (curExercise.ToString());
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
                if (baseCtrl.Text.Length < curExercise.ToString().Length)
                    baseCtrl.Text = baseCtrl.Text + GetDigitByKeyCode(keyCode);
            }
        }

        public List<Answer> getUserAnswersList()
        {
            return userAnswers;
        }
    }
}
