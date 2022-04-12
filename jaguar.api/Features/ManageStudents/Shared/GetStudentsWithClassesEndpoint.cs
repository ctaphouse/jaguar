using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace jaguar.api.Features.ManageStudents.Shared;

public class GetStudentsWithClassesEndpoint : EndpointBaseAsync.WithoutRequest.WithActionResult<Student>
{
    private readonly JaguarContext _context;

    public GetStudentsWithClassesEndpoint(JaguarContext context)
    {
        _context = context;
    }

    [HttpGet("/api/students")]
    public override async Task<ActionResult<Student>> HandleAsync(CancellationToken cancellationToken = default)
    {
        var students = await _context.Students.Include(x => x.Classes).ToListAsync(cancellationToken);

        return Ok(students);
    }
}