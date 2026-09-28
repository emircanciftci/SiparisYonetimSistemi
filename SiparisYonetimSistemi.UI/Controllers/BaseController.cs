using SiparisYonetimSistemi.BLL.Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiparisYonetimSistemi.UI.Controllers
{
    public class BaseController : Controller
    {
        protected EntityService service = new EntityService();
    }
}