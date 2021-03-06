﻿using System;
using System.Windows.Forms;
using ChromiumFX.Extension;

namespace CfxTestApplication
{
    static class Program
    {
 

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            
            ChromiumStartup.VirtualPath = "www";
            ChromiumStartup.EnableMaster = true;
            ChromiumStartup.SubViewPathName = "views";
            ChromiumStartup.MasterHeaderFile = "local://local/www/shared/header.html";
            ChromiumStartup.MasterFooterFile = "local://local/www/shared/footer.html";


            //on windows use ChromiumfxWebBrowser set to false
            ChromiumStartup.RequireWindowLess = false;

            //on linux use chromiumfxWebBrowserWindowless set to true
            //ChromiumStartup.RequireWindowLess = true;

            // you can use your custome cef lib path 
            //var basePath = System.IO.Path.GetDirectoryName(new System.Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath);
            //ChromiumStartup.LibCefPath = Path.Combine(basePath, "cef");
            //ChromiumStartup.LibCfxPath = Path.Combine(basePath, "cef");
            //ChromiumStartup.CefResourcePath = Path.Combine(basePath, "cef");// or Path.Combine(basePath, "cef","Resource");
 

            ChromiumStartup.Initialize();


            ChromiumStartup.RegisterLocalScheme();

          


            //CfxRuntime.RunMessageLoop();
            //Application.ApplicationExit += Application_ApplicationExit;
            //Application.Idle += BrowserMessageLoopStep;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //



        }

    }
}
