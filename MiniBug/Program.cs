// Copyright(c) João Martiniano. All rights reserved.
// Licensed under the MIT license.

using System;
using System.Threading;
using System.Windows.Forms;

namespace MiniBug
{
    static class Program
    {
        public static string myName = "MiniBug v2 Issue Tracker";

        /// <summary>
        /// A software project that this application will work with. Contains issues and tasks.
        /// </summary>
        public static Project SoftwareProject = null;

        /// <summary>
        /// The mutex to ensure only one instance can be run.
        /// </summary>
        private static Mutex mutex;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!IsSingleInstance())
            {
                // Only one instance allowed to run
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        /// <summary>
        /// Only allow one instance to be run.
        /// </summary>
        /// <returns>True on success</returns>
        internal static bool IsSingleInstance()
        {
            try
            {
                // Try to open existing mutex
                Mutex.OpenExisting("MiniBug2");
            }
            catch
            {
                // Ok, only one instance
                mutex = new Mutex(true, "MiniBug2");
                return true;
            }

            // More than one instance
            MessageBox.Show("Only one instance allowed to run!", myName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

    }
}
