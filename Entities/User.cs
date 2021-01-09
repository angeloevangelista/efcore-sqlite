using System;

namespace EFCoreSqLite.Entities
{
  public class User
  {
    public User(string name, string email, DateTime birthDate)
    {
      Name = name;
      Email = email;
      BirthDate = birthDate;
    }

    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public DateTime BirthDate { get; private set; }
  }
}