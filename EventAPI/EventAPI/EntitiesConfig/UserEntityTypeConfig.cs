using EventLib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventAPI.Entities
{
    public class UserEntityTypeConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(e => e.UserId);

            builder.Property(e => e.Username)
                .IsRequired(true)
                .HasColumnName(nameof(User.Username))
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.Property(e => e.Password)
                .IsRequired(true)
                .HasColumnName(nameof(User.Password))
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.Property(e => e.Name)
                .IsRequired(false)
                .HasColumnName(nameof(User.Name))
                .HasColumnType("nvarchar")
                .HasMaxLength(255)
                .IsUnicode(true);

            builder.Property(e => e.ProfilePicture)
                .IsRequired(false)
                .HasColumnName(nameof(User.ProfilePicture))
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.Property(e => e.PhoneNumber)
                .IsRequired(false)
                .HasColumnName(nameof(User.PhoneNumber))
                .HasColumnType("varchar")
                .HasMaxLength(15)
                .IsUnicode(false);

            builder.Property(e => e.Address)
                .IsRequired(false)
                .HasColumnName(nameof(User.Address))
                .HasColumnType("nvarchar")
                .HasMaxLength(255)
                .IsUnicode(false);
        }
    }
}
