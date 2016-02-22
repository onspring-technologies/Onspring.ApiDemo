#region Copyright
// /* 
//  * Onspring Platform
//  * Copyright (c) 2010, 2015 Onspring Technologies, LLC. All Rights Reserved.
//  * 
//  * <<FULL COPYRIGHT PENDING>>
//  *  
// */
#endregion

using System;
using System.Windows.Forms;

namespace Onspring.ApiDemo
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
            Application.Run(new MainForm());
        }
    }
}
