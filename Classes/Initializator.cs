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
            ImagesStore.LoadImg("main_background", "res/main_menu/mBackground.png");
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
            ImagesStore.LoadImg("belka", "res/math_plus/belka.png");
            ImagesStore.LoadImg("pig_tooltip", "res/math_plus/tooltip.png");

            AppStatistic.ResetStatistic();

            return true;
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
