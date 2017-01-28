﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SHKOLA.Properties;

namespace SHKOLA
{
    class ExerciseGenerator
    {
        public static Excercise GenPlusMinusExercise()
        {
            int maxValue = Convert.ToInt32(Settings.Default.MathMaxOperandValue);
            int maxResultValue = Convert.ToInt32(Settings.Default.MathMaxResultValue);
            int aa, bb, zn, result = 0;
            string znak;

            do
            {
                Random r = new Random();
                aa = r.Next(0, maxValue + 1);
                bb = r.Next(0, maxValue + 1);
                zn = r.Next(0, maxValue + 1);

                znak = (zn % 2 == 0) ? " + " : " - ";

                if (znak == " - ")
                {
                    if (aa < bb)
                    {
                        int cc = bb;
                        bb = aa;
                        aa = cc;
                    }
                    result = aa - bb;
                }
                else result = aa + bb;
            }
            while (result > maxResultValue);

            return new Excercise(aa.ToString() + znak + bb.ToString() + " = ", result.ToString());
        }

        public static List<Excercise> GenPlusMinusExamExercises(uint num)
        {
            List<Excercise> excList = new List<Excercise>();

            while(excList.Count < num)
            {
                Excercise buf = GenPlusMinusExercise();

                if (!excList.Contains(buf))
                    excList.Add(buf);
            }
            return excList;
        }
    }
}
