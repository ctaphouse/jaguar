namespace jaguar.api.Features.ManageStudents;

public class ClassStudent {
    public int ClassId { get; set; }
    public int StudentId { get; set; }
    public Class Class { get; set; } = default!;
    public Student Student { get; set; } = default!;
}