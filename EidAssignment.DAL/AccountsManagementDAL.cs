using EidAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EidAssignment.DAL
{
   public class AccountsManagementDAL
    {
        private readonly EidiAssignmentContext db = new EidiAssignmentContext();

        public User Login(User user)
        {
            var DbUser = db.Users.Where(x => x.Email == user.Email && x.Password == user.Password).FirstOrDefault();
            return DbUser;
        }
        public void Register(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

    }
}
