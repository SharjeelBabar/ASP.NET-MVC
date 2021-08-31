using EidAssignment.DAL;
using EidAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EidAssignment.BAL
{
   public class AccountsManagementBAL
    {
        public User Login(User user)
        {
            return new AccountsManagementDAL().Login(user);
        } 
        public void Register(User user)
        {
            user.RoleId = 3;
            user.JoinedOn = DateTime.UtcNow.AddHours(5);
            new AccountsManagementDAL().Register(user);
        }
    }
}
