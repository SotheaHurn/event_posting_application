using EventLib;
using EventLib.Extension;
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
        public static string AppDirectory = AppDomain.CurrentDomain.BaseDirectory + "../../../";
        public static string UploadImage(string filePath,string directory)
        {
            // Image folder
            // ProfileImage
            // EventImage
            if(filePath != null && filePath != "")
            {
                string imageName = EventExtension.RadomImageName();
                string imageExtension = Path.GetExtension(filePath);
                string targetPath = AppDirectory + directory;
                if (!System.IO.Directory.Exists(targetPath))
                {
                    System.IO.Directory.CreateDirectory(targetPath);
                }
                string profileImagePath = targetPath + "/" + imageName + imageExtension;
                File.Copy(filePath, profileImagePath);
                return imageName + imageExtension;
            }
            return "";
        }
        public static void DeleteImage(string fileName, string directory)
        {
            string targetPath = AppDirectory + directory;
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }
            string filePath = targetPath + "/" + fileName;
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}