using EventLib;
using RestClientLib;

namespace EventWindow
{
    internal static class Program
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
            Application.Run(new LoginSignUp());
        }
        public static RestClient RestClient = new("https://localhost:7196");
        public static User? CurrentUser { get; set; } = default;
        public static List<Event> CurrentUserEvents { get; set; } = new List<Event>();
    }
}