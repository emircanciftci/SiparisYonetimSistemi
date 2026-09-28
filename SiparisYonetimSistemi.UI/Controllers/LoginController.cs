using SiparisYonetimSistemi.UI.Attribute;
using SiparisYonetimSistemi.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiparisYonetimSistemi.UI.Controllers
{
    public class LoginController : BaseController
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginController(LoginVM gelen)
        {
            if(ModelState.IsValid)
            {
                if(service.UserService.logincontrol(gelen.UserName,gelen.Password))
                {
                    User use = service.UserService.FindUserName(gelen.UserName);
                    SessionContext _sessionsContext = new SessionContext()
                    {
                        ID = use.ID,
                        UserName = use.UserName,
                        ImageURL = use.ImageURL
                    };
                    Session["SessionContext"] = _sessionsContext;
                    return Json(true,JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(false, JsonRequestBehavior.AllowGet);
                }
            }
            else
            {
                return Redirect("/Login/Index");
            }
    }
}