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

        public ActionResult GetUsers()
        {
            List<UsersViewModel> users = new List<UsersViewModel>();
            List<UsersEntity> userentity = new List<UsersEntity>();

            userentity = userBAL.GetUsers();
            users = userentity.Select(item => new UsersViewModel
                                    {
                                        UserID = item.UserID,
                                        SrNo = item.SrNo,
                                        UserName = item.UserName,
                                        FirstName = item.FirstName,
                                        LastName = item.LastName,
                                        Address = item.Address,
                                        Gender = item.Gender,
                                        State = item.State,
                                        City = item.City,
                                        ContactNo = item.ContactNo,
                                        Email = item.EmailAddress
                                    }
                                 ).ToList();
            return PartialView("_GetUsers", users);

        }

        public ActionResult InsertUser()
        {
            List<UsersViewModel> users = new List<UsersViewModel>();
            List<UsersEntity> userentity = new List<UsersEntity>();

            return View();
        }

    }
}