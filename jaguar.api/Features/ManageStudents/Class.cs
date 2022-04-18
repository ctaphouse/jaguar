namespace jaguar.api.Features.ManageStudents;

public class Class
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public ICollection<Student> Students { get; set; } = new List<Student>();
}