
using EventLib;
using EventLib.Extension;
using RestClientLib;

public class Program
{
    private static User? CurrentUser { get; set; } = default;
    public static string BaseUrl { get; set; } = "https://localhost:7196";
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Event Posting Application");
        //authecation();
        do
        {
            options();
            int option = 0;
            int.TryParse(Console.ReadLine() ?? "0", out option);
            if (option == 1)
            {
                viewEvent();
            }
            else if(option == 2)
            {
                myAccount();
            }
            else
            {
                Console.WriteLine("\nWrong Option...\n");
            }
        }while(true);

        // Authecation
        static void authecation()
        {
            bool isSuccess = false;
            do
            {
                Console.WriteLine("\n1. Login");
                Console.WriteLine("2. Don't have any account? Sign up!");
                Console.Write("Please choose an option : ");
                int option = 0;
                int.TryParse(Console.ReadLine() ?? "0", out option);
                if (option == 1)
                {
                    isSuccess = login();
                }
                else if (option == 2)
                {
                    isSuccess = signUp();
                }
                else
                {
                    Console.WriteLine("\nWrong Option...");
                }
            } while (isSuccess == false);
        }
        // Login
        static bool login()
        {
            bool isSuccess = false;
            Task.Run(async () =>
            {
                RestClient restClient = new(BaseUrl);
                do
                {
                    Console.Write("\nPlease input your Username : ");
                    string username = Console.ReadLine() ?? "";
                    Console.Write("Please input your Password : ");
                    string password = Console.ReadLine() ?? "";

                    string endPoint = "/api/login?username=" + username + "&password=" + password;

                    CurrentUser = await restClient.PostAsync<User?>(endPoint);
                    if (CurrentUser == null)
                    {
                        Console.WriteLine("\nWrong username or password...");
                        Console.Write("Do you want to try again? (Y/N) : ");
                        string yOrN = Console.ReadLine() ?? "y";
                        if (yOrN == "n" || yOrN == "N")
                        {
                            isSuccess = false;
                            break;
                        }
                    }
                    else
                    {
                        isSuccess = true;
                    }
                } while (CurrentUser == null);
            }).Wait();
            return isSuccess;
        }
        // Sign up
        static bool signUp()
        {
            bool isSuccess = false;
            Task.Run(async () =>
            {
                RestClient restClient = new(BaseUrl);
                do
                {
                    Console.Write("\nPlease input your Username : ");
                    string username = Console.ReadLine() ?? "";
                    Console.Write("Please input your Password : ");
                    string password = Console.ReadLine() ?? "";

                    string endPoint = "/api/sign_up?username=" + username + "&password=" + password;

                    CurrentUser = await restClient.PostAsync<User?>(endPoint);
                    if (CurrentUser == null)
                    {
                        Console.WriteLine("This username had been taken");
                        Console.Write("Do you want to try again? (Y/N) : ");
                        if (Console.ReadLine() == "n" || Console.ReadLine() == "N")
                        {
                            isSuccess = false;
                            break;
                        }
                    }
                    else
                    {
                        isSuccess = true;
                    }
                } while (CurrentUser == null);
            }).Wait();
            return isSuccess;
        }
        // Options
        static void options()
        {
            Console.WriteLine("\nPlease choose from one of the following options...");
            Console.WriteLine("1. View Event");
            Console.WriteLine("2. My Account");
            Console.Write("Please choose an option : ");
        }
        // View Event
        static void viewEvent()
        {
            do
            {
                Console.WriteLine("\nPlease choose from one of the following options...");
                Console.WriteLine("1. View All Event");
                Console.WriteLine("2. View Event By Date");
                Console.WriteLine("3. View Event By Category");
                Console.WriteLine("4. View Event By Name");
                Console.Write("Please choose an option : ");
                int option = 0;
                int.TryParse(Console.ReadLine() ?? "0", out option);
                switch (option)
                {
                    case 1:
                        {
                            getEvent(new Dictionary<string, dynamic>
                            {
                                {"path","event"},
                                {"key","" },
                            });
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Please input date (year-month-day) : ");
                            DateTime dateTime;
                            bool isDate = DateTime.TryParse(Console.ReadLine(), out dateTime);
                            if (isDate)
                            {
                                Console.WriteLine(dateTime.Year+"-"+dateTime.Month+"-"+dateTime.Day);
                                getEvent(new Dictionary<string, dynamic>
                                {
                                    {"path","event_date"},
                                    {"key","dateTime" },
                                    {"value",dateTime.Year+"-"+dateTime.Month+"-"+dateTime.Day },
                                });
                            }
                            break;
                        }
                    case 3: 
                        {
                            Console.WriteLine();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            } while (true);
        }
        // My Account
        static void myAccount()
        {
            do
            {
                Console.WriteLine("\nPlease choose from one of the following options...");
                Console.WriteLine("1. My Profile");
                Console.WriteLine("2. View My Event");
                Console.WriteLine("3. Update Event");
                Console.WriteLine("4. Delete Event");
                Console.Write("Please choose an option : ");
                int option = 0;
                int.TryParse(Console.ReadLine() ?? "0", out option);
                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            } while(true);
        }
        // Get Event
        static void getEvent(Dictionary<string,dynamic> data)
        {
            Task.Run(async () =>
            {
                RestClient restClient = new(BaseUrl);
                string endPoint = "/api/" + data["path"] + (data["key"] == "" ? "" : "?" + data["key"] + "=" + data["value"]);
                List<Event> response = (await restClient.GetAsync<List<Event>>(endPoint)) ?? new List<Event>();
                Console.WriteLine();
                foreach (Event e in response)
                {
                    Console.WriteLine("ID : " + e.EventId);
                    Console.WriteLine("Name : " + e.EventName);
                    Console.WriteLine("Logo : " + e.EventLogo);
                    Console.WriteLine("Start Date : " + e.StartDate.ToString());
                    Console.WriteLine("Event Date : " + e.EndDate.ToString());
                    Console.WriteLine("Location : " + e.Location);
                    Console.WriteLine("Category : " + EventExtension.categoryValue[e.CategoryNum]);
                    Console.WriteLine("Likes : " + e.LikedCount);
                    Console.WriteLine("Comments : ");
                    foreach(EventComments eventComments in e.Comments)
                    {
                        Console.WriteLine("\t"+eventComments.Text);
                    }
                    Console.WriteLine();
                }
            }).Wait();
        }
    }
}