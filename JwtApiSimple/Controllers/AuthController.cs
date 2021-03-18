using JwtApiSimple.Entities;
using JwtApiSimple.Models;
using JwtApiSimple.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace JwtApiSimple.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthenticationService _authenticationServices;
        public AuthController(IAuthenticationService authenticationServices)
        {
            _authenticationServices = authenticationServices;
        }

        /// <summary>
        /// Đăng nhập
        /// </summary>
        /// <param name="loginRequest"></param>
        /// <returns></returns>
        /// <response code="200">Đăng nhập thành công</response>
        /// <response code="400">Thiếu tham số truyền vào</response>
        /// <response code="500">Máy chủ không phản hồi</response>
        [ProducesResponseType(typeof(DataResponse<LoginResponse>), 200)]
        //[ProducesResponseType(400)]
        //[ProducesResponseType(500)]
        [AllowAnonymous]
        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginRequest loginRequest)
        {
            if(loginRequest == null)
            {
                return BadRequest("Invalid client request");
            }

            if(loginRequest.UserName == "DTT" && loginRequest.Password == "DTT@123")
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, loginRequest.UserName),
                    new Claim(ClaimTypes.Role, "Manager, Admin")
                };

                string stringToken = _authenticationServices.GenerateToken(claims);

                return Ok(new DataResponse<LoginResponse>(200, "Success", new LoginResponse() { Token = stringToken }));
            }
            return Unauthorized();
        }
    }
}
