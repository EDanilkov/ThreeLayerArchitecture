using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace User.API.DataAccess.Entities
{
    public class UserEntity
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool IsBlocked { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
