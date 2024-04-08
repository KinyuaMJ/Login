using LoginTestAPI.Models.Domain;
using LoginTestAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LoginTestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly ITokenRepository tokenRepository;

       

        public AuthController(UserManager<IdentityUser>userManager, ITokenRepository tokenRepository)
        {
            this.userManager = userManager;
            this.tokenRepository = tokenRepository;
        }

        //POST: /api/Auth/Register
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest registerRequest)
        {
            var identityUser = new IdentityUser
            {
                UserName = registerRequest.UserName,
                Email = registerRequest.UserName
            };

           var identityResult= await userManager.CreateAsync(identityUser, registerRequest.Password);

            if (identityResult.Succeeded)
            {
                //Add Roles to this User
                if (registerRequest.Roles != null && registerRequest.Roles.Any())
                {
                   identityResult = await userManager.AddToRoleAsync(identityUser, registerRequest.Roles);

                    if (identityResult.Succeeded)
                    {
                        return Ok("User Registered Successfully");
                    }
                }
            }

            return BadRequest("Something Went Wrong");


        }


        //POST: /api/Auth/Login
        [HttpPost]
        [Route("Login")]

        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            var user= await userManager.FindByEmailAsync(loginRequest.UserName);

            if (user != null)
            {
                var checkPasswordResult= await userManager.CheckPasswordAsync(user, loginRequest.Password);

                if (checkPasswordResult)
                {

                    // Get Roles for the user
                    var roles = await userManager.GetRolesAsync(user);


                    if (roles != null)
                   /* {


                        // Create Token

                       var jwtToken = tokenRepository.CreateJWTToken(user, roles.ToList());

                        var response = new LoginResponse
                        {
                            JwtToken = jwtToken
                        };
                        return Ok(Response);


                    }*/












































                    return Ok();
                }
            }
            return BadRequest("UserName or Password incorrect");
        }
    }
}
