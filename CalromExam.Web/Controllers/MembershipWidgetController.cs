using CalromExam.DAL.Repositiries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalromExam.Web.Controllers
{
    public class MembershipWidgetController : Controller
    {
        public ActionResult Index()
        {            
            //TODO: Iversion of control using Ninject
            MembershipRepository membershipRepository = new MembershipRepository();

            return View(membershipRepository.MembershipEntities);
        }
    }
}
