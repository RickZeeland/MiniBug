// Copyright(c) João Martiniano. All rights reserved.
// Licensed under the MIT license.

using System;
using System.Windows.Forms;

namespace MiniBug
{
    static class Program
    {
        /// <summary>
        /// A software project that this application will work with. Contains issues and tasks.
        /// </summary>
        public static Project SoftwareProject = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
