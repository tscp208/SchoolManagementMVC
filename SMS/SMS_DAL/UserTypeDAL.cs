using SMS_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS_Common;
using System.Data;
using System.Data.SqlClient;

namespace SMS_DAL
{
    public class UserTypeDAL
    {
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();

        public List<UserTypeEntity> GetUserTypes()
        {
            List<UserTypeEntity> userTypes = new List<UserTypeEntity>();

            //Database interaction
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.dbConnection))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("usp_GetUserTypes", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand = cmd;
                        da.Fill(dt);
                    }
                }

                userTypes = dt.AsEnumerable().Select(item => new UserTypeEntity()
                {
                    SrNo = Convert.ToInt32(item["Srno"]),
                    UserTypeID = Convert.ToInt32(item["UserTypeID"]),
                    UserTypeName = Convert.ToString(item["UserTypeName"]),
                    UserTypeDesc = Convert.ToString(item["userTypeDesc"])
                }).ToList();

                return userTypes;
            }
            catch (Exception ex)
            {
                return new List<UserTypeEntity>();
            }
            finally
            {
                dt = null;
            }
        }

        public UserTypeEntity GetUserTypeByID(int userTypeID)
        {

            return new UserTypeEntity();
        }
    }
}
