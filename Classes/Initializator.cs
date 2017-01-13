using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SHKOLA
{
    abstract class Initializator
    {
        public static bool LoadImages()
        {
            ImagesStore.InitStore();
            ImagesStore.LoadImg("main_background","res/main_menu/mBackground.png");
            ImagesStore.LoadImg("main_math_button_g", "res/main_menu/btnMathG.png");
            ImagesStore.LoadImg("main_math_button_y", "res/main_menu/btnMathY.png");
            ImagesStore.LoadImg("math_mode_background", "res/math_mode_select/mathModeBackground.png");
            ImagesStore.LoadImg("math_mode_button_plus_g", "res/math_mode_select/plusG.png");
            ImagesStore.LoadImg("math_mode_button_plus_y", "res/math_mode_select/plusY.png");
            ImagesStore.LoadImg("math_plus_background", "res/math_plus/mathPlusBackground.png");
            ImagesStore.LoadImg("math_digit_0", "res/math_plus/digit0.png");
            ImagesStore.LoadImg("math_digit_1", "res/math_plus/digit1.png");
            ImagesStore.LoadImg("math_digit_2", "res/math_plus/digit2.png");
            ImagesStore.LoadImg("math_digit_3", "res/math_plus/digit3.png");
            ImagesStore.LoadImg("math_digit_4", "res/math_plus/digit4.png");
            ImagesStore.LoadImg("math_digit_5", "res/math_plus/digit5.png");
            ImagesStore.LoadImg("math_digit_6", "res/math_plus/digit6.png");
            ImagesStore.LoadImg("math_digit_7", "res/math_plus/digit7.png");
            ImagesStore.LoadImg("math_digit_8", "res/math_plus/digit8.png");
            ImagesStore.LoadImg("math_digit_9", "res/math_plus/digit9.png");
            ImagesStore.LoadImg("math_button_next", "res/math_plus/btnNext.png");
            ImagesStore.LoadImg("math_button_erase", "res/math_plus/btnErase.png");
            ImagesStore.LoadImg("pig_status1", "res/math_plus/pig_statuses/pig1.png");
            ImagesStore.LoadImg("pig_status2", "res/math_plus/pig_statuses/pig2.png");
            ImagesStore.LoadImg("pig_status3", "res/math_plus/pig_statuses/pig3.png");
            ImagesStore.LoadImg("pig_status4", "res/math_plus/pig_statuses/pig4.png");
            ImagesStore.LoadImg("pig_status5", "res/math_plus/pig_statuses/pig5.png");
            ImagesStore.LoadImg("pig_status6", "res/math_plus/pig_statuses/pig6.png");
            ImagesStore.LoadImg("pig_status7", "res/math_plus/pig_statuses/pig7.png");
            ImagesStore.LoadImg("pig_status8", "res/math_plus/pig_statuses/pig8.png");
            ImagesStore.LoadImg("pig_status9", "res/math_plus/pig_statuses/pig9.png");
            ImagesStore.LoadImg("pig_tooltip", "res/math_plus/tooltip.png");

            AppStatistic.ResetStatistic();

            return true;
        }

        public static List<string> GetStatusesList(CompanionType cmpType)
        {
            List<string> res = new List<string>();
            switch (cmpType)
            {
                case CompanionType.ctMathPig:
                    {
                        res.Add("pig_status1");
                        res.Add("pig_status2");
                        res.Add("pig_status3");
                        res.Add("pig_status4");
                        res.Add("pig_status5");
                        res.Add("pig_status6");
                        res.Add("pig_status7");
                        res.Add("pig_status8");
                        res.Add("pig_status9");
                        break;
                    }
            }
            return res;
        }

        public static List<string> GetGoodPhrasesList(CompanionType cmpType)
        {
            List<string> res = new List<string>();
            switch (cmpType)
            {
                case CompanionType.ctMathPig:
                    {
                        res.Add("Молодец!");
                        res.Add("Ты посмотри какой умный!");
                        res.Add("Клёво!");
                        res.Add("Умница!");
                        res.Add("Ты супер!");
                        res.Add("Хороший результат!");
                        res.Add("Вот так и надо!");
                        res.Add("Становишься умнее!");
                        res.Add("Восхитително!");
                        res.Add("Потрясно!");
                        res.Add("Великолепно!");
                        res.Add("Яйца будем кушать!");
                        res.Add("Так и продолжай!");
                        res.Add("Потрясающе!");
                        res.Add("Ты наверное отличница?");
                        res.Add("Главное правильно!");
                        res.Add("Ну ты даешь!");
                        res.Add("Ты нам помогаешь!");
                        res.Add("Спасибо за помощь!");
                        res.Add("С меня причитается!");
                        break;
                    }
            }
            return res;
        }

        public static List<string> GetBadPhrasesList(CompanionType cmpType)
        {
            List<string> res = new List<string>();
            switch (cmpType)
            {
                case CompanionType.ctMathPig:
                    {
                        res.Add("Ну как так!?");
                        res.Add("Не тупи!");
                        res.Add("Очень жаль!");
                        res.Add("Ну ты совсем...");
                        res.Add("Ты хоть подумал?");
                        res.Add("Свиньи недовольны!");
                        res.Add("Очень плохо!");
                        res.Add("Одно разочарование!");
                        res.Add("Подумай!");
                        res.Add("Опять поспешил!?");
                        res.Add("Ну почему!?");
                        res.Add("Останемся голодными!");
                        res.Add("Нам так не везет!");
                        res.Add("Ничего не знаешь!");
                        res.Add("Мы думали ты отличник!");
                        res.Add("Главное правильно!");
                        res.Add("Ну невезет же!");
                        res.Add("Как так можно!");
                        res.Add("Ты не соображаешь!");
                        res.Add("Свиньи в отчаянии!");
                        break;
                    }
            }
            return res;
        }
    }

    class ImagesStore
    {
        static Dictionary<string, Image> imagesArray;
        
        public ImagesStore()
        {
        }

        public static void InitStore()
        {
            imagesArray = new Dictionary<string, Image>();
        }

        public static bool LoadImg(string name, string pathStr)
        {
            try
            {
                imagesArray.Add(name, Image.FromFile(pathStr));
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public static Image GetImage(string name, Color colorToMakeTransparent)
        {
            if (colorToMakeTransparent != Color.Transparent)
            {
                Bitmap bmp = new Bitmap(imagesArray[name]);
                bmp.MakeTransparent(colorToMakeTransparent);
                return bmp;
            }
            return imagesArray[name];
        }
    }
}
