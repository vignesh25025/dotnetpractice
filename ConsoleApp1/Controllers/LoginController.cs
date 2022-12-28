using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ConsoleApp1.Controllers
{
    [Route("api/login")]
    public class LoginController : ControllerBase
    {
        [HttpGet]
        public string GetToken()
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.UTF8.GetBytes("a861eac2-2894-435e-be89-56e29822ebe1");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new List<Claim> { 
                    new Claim("UserName","Test User"),
                    new Claim("role","Admin")
                }),
                Expires = DateTime.UtcNow.AddHours(10),
                Audience = "https://localhost:9090",
                Issuer = "https://localhost:9090",
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
