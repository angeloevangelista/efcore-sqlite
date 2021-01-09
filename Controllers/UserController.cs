using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreSqLite.Data;
using EFCoreSqLite.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EFCoreSqLite.Controllers
{
  [ApiController]
  public class WeatherForecastController : ControllerBase
  {
    [HttpGet]
    [Route("/v1/users")]
    public IEnumerable<User> Index()
    {
      var context = new AppDataContext();

      var users = context.Users.AsNoTracking().ToList();

      return users;
    }

    [HttpPost]
    [Route("/v1/users")]
    public User Create([FromBody] User user)
    {
      var context = new AppDataContext();

      context.Users.Add(user);
      context.SaveChanges();

      return user;
    }
  }
}
