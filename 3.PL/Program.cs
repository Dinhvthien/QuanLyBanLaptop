using _3.PL.Views;

namespace _3.PL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Data Source=DE
            // SKTOP-3S9P0UC\SQLEXPRESS;Initial Catalog=QLBanLaptop;Persist Security Info=True;User ID=theuniverse
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
        //  Application.Run(new FormLogin());
          Application.Run(new IndexForm());
            //     Application.Run(new AdminForm());

        }
    }
}