using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace calculator
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
            Application.Run(new Welcome());

            // Form1
            Application.Run(new Form1());

        }
    }
}