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
    }
}
