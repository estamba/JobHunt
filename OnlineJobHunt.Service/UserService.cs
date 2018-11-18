using JobHuntOnline.DAL;
using JobHuntOnline.DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobHunt.Service
{
    public class UserService
    {

        UnitOfWork unitOfWork;
        public UserService(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public void AddEmployer(Employer employer)
        {
            unitOfWork.userRepository.AddEmployer(employer);
        }

        public void AddCandidate(Candidate candidate)
        {
            unitOfWork.userRepository.Insert(candidate);
        }
    }
}
