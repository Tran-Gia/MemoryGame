using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(ExceptionHandler);
            Application.Run(new FirstPanel());
        }

        static void ExceptionHandler(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine($"An error has occurred: {e.ExceptionObject}");
            MessageBox.Show($"An error has occurred: {e.ExceptionObject}", "Unknown Error");
        }
    }
}
