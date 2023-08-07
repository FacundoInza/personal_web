using System;

namespace WebPersonal.Shared.DTO
{
  public class EducationDto
  {
    public int Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public required string CourseName { get; set; }
    public required string UniversityName { get; set; }
  }
}

