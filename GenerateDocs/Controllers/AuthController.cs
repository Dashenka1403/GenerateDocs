using GenerateDocs.DbContexts;
using GenerateDocs.Models.Users;
using GenerateDocs.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace GenerateDocs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class AuthController : ControllerBase
    {
        /*   private List<User> _users = new List<User>
           {
               new User{Login = "admin2342", Password = "0000", Role = "Admin"},
               new User{Login = "user4444", Password = "1111", Role = "User"}
           };*/

        private ApplicationContext _context;

        public AuthController()
        {
            _context = new ApplicationContext();
        }

        [HttpPost("/register")]
        public IActionResult Register(string username, string password)
        {
            _context.Users.Add(new User
            {
                Login = username,
                Password = AuthUtils.HashPassword(password),
                Role = "rpd" //преподаватель
            });
            _context.SaveChanges();
            return Ok("Данные добавлены");
        }

        [HttpPost("/login")]
        public IActionResult Login(string username, string password, string role)
        {
            var identity = GetIdentity(username, password, role);
            if (identity == null)
            {
                return BadRequest(new { errorText = "Invalid data"});
            }
            var now = DateTime.UtcNow;
            var jwt = new JwtSecurityToken(
                issuer: AuthOptions.ISSUER,
                audience: AuthOptions.AUDIENCE,
                notBefore: now,
                claims: identity.Claims,
                expires: now.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)),
                signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256) 
             );
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);
            var response = new
            {
                acces_token = encodedJwt,
                username = identity.Name,
                role = identity.Claims.FirstOrDefault(c => c.Type.Contains("role"))?.Value
            };

            return Ok(JsonConvert.SerializeObject(response));
        }

        private ClaimsIdentity GetIdentity(string username, string password, string role)
        {
            var user = _context.Users.FirstOrDefault(u => u.Login == username);
             
            if (user == null)
            {
                return null;
            }
            if(!AuthUtils.VerifyPassword(password, user.Password)) 
            {
                return null;
            }

            var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, user.Login),
                    new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role)
                };
            var claimsIdentity
                = new ClaimsIdentity(claims, "Token",
                ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);
            return claimsIdentity;
        }
    }
}
