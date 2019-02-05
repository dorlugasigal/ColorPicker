using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.ThreadException += Application_ThreadException;
                AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;


                bool bln;
                Mutex mtx = new Mutex(false, "ColorPicker", out bln);
                if (bln == false)
                {
                    clsManageComunication.TransmitDataToServer(string.Empty);
                }
                else
                {

                    clsManageComunication.GetServerWorker.RunWorkerAsync();
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new frmMain());
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (e.ExceptionObject as Exception);
            // Observer.WriteError(ex.Message, ex.StackTrace);
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            //Observer.WriteError(e.Exception.Message, e.Exception.StackTrace);
        }

    }
}
