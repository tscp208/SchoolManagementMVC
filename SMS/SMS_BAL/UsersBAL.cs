using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS_DAL;
using SMS_Entities;

namespace SMS_BAL
{
    public class UsersBAL
    {
        public UsersDAL userdal = new UsersDAL();

        public List<UsersEntity> GetUsers()
        {
            return userdal.GetUsers();
        }

    }
}
