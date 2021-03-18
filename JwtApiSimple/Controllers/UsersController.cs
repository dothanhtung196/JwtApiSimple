using JwtApiSimple.Entities;
using JwtApiSimple.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtApiSimple.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        [Authorize(Roles = "Manager")]
        public IActionResult Get()
        {
            return Ok(new DataResponse<User>(200, "Success", new User() { UserName = "DTT", Password = "DTT@123", Role = "Manager" }));
        }
    }
}
