using EventLib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventAPI.Entities
{
    public class EventCommentsEntityTypeConfig : IEntityTypeConfiguration<EventComments>
    {
        public void Configure(EntityTypeBuilder<EventComments> builder)
        {
            builder.ToTable("EventComments");

            builder.HasKey(e => e.CommentId);

            builder.Property(e => e.EventId)
                .IsRequired(true)
                .HasColumnName(nameof(EventComments.EventId))
                .HasColumnType("int");

            builder.Property(e => e.UserId)
                .IsRequired(true)
                .HasColumnName(nameof(EventComments.UserId))
                .HasColumnType("int");

            builder.Property(e => e.Text)
                .IsRequired(true)
                .HasColumnName(nameof(EventComments.Text))
                .HasColumnType("nvarchar")
                .HasMaxLength(255)
                .IsUnicode(true);
        }
    }
}
