using SMS.Models.UserType;
using SMS_BAL;
using SMS_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMS.Controllers
{
    public class UserTypeController : Controller
    {
        public UserTypeBAL userTypeBAL = new UserTypeBAL();
        // GET: UserType
        public ActionResult Index()
        {

            return View(GetUserTypes());
        }
        
        public List<UserTypeViewModel> GetUserTypes()
        {
            List<UserTypeViewModel> userTypes = new List<UserTypeViewModel>();
            List<UserTypeEntity> userTypeEntities = new List<UserTypeEntity>();

            userTypeEntities = userTypeBAL.GetUserTypes();

            userTypes = userTypeEntities.Select(item => new UserTypeViewModel()
                        {
                            UserTypeID = item.UserTypeID,
                            SrNo = item.SrNo,
                            UserTypeName = item.UserTypeName,
                            UserTypeDesc = item.UserTypeDesc
                        }).ToList();

            return userTypes;
        }
    }
}