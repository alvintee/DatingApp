using API.Entities;

namespace API.Interfaces
{
    public interface ITokenService
    {
         string Createtoken(AppUser user);
    }
}