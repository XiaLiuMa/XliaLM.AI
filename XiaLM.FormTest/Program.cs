﻿using System;
using System.Windows.Forms;

namespace XiaLM.FormTest
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());
            Application.Run(new MicrosoftSpeech.MainForm());
        }
    }
}