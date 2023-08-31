using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Self_ordaring_sys.Models;
using System.Net;
using System.Security.Claims;

namespace Self_ordaring_sys.Controlllers
{
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AuthController (UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpPost("Register")]

        public async Task<IActionResult> registerMethod (User userModel) {
        
            var user = await _userManager.FindByEmailAsync (userModel.Email);

            if (user != null)
            {
                return StatusCode(StatusCodes.Status403Forbidden,new {msg="this account is already exist"});
            }

            var newUser = new IdentityUser {

                UserName = userModel.UserName,
                Email = userModel.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                PhoneNumber = userModel.Phone.ToString(),
            };
            var request = await _userManager.CreateAsync(newUser, userModel.Password);
            if (request.Succeeded) {

                var claim = new Claim($"Address", $"{userModel.Address}");
                await _userManager.AddClaimAsync(newUser, claim);

                var claim2 = new Claim($"FullName", $"{userModel.Name}");
                await _userManager.AddClaimAsync(newUser, claim2);
                var roles = new[] { userModel.UserType };
                var dd =  await _userManager.AddToRolesAsync(newUser, roles);

                return Ok(dd);
            }
            

            return BadRequest(request.Errors);
        
        }
    }
}
