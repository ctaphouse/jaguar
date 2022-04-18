using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;

namespace jaguar.api.Features.ManageStudents.AddStudent;

public class AddStudentEndpoint : EndpointBaseAsync.WithRequest<Student>.WithActionResult<int>
{
    private readonly JaguarContext _context;

    public AddStudentEndpoint(JaguarContext context)
    {
        _context = context;
    }
    [HttpPost("/api/students")]
    public override async Task<ActionResult<int>> HandleAsync(Student request, CancellationToken cancellationToken = default)
    {
        var student = new Student
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            City = request.City,
            State = request.State
        };

        await _context.Students.AddAsync(student, cancellationToken);

        var classes = request.Classes.Select(x =>
            new Class
            {
                Name = x.Name,
                Description = x.Description,
            }
        );

        foreach(var c in classes)
        {
            student.Classes.Add(c);
        }

        await _context.AddRangeAsync(classes, cancellationToken);

        await _context.SaveChangesAsync(cancellationToken);

        return Ok(student.Id);
    }
}