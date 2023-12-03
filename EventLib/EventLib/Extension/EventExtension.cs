using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLib.Extension
{
    public static class EventExtension
    {
        public static Dictionary<Category, string> categoryValue = new Dictionary<Category, string>
        {
            {Category.None,"None"},
            {Category.Charity,"Charity"},
            {Category.Concerts,"Concerts"},
            {Category.Parties,"Parties"},
            {Category.Sports,"Sports"},
            {Category.Conferences,"Conferences"},
            {Category.Exhibitions,"Exhibitions"},
            {Category.Workshops,"Workshops"},
            {Category.Festivals,"Festivals"},
            {Category.Meetups,"Meetups"},
            {Category.Fundraisers,"Fundraisers"},
            {Category.Classes,"Classes"},
            {Category.ComedyShows,"Comedy Shows"},
            {Category.TheaterAndPlays,"Theater and Plays"},
            {Category.MoviesAndScreenings,"Movies and Screenings"},
            {Category.Gaming,"Gaming"},
            {Category.FoodAndDrink,"Food and Drink"},
            {Category.ArtAndCulture,"Art and Culture"},
            {Category.OutdoorActivities,"Outdoor Activities"},
            {Category.TechAndInnovation,"Tech and Innovation"},
            {Category.HealthAndWellness,"Health and Wellness"},
        };
        public static Dictionary<int, Category> intToCategory = new Dictionary<int, Category>
        {
            {0,Category.None},
            {1,Category.Charity},
            {2, Category.Concerts},
            {3, Category.Parties},
            {4, Category.Sports},
            {5, Category.Conferences},
            {6, Category.Exhibitions},
            {7, Category.Workshops},
            {8, Category.Festivals},
            {9, Category.Meetups},
            {10, Category.Fundraisers},
            {11, Category.Classes},
            {12, Category.ComedyShows},
            {13, Category.TheaterAndPlays},
            {14, Category.MoviesAndScreenings},
            {15, Category.Gaming},
            {16, Category.FoodAndDrink},
            {17, Category.ArtAndCulture},
            {18, Category.OutdoorActivities},
            {19, Category.TechAndInnovation},
            {20, Category.HealthAndWellness},
        };
        public static Dictionary<Category, int> categoryToInt = new Dictionary<Category, int>
        {
            {Category.None, 0},
            {Category.Charity,1},
            {Category.Concerts,2},
            {Category.Parties,3},
            {Category.Sports,4},
            {Category.Conferences,5},
            {Category.Exhibitions,6},
            {Category.Workshops,7},
            {Category.Festivals,8},
            {Category.Meetups,9},
            {Category.Fundraisers,10},
            {Category.Classes,11},
            {Category.ComedyShows,12},
            {Category.TheaterAndPlays,13},
            {Category.MoviesAndScreenings,14},
            {Category.Gaming,15},
            {Category.FoodAndDrink,16},
            {Category.ArtAndCulture,17},
            {Category.OutdoorActivities,18},
            {Category.TechAndInnovation,19},
            {Category.HealthAndWellness,20},
        };
        public static string RadomImageName()
        {
            Random rd = new Random();
            const string allowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz0123456789";
            char[] chars = new char[10];

            for (int i = 0; i < 10; i++)
            {
                chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            }

            return new string(chars);
        }
    }
}
