namespace WebPersonal.Shared.DTO
{
  public class PersonalProfileDTO
  {
    public int? UserId { get; set; }
    public int? Id { get; set; }
    public required string UserName { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Description { get; set; }
    public required string Phone { get; set; }
    public required string Email { get; set; }
    public required string Website { get; set; }
    public required string GitHub { get; set; }
    public required List<InterestDto> Interests { get; set; }
    public required List<SkillDto> Skills { get; set; }
  }

  public class SkillDto
  {
    public int? Id { get; set; }
    public required string Name { get; set; }
    /// <summary>
    /// How good do you consider yourself at this skill.
    /// </summary>
    public decimal? Punctuation { get; set; }
  }

  public class InterestDto
  {
    public int? Id { get; set; }
    public required string Interest { get; set; }
  }
}