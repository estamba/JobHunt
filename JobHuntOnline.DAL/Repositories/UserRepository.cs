using JobHuntOnline.DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHuntOnline.DAL.Repositories
{
   public class UserRepository : GenericRepository<Candidate>
    {
        JobHuntOnlineEntities dbContext;
        public UserRepository(JobHuntOnlineEntities dbContext) :base(dbContext)
        {
            this.dbContext = dbContext;
        }
        public void AddEmployer(Employer employer)
        {
            dbContext.Employers.Add(employer);
        }
    }
}
