using EventLib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventAPI.Entities
{
    public class EventEntityTypeConfig : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.ToTable("Event");

            builder.HasKey(e => e.EventId);

            builder.Property(e => e.UserId)
                .IsRequired(true)
                .HasColumnName(nameof(Event.UserId))
                .HasColumnType("int");

            builder.Property(e => e.EventName)
                .IsRequired(true)
                .HasColumnName(nameof(Event.EventName))
                .HasColumnType("nvarchar")
                .HasMaxLength(255)
                .IsUnicode(true);

            builder.Property(e => e.EventLogo)
                .IsRequired(false)
                .HasColumnName(nameof(Event.EventLogo))
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.Property(e => e.StartDate)
                .IsRequired(true)
                .HasColumnName(nameof(Event.StartDate))
                .HasColumnType("datetime");

            builder.Property(e => e.EndDate)
                .IsRequired(true)
                .HasColumnName(nameof(Event.EndDate))
                .HasColumnType("datetime");

            builder.Property(e => e.Location)
               .IsRequired(true)
               .HasColumnName(nameof(Event.Location))
               .HasColumnType("nvarchar")
               .HasMaxLength(255)
               .IsUnicode(true);

            builder.Property(e => e.CategoryNum)
                .IsRequired(true)
                .HasColumnName(nameof(Event.CategoryNum))
                .HasColumnType("tinyint");

            //builder.Property(e => e.LikedCount)
            //.HasComputedColumnSql("(SELECT ISNULL(SUM([LikedCount]), 0) FROM [EventLikes] WHERE [EventId] = [EventId])")
            //.ValueGeneratedOnAddOrUpdate();

            builder.HasMany(e => e.Comments)
                .WithOne()
                .HasForeignKey(c => c.EventId);

            builder.Property(e => e.CreateOn)
                .IsRequired(true)
                .HasColumnName(nameof(Event.CreateOn))
                .HasColumnType("datetime");

            builder.Property(e => e.UpdateOn)
                .IsRequired(false)
                .HasColumnName(nameof(Event.UpdateOn))
                .HasColumnType("datetime");
        }
    }
}
