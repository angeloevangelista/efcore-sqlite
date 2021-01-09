using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using EFCoreSqLite.Data;
using EFCoreSqLite.Entities;
using EFCoreSqLite.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EFCoreSqLite.Controllers
{
  [ApiController]
  public class UserController : ControllerBase
  {
    [HttpGet]
    [Route("/v1/users")]
    public ActionResult<IEnumerable<User>> Index()
    {
      var context = new AppDataContext();

      var users = context.Users.AsNoTracking().ToList();

      return Ok(users);
    }

    [HttpPost]
    [Route("/v1/users")]
    public ActionResult<User> Create([FromBody] UserViewModel userViewModel)
    {
      var user = new User (
        userViewModel.Name,
        userViewModel.Email,
        userViewModel.Birthdate
      );

      var context = new AppDataContext();

      context.Users.Add(user);
      context.SaveChanges();

      return new CreatedResult("", user);
    }
  }
}