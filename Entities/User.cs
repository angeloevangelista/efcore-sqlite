using System;

namespace EFCoreSqLite.Entities
{
  public class User
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime BirthDate { get; set; }
  }
}