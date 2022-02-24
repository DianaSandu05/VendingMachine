using System;
using System.Windows.Forms;

namespace VendingMachine_21017207
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#pragma warning disable CS1729 // 'main_Menu' does not contain a constructor that takes 0 arguments
          Application.Run(new main_Menu());
#pragma warning restore CS1729 // 'main_Menu' does not contain a constructor that takes 0 arguments
        }

    }
}
