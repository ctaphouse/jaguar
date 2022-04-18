namespace jaguar.api.Features.ManageStudents;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string City { get; set; } = default!;
    public string State { get; set; } = default!;

    public ICollection<Class> Classes { get; set; } = new List<Class>();
}