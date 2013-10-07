using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer;
using ServiceLayer;

namespace BusinessLayer
{
    public class ManagerMember
    {
        /// <summary>
        /// This is the business manager for the member domain object. The manager 
        /// calls the service layer functions for the class.
        /// </summary>
        /// <param name="memb"> member object</param>
        public void InsertMember(Member memb)
        {
            var memberRepo = ServiceLayer.Factory.Creates("Member");
            memberRepo.Insert(memb);
        }

        public void Update(Member memb)
        {
            var memberRepo = ServiceLayer.Factory.Creates("Member");
            memberRepo.Update(memb);
        }

        public void Delete(Member memb)
        {
            var memberRepo = ServiceLayer.Factory.Creates("Member");
            memberRepo.Delete(memb);
        }

        public IQueryable<Member> GetAll()
        {
            var memberRepo = ServiceLayer.Factory.Creates("Member");
            return (memberRepo.GetAll().OfType<Member>());
        }

        public IQueryable<Member> SearchByFirstName(string firstName)
        {
            var memberRepo = ServiceLayer.Factory.Creates("Member");
            return (memberRepo.GetBySpecificKey("FirstName", firstName).OfType<Member>());
        }

        public IQueryable<Member> SearchByLastName(string lastName)
        {
            var memberRepo = ServiceLayer.Factory.Creates("Member");
            return (memberRepo.GetBySpecificKey("LastName", lastName).OfType<Member>());
        }
    }
}
