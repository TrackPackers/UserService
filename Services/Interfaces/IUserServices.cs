using UserService.Models;

namespace UserService.Services.Interfaces
{
    public interface IUserServices
    {
        public Task<string> deleteUser(UserBody userId);
    }
}
