using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Self_ordaring_sys.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;

namespace Self_ordaring_sys.Controlllers
{
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;

        public AuthController (UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
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


        [HttpPost("Login")]

        public async Task<IActionResult> loginMethod( [FromForm ]Login _login)
        {

            var user = await _userManager.FindByEmailAsync(_login.Email);
            if (user == null && await _userManager.CheckPasswordAsync(user,_login.Password))
            {
                return BadRequest(new { msg = "Account not found please register" });
            }

            var claims = new List<Claim>() {
            new Claim(ClaimTypes.Name, user.UserName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())};

            var role = await _userManager.GetRolesAsync(user);
            Claim clai = new (ClaimTypes.Role, role[0]);
            claims.Add(clai);
            var jwtToken = genetrateToken(claims);
            return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(jwtToken) , userType = role });

        }
        [Authorize]
        [HttpGet("test")]

        public async Task <IActionResult> testingAuthorize()
        {
            return Ok();
        }
        private JwtSecurityToken genetrateToken(List<Claim> claims)
        {

            var authKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("abcdefgh12345678"));

            JwtSecurityToken token = 
                new JwtSecurityToken(
                    claims: claims, expires: DateTime.Now.AddDays(1), 
                    signingCredentials: new SigningCredentials(authKey, SecurityAlgorithms.HmacSha256));
            return token;
        }
    }
}
