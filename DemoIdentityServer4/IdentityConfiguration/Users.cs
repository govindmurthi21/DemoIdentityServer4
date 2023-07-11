using System.Security.Claims;
using IdentityModel;
using IdentityServer4.Test;

namespace DemoIdentityServer4.IdentityConfiguration;

public class Users
{
    public static List<TestUser> Get()
    {
        return new List<TestUser> 
        {
            new TestUser 
            {
                SubjectId = "56892347",
                Username = "govind",
                Password = "password",
                Claims = new List<Claim> 
                {
                    new Claim(JwtClaimTypes.Email, "govind.murthi21@gmail.com"),
                    new Claim(JwtClaimTypes.Role, "admin"),
                    new Claim(JwtClaimTypes.WebSite, "https://google.com")
                }
            }
        };
    }
}