using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User.API.DataAccess.Entities;
using User.API.Interfaces.Repositories;
using User.API.Models;

namespace User.API.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task<Guid> CreateAsync(UserModel resource)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(string resourceId)
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> GetByIdAsync(string resourceId)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> UpdateAsync(UserModel resource)
        {
            throw new NotImplementedException();
        }
    }
}
