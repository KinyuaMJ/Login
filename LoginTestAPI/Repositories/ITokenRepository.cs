using Microsoft.AspNetCore.Identity;

namespace LoginTestAPI.Repositories
{
    public interface ITokenRepository
    {
       string CreateJWTToken(IdentityUser user, List<string> roles);
    }
}
