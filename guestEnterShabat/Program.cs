using guestEnterShabat.View;

namespace guestEnterShabat
{
    internal  class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            LoginForm lg = new LoginForm();
            lg.Show();
            Application.Run();
        }
    }
}