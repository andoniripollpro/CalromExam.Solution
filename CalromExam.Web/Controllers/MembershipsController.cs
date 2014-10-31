using CalromExam.DAL.Repositiries;
using CalromExam.Models.Flight;
using CalromExam.Models.Membership;
using System.Web.Mvc;

namespace CalromExam.Controllers
{
    public class MembershipController : Controller
    {
        public ActionResult Index()
        {
            //TODO: Iversion of control using Ninject
            MembershipRepository membershipRepository = new MembershipRepository();
            MembershipModel model = new MembershipModel()
            {
                MembershipEntities = membershipRepository.MembershipEntities
            };

            return View(model);
        }

        public string HelloWord()
        {
            return "Hello World for Calrom Exam!!!";
        }
    }
}
