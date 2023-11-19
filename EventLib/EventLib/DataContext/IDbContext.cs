using Microsoft.EntityFrameworkCore;

namespace EventLib
{
    public interface IDbContext
    {
        DbSet<User> User { get; set; }
        DbSet<Event> Event { get; set; }
        DbSet<EventLikes> EventLikes { get; set; }
        DbSet<EventComments> EventComments { get; set; }

        int SaveChanges();
    }
}
