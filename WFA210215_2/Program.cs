using System;
using System.Windows.Forms;

namespace WFA210215_2
{
    static class Program
    {
        public static string dbFileLocation;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            dbFileLocation = AppDomain.CurrentDomain.BaseDirectory.Replace(
                @"bin\Debug\net5.0-windows\", @"AppData\kozossegiszolgalat.mdf");

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
