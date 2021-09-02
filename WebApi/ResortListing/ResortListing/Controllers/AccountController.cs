using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Configuration;
using Microsoft.AspNetCore.Identity;
using ResortListing.Data;
using ResortListing.DTO;
using ResortListing.Services;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;

namespace ResortListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IAuthManager _authManager;
        private readonly Microsoft.Extensions.Configuration.IConfiguration _configurations;


        public AccountController(IMapper mapper, UserManager<ApplicationUser> userManager, IAuthManager authManager, IConfiguration configurations)
        {
            _mapper = mapper;
            _userManager = userManager;
            _authManager = authManager;
            _configurations = configurations;
        }


        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] UserDto userDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var user = _mapper.Map<ApplicationUser>(userDto);
                user.UserName = userDto.Email;

                var result = await _userManager.CreateAsync(user, userDto.Password);
                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }

                    return BadRequest(ModelState);
                }

                return Accepted();


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
           

        }
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> SiginIn([FromBody] LoginDto loginDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var user = await _userManager.FindByNameAsync(loginDto.Email);
                if (user != null)
                {
                    var chkPassword = await _userManager.CheckPasswordAsync(user, loginDto.Password);

                    if (!chkPassword)
                    {
                        return BadRequest();
                    }
                    // Generate a new token
                    var token = await _authManager.CreateToken(user);

                  return Accepted(token);
                }
                    

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return Accepted();
        }


    }
}
