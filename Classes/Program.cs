using System;
using System.Windows.Forms;

namespace SHKOLA
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // images loading
            Initializator.LoadImages();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm mf = new MainForm();
            Application.Run(mf);
        }
    }
}
