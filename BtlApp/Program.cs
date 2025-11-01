﻿using BtlApp.Individual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BtlApp
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
            //Application.Run(new Form_Login());
            //Application.Run(new Form_Manager());

            while(true)
            {
                using (Form_Login formLogin = new Form_Login())
                {
                    Application.Run(formLogin);
                    MessageBox.Show("Login thanh cong");

                    using (Form_Manager formManager = new Form_Manager(formLogin.getUserId()))
                    {
                        Application.Run(formManager);
                        if (!formManager.IsLogout()) break;
                    }
                }
            }
        }
    }
}
