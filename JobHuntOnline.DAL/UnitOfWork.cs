using JobHuntOnline.DAL.models;
using JobHuntOnline.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHuntOnline.DAL
{
   public class UnitOfWork
    {

        AccountRepository _accountRepository;
        UserRepository _userRepository;
        JobHuntOnlineEntities dbContext;


        public UnitOfWork(DbContext dbContext)
        {
            this.dbContext = dbContext as JobHuntOnlineEntities;
        }

        public AccountRepository accountRepository
        {
            get
            {
                if(_accountRepository == null)
                {
                    _accountRepository = new AccountRepository(dbContext);
                    
                }
                return _accountRepository;
            }
        }

        public UserRepository userRepository
        {
            get
            {
                if(_userRepository == null)
                {
                    _userRepository = new UserRepository(dbContext);
                }

                return _userRepository;
            }
        }

        public void SaveChanges()
        {
            dbContext.SaveChanges();
        }
    }
}
