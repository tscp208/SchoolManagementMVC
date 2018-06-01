using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SMS_BAL;
using SMS.Models.Users;
using SMS_Entities;

namespace SMS.Controllers
{
    public class UsersController : Controller
    {
        public UsersBAL userBAL = new UsersBAL();

        // GET: Users
        public ActionResult Index()
        {
            return View();
        }

        public List<UsersBAL> GetUsers()
        {
            List<UsersModel> users = new List<UsersModel>();
            List<UsersEntity> userentity = new List<UsersEntity>();

            userentity = userBAL.GetUsers();
            users = userentity.Select(item => new UsersModel
                                    {

                                    }
                ).ToList();

        }


    }
}