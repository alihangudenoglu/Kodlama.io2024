using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class CourseConfiguration : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.HasKey(r => r.Id);
        builder.Property(r => r.Name).IsRequired().HasMaxLength(100);
        builder.Property(r => r.Description).IsRequired().HasMaxLength(500);
        builder.Property(r => r.Price).IsRequired();

        builder.HasOne(ur => ur.Category)
            .WithMany(u => u.Courses)
            .HasForeignKey(ur => ur.CategoryId);

        builder.HasOne(ur => ur.Instructor)
            .WithMany(r => r.Courses)
            .HasForeignKey(r=>r.InstructorId);
    }
}

