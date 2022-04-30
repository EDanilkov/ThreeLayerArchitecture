using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User.API.DataAccess.Entities;

namespace User.API.DataAccess.Contextes
{
    public class UserDbContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }

        public UserDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
