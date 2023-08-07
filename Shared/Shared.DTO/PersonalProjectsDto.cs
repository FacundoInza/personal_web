using System;
using System.Collections.Generic;
using System.Text;

namespace WebPersonal.Shared.Dto
{
  public class PersonalProjectsDto
  {
    public required List<PersonalProjectDto> PersonalProjects { get; set; }
  }

  public class PersonalProjectDto
  {
    public int Id { get; set; }
    public required string ProjectType { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required List<string> Environment { get; set; }
  }



}