using System;
using System.Collections.Generic;

namespace WebPersonal.Shared.DTO
{
  public class WorkExperienceDto
  {
    public required List<PositionDto> Positions { get; set; }

  }

  public class PositionDto
  {
    public int Id { get; set; }
    public required string PositionName { get; set; }
    public required DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public required string CompanyName { get; set; }
    public required string Country { get; set; }
    public required string City { get; set; }
    public required List<string> Environment { get; set; }
    public required List<WorkProjectDto> MainProjects { get; set; }
  }

  public class WorkProjectDto
  {
    public int Id { get; set; }
    public required string Nombre { get; set; }
    public required string Description { get; set; }

  }
}