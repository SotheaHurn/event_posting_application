
using EventLib;
using EventLib.Extension;
using RestClientLib;
using System.Net;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

public class Program
{
    private static User? CurrentUser { get; set; } = default;
    private static List<Event> CurrentUserEvents { get; set; } = new List<Event>();
    public static string BaseUrl { get; set; } = "https://localhost:7196";
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Event Posting Application");
        authecation();
        // After login complete, get current user's events
        getCurrentUserEvent();
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
        // View Profile
        static void viewProfile()
        {
            Console.WriteLine("\nYour Information...");
            Console.WriteLine("Name : " + CurrentUser!.Name);
            Console.WriteLine("Phone Number : " + CurrentUser!.PhoneNumber);
            Console.WriteLine("Address : " + CurrentUser!.Address);

        }
        // Update Profile
        static void updateProfile()
        {
            Task.Run(async () => {
                RestClient restClient = new(BaseUrl);

                Console.WriteLine("\nYour Information");
                Console.Write("Name (" + (CurrentUser?.Name ?? "") + ") : ");
                string? name = Console.ReadLine();
                Console.Write("Phone Number (" + (CurrentUser?.PhoneNumber ?? "") + ") : ");
                string? phoneNumber = Console.ReadLine();
                Console.Write("Address (" + (CurrentUser?.Address ?? "") + ") : ");
                string? address = Console.ReadLine();

                string endPoint = "/api/update_profile";
                User? response = await restClient.PutAsync<User, User?>(endPoint, new User()
                {
                    UserId = CurrentUser!.UserId,
                    Username = CurrentUser.Username,
                    Password = CurrentUser.Password,
                    Name = name,
                    PhoneNumber = phoneNumber,
                    Address = address,
                });
                if(response != null)
                {
                    CurrentUser = response;
                    Console.WriteLine("\nSuccessed!!! Your profile Had been updated...");
                }
                else
                {
                    Console.WriteLine("\nFailded!!! You could not update your profile...");
                }
            }).Wait();
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
                Console.WriteLine("5. Like Event");
                Console.WriteLine("6. Comment Event");
                Console.WriteLine("7. Back");
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
                            DateTime dateTime = inputDateTime("Input Date", true, DateTime.Now);
                            getEvent(new Dictionary<string, dynamic>
                                {
                                    {"path","event_date"},
                                    {"key","dateTime" },
                                    {"value",dateTime.ToString() },
                                });
                            break;
                        }
                    case 3: 
                        {
                            getEvent(new Dictionary<string, dynamic>
                            {
                                {"path","event_category"},
                                {"key","category" },
                                {"value",getEventCategory(null) },
                            });
                            Console.WriteLine();
                            break;
                        }
                    case 4:
                        {
                            Console.Write("\nInput event name : ");
                            string name = Console.ReadLine()??"";
                            getEvent(new Dictionary<string, dynamic>
                            {
                                {"path","event_name"},
                                {"key","eventName" },
                                {"value",name},
                            });
                            break;
                        }
                    case 5:
                        {
                            likeEvent();
                            break;
                        }
                    case 6:
                        {
                            commentEvent();
                            break;
                        }
                    case 7:
                        {
                            return;
                        }
                    default:
                        {
                            break;
                        }
                }
            } while (true);
        }
        // Like Event
        static void likeEvent()
        {
            Task.Run(async() => {
                RestClient restClient = new(BaseUrl);
                string endPoint = "/api/event_like";

                Console.Write("Input Event ID : ");
                int eventId = 0;
                int.TryParse(Console.ReadLine(), out eventId);
                if (eventId <= 0)
                {
                    Console.WriteLine("\nWrong ID...");
                    return;
                }
                else
                {
                    bool response = await restClient.PutAsync<EventLikes, bool>(endPoint, new EventLikes()
                    {
                        EventId = eventId,
                        UserId=CurrentUser!.UserId,
                    });
                    if (response)
                    {
                        Console.WriteLine("\nSuccess! You liked this event...");
                    }
                    else
                    {
                        Console.WriteLine("\nFailed! Something went wrong...");
                    }
                }
            }).Wait();
        }
        // Comment Event
        static void commentEvent()
        {
            Task.Run(async () => {
                RestClient restClient = new(BaseUrl);
                string endPoint = "/api/event_comment";

                Console.Write("Input Event ID : ");
                int eventId = 0;
                int.TryParse(Console.ReadLine(), out eventId);
                if (eventId <= 0)
                {
                    Console.WriteLine("\nWrong ID...");
                    return;
                }
                else
                {
                    Console.Write("Input Comment : ");
                    string text = Console.ReadLine() ?? "";
                    if(text == "")
                    {
                        Console.WriteLine("\nFailed!! You have to input text, if you want to comment...");
                    }
                    else
                    {
                        bool response = await restClient.PutAsync<EventComments, bool>(endPoint, new EventComments()
                        {
                            EventId = eventId,
                            UserId = CurrentUser!.UserId,
                            Text = text,
                        });
                        if (response)
                        {
                            Console.WriteLine("\nSuccess! You liked this event...");
                        }
                        else
                        {
                            Console.WriteLine("\nFailed! Something went wrong...");
                        }
                    }
                    
                }
            }).Wait();
        }
        // My Account
        static void myAccount()
        {
            do
            {
                Console.WriteLine("\nPlease choose from one of the following options...");
                Console.WriteLine("1. View Profile");
                Console.WriteLine("2. Update Profile");
                Console.WriteLine("3. View My Event");
                Console.WriteLine("4. Create Event");
                Console.WriteLine("5. Update Event");
                Console.WriteLine("6. Delete Event");
                Console.WriteLine("7. Back");
                Console.Write("Please choose an option : ");
                int option = 0;
                int.TryParse(Console.ReadLine() ?? "0", out option);
                switch (option)
                {
                    case 1:
                        {
                            viewProfile();
                            break;
                        }
                    case 2:
                        {
                            updateProfile();
                            break;
                        }
                    case 3:
                        {
                            getEvent(new Dictionary<string, dynamic>
                            {
                                {"path","event_user_id"},
                                {"key","userId" },
                                {"value",CurrentUser?.UserId??0},
                            });
                            break;
                        }
                    case 4:
                        {
                            createEvent();
                            break;
                        }
                    case 5:
                        {
                            updateEvent();
                            break;
                        }
                    case 6:
                        {
                            deleteEvent();
                            break;
                        }
                    case 7:
                        {
                            return;
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
                if(response.Count()>0)
                {
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
                        foreach (EventComments eventComments in e.Comments)
                        {
                            Console.WriteLine("\t" + "User : " + eventComments.Text);
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Empty Data");
                }
            }).Wait();
        }
        // Choose Category
        static int getEventCategory(Category? initCategory)
        {
            do
            {
                Console.WriteLine("\nPlease choose from one of the following categories"+(initCategory==null?"..." : " (" + EventExtension.categoryValue[initCategory??Category.None] + ") : "));
                var categories = EventExtension.categoryValue;
                for (int index = 0; index < categories.Count(); index++)
                {
                    Console.WriteLine(index + ". " + categories.ElementAt(index).Value);
                }
                Console.Write("Choose a category : ");
                int selectedCategory = 0;
                bool isValid = int.TryParse(Console.ReadLine() ?? "0", out selectedCategory);
                if (isValid && selectedCategory < categories.Count())
                {
                    return selectedCategory;
                }
                else
                {
                    Console.WriteLine("\nWrong select number...");
                    Console.Write("Press enter to continue...");
                    Console.ReadLine();
                }
            } while (true);
        }
        // Create Event
        static void createEvent()
        {
            Task.Run(async () => {
                RestClient restClient = new(BaseUrl);
                string endPoint = "/api/create_event";

                string eventName = inputRequired("Name", "");
                DateTime startDate = inputDateTime("Start Time", false, DateTime.Now);
                DateTime endDate = inputDateTime("End Time", false, DateTime.Now);
                string? location = inputRequired("Location", "");
                int category = getEventCategory(null);
                Console.WriteLine(startDate);
                bool response = await restClient.PutAsync<Event, bool>(endPoint, new Event()
                {
                    UserId = CurrentUser!.UserId,
                    EventName = eventName,
                    StartDate = startDate,
                    EndDate = endDate,
                    Location = location,
                    CategoryNum = EventExtension.intToCategory[category],
                    CreateOn = DateTime.Now,
                });
                if (response)
                {
                    Console.WriteLine("\nSuccess! An event had been create...");
                }
                else
                {
                    Console.WriteLine("\nFailded! This event could not create...");
                }
            }).Wait();
        }
        // Update Event
        static void updateEvent()
        {
            Task.Run(async() => {
                RestClient restClient = new(BaseUrl);
                string endPoint = "/api/update_event";

                Console.Write("Input Event ID : ");
                int eventId =0;
                int.TryParse(Console.ReadLine(),out eventId);
                if(eventId <= 0) 
                {
                    Console.WriteLine("\nWrong ID...");
                    return;
                }
                else
                {
                    Event? initEvent = CurrentUserEvents.Where(x => x.EventId == eventId).FirstOrDefault();
                    if(initEvent == null)
                    {
                        Console.WriteLine("\nWrong ID...");
                        return;
                    }
                    else
                    {
                        string eventName = inputRequired("Name", initEvent.EventName ?? "");
                        DateTime startDate = inputDateTime("Start Time", false, initEvent.StartDate);
                        DateTime endDate = inputDateTime("End Time", false, initEvent.EndDate);
                        string? location = inputRequired("Location", initEvent.Location ?? "");
                        int category = getEventCategory(initEvent.CategoryNum);
                        Console.WriteLine(startDate);
                        bool response = await restClient.PutAsync<Event, bool>(endPoint, new Event()
                        {
                            EventId = initEvent.EventId,
                            UserId=CurrentUser!.UserId,
                            EventName=eventName,
                            StartDate=startDate,
                            EndDate=endDate,
                            Location=location,
                            CategoryNum = EventExtension.intToCategory[category],
                            UpdateOn=DateTime.Now,
                        });
                        if(response)
                        {
                            Console.WriteLine("\nSuccess! An event had been updated...");
                        }
                        else
                        {
                            Console.WriteLine("\nFailded! This event could not update...");
                        }
                    }
                }
            }).Wait();
        }
        // Intput DateTime
        static DateTime inputDateTime(string label,bool isNewDate,DateTime initDate)
        {
            DateTime inputDateTime;
            do
            {
                Console.Write("\n" + label + " ("
                            + (isNewDate ? "mm" : initDate.Month)
                            + "/"
                            + (isNewDate ? "dd" : initDate.Day)
                            + "/"
                            + (isNewDate ? "yy" : initDate.Year)
                            + " "
                            + (isNewDate ? "hh" : initDate.Hour > 12 ? initDate.Hour - 12 : initDate.Hour)
                            + ":"
                            + (isNewDate ? "mn" : initDate.Minute)
                            + " "
                            + (isNewDate ? "AM/PM" : (initDate.Hour > 12 ? "PM" : "AM"))
                            + ") : ");
                string date = Console.ReadLine() ?? "";
                bool isValid = DateTime.TryParse(date, out inputDateTime);
                 Console.WriteLine(isValid);
                if (isValid)
                {
                    return inputDateTime;
                }
                else
                {
                    Console.WriteLine("\nInput Date is invalid...");
                }
            } while (true);
        }
        // Input that required
        static string inputRequired(string label,string initValue)
        {
            do
            {
                Console.Write(label + (initValue == "" ? " : " : " (" + initValue + ") : "));
                string inputValue = Console.ReadLine() ?? "";
                if (inputValue == "")
                {
                    Console.WriteLine("\n"+label + " is required...");
                }
                else{
                    return inputValue;
                }
            }while(true);
        }
        // Delete Event
        static void deleteEvent()
        {
            Task.Run(async() => {
                RestClient restClient = new(BaseUrl);
                Console.Write("\nInput Event ID : ");
                string eventId = Console.ReadLine() ?? "0";
                string endPoint = "/api/delete_event?eventId="+ eventId;
                bool response = await restClient.DeleteAsync<bool>(endPoint);
                if(response)
                {
                    Console.WriteLine("\nSuccessed! An event had been deleted...");
                }
                else
                {
                    Console.WriteLine("\nFailed! You could not delete this event...");
                }
            }).Wait();
        }
        // Get Current User Events
        static void getCurrentUserEvent()
        {
            Task.Run(async () =>
            {
                RestClient restClient = new(BaseUrl);
                string endPoint = "/api/event_user_id?userId=" + (CurrentUser?.UserId ?? 0);
                CurrentUserEvents = (await restClient.GetAsync<List<Event>>(endPoint)) ?? new List<Event>();
            }).Wait();
        }
    }
}