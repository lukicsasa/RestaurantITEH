using Restaurant.Data.Entities;
using Restaurant.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Data.Repositories
{
    public class RoleRepository : GenericRepository<User>
    {
        public RoleRepository(DbContext dbContext) : base(dbContext) { }

    }
}
