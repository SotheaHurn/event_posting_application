using EventAPI.Entities;
using EventLib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventAPI
{
    public class SqlDbContext : DbContext, IDbContext
    {
        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options) {
            User = Set<User>();
            Event=Set<Event>();
            EventLikes = Set<EventLikes>();
            EventComments = Set<EventComments>();
        }

        public DbSet<User> User { get; set; }

        public DbSet<Event> Event { get; set; }

        public DbSet<EventLikes> EventLikes { get; set; }

        public DbSet<EventComments> EventComments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserEntityTypeConfig());
            modelBuilder.ApplyConfiguration(new EventEntityTypeConfig());
            modelBuilder.ApplyConfiguration(new EventLikesEntityTypeConfig());
            modelBuilder.ApplyConfiguration(new EventCommentsEntityTypeConfig());

            seedUserData(modelBuilder.Entity<User>());
            seedEventData(modelBuilder.Entity<Event>());
            seedEventLikesData(modelBuilder.Entity<EventLikes>());
            seedEventCommentsData(modelBuilder.Entity<EventComments>());
        }

        private void seedUserData(EntityTypeBuilder<User> entityTypeBuilder)
        {
            var reqs = new List<User>() 
            {
                new User { UserId = 1, Username = "admin", Password = "123456789" },
                new User { UserId = 2, Username = "kimbo", Password = "password", Name = "Kim Bo" },
            };

            entityTypeBuilder.HasData(reqs);
        }

        private void seedEventData(EntityTypeBuilder<Event> entityTypeBuilder)
        {
            var reqs = new List<Event>()
            {
                 new Event { EventId = 1, UserId = 1, EventName = "Sea Game 2023", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(1), Location = "Location One", CategoryNum = Category.Gaming, CreateOn = DateTime.Now },
                new Event { EventId = 2, UserId = 2, EventName = "Code C", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(2), Location = "Location Two", CategoryNum = Category.Conferences, CreateOn = DateTime.Now },
            };

            entityTypeBuilder.HasData(reqs);
        }

        private void seedEventLikesData(EntityTypeBuilder<EventLikes> entityTypeBuilder)
        {
            var reqs = new List<EventLikes>()
            {
                new EventLikes { LikeId = 1, EventId = 1, UserId = 2 },
                new EventLikes { LikeId = 2, EventId = 2, UserId = 1 },
            };

            entityTypeBuilder.HasData(reqs);
        }

        private void seedEventCommentsData(EntityTypeBuilder<EventComments> entityTypeBuilder)
        {
            var reqs = new List<EventComments>()
            {
                new EventComments { CommentId = 1, EventId = 1, UserId = 2, Text = "Nice Game" },
                new EventComments { CommentId = 2, EventId = 2, UserId = 1, Text = "Like this event in Cambodia" },
            };

            entityTypeBuilder.HasData(reqs);
        }
    }
}
