using P6_4_714240035;
using System;
using System.Windows.Forms;

namespace P6_1_714240035
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // ⬅️ Form1 akan ditampilkan
        }
    }
}