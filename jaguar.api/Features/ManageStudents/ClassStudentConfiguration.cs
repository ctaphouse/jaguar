using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace jaguar.api.Features.ManageStudents;

public class ClassStudentConfiguration : IEntityTypeConfiguration<ClassStudent>
{
    public void Configure(EntityTypeBuilder<ClassStudent> builder)
    {
        builder.HasKey(x => new { x.ClassId, x.StudentId});
    }
}