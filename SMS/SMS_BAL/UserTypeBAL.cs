using SMS_DAL;
using SMS_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_BAL
{
    public class UserTypeBAL
    {
        public UserTypeDAL userTypeDAL = new UserTypeDAL();

        public List<UserTypeEntity> GetUserTypes()
        {
            return userTypeDAL.GetUserTypes();
        }

        public UserTypeEntity GetUserTypeByID(int userTypeID)
        {
            return userTypeDAL.GetUserTypeByID(userTypeID);
        }

        public bool UpdateUserType(UserTypeEntity userType)
        {

            if(userType.UserTypeID > 0)
            {
                //update
            }
            else
            {
                //Insert
            }
            return true;
        }
    }
}
