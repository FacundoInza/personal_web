using System.Collections.Generic;

namespace WebPersonal.Shared.Dto
{
  public class AcademicProjectsDto
  {

    public required List<AcademicProjectDto> Projects { get; set; }
  }
  public class AcademicProjectDto
  {
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Details { get; set; }
    public required List<string> Environment { get; set; }
  }
}