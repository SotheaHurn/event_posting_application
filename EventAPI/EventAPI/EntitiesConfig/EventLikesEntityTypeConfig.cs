using EventLib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventAPI.Entities
{
    public class EventLikesEntityTypeConfig : IEntityTypeConfiguration<EventLikes>
    {
        public void Configure(EntityTypeBuilder<EventLikes> builder)
        {
            builder.ToTable("EventLikes");

            builder.HasKey(e => e.LikeId);

            builder.Property(e => e.EventId)
                .IsRequired(true)
                .HasColumnName(nameof(EventLikes.EventId))
                .HasColumnType("int");

            builder.Property(e => e.UserId)
                .IsRequired(true)
                .HasColumnName(nameof(EventLikes.UserId))
                .HasColumnType("int");
        }
    }
}
