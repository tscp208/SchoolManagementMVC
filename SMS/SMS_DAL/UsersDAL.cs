using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS_Entities;
using SMS_Common;
using System.Data.SqlClient;


namespace SMS_DAL
{
    public class UsersDAL
    {
        DataTable dt = new DataTable();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<UsersEntity> GetUsers()
        {
            List<UsersEntity> lstUsers = new List<UsersEntity>();
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.dbConnection))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_GetUsers", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
                lstUsers = dt.AsEnumerable().Select(item => new UsersEntity()
                            {
                                SrNo = Convert.ToInt32(item["Srno"]),
                                UserID = Convert.ToInt32(item["UserID"]),
                                UserName = Convert.ToString(item["UserName"]),
                                FirstName = Convert.ToString(item["FirstName"]),
                                LastName = Convert.ToString(item["LastName"]),
                                Gender = Convert.ToString(item["Gender"]),
                                Address = Convert.ToString(item["Address"]),
                                State = Convert.ToString(item["State"]),
                                City = Convert.ToString(item["City"]),
                                ContactNo = Convert.ToString(item["ContactNo"]),
                                EmailAddress = Convert.ToString(item["EmailAddress"]),
                                DOB = Convert.ToString(item["DOB"]),
                                UserTypeID = Convert.ToInt32(item["UserTypeID"]),
                                UserTypeName = Convert.ToString(item["UserTypeName"])
                            }
                    ).ToList();

                return lstUsers;
            }
            catch (Exception ex)
            {
                return new List<UsersEntity>();

            }
            finally
            {
                dt = null;
            }
        }

    }
}
