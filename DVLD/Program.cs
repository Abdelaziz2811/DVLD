﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
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
            //Application.Run(new Login());

            using (Login login = new Login())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new MainScreen(login.TXTB_Username.Text));
                }
            }
        }
    }
}
