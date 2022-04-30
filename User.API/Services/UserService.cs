using System;
using System.Threading.Tasks;
using User.API.Interfaces.Services;
using User.API.Models;

namespace User.API.Services
{
    public class UserService : IUserService
    {
        public Task<Guid> CreateAsync(UserModel resource)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(UserModel resource)
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> GetAsync(Guid resourceId)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> UpdateAsync(UserModel resource)
        {
            throw new NotImplementedException();
        }
    }
}
