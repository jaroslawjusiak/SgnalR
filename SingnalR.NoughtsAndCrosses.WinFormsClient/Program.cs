﻿using System;
using System.Windows.Forms;

namespace SingnalR.NoughtsAndCrosses.WinFormsClient
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
            Application.Run(new NaCForm());

        }
    }
}
