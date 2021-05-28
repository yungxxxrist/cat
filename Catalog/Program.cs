/**
* @file Program.cs
* @author Держин К.В., гр.525а
* @date 27.05.2021
* @brief Курсовая работа
*
*/
using System;
using System.Windows.Forms;

namespace Catalog
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Catalog());
        }
    }
}
