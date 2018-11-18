using JobHuntOnline.DAL.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHuntOnline.DAL.Repositories
{
   public class AccountRepository : GenericRepository<AspNetUser>
    {

        JobHuntOnlineEntities dbContext;
        public AccountRepository(DbContext dbContext) :base(dbContext)
        {
            this.dbContext = dbContext as JobHuntOnlineEntities;

        }
        public List<AspNetRole>GetRoles()
        {
            return dbContext.AspNetRoles.ToList();
        }
    }
}
