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
    }
}
