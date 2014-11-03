using CalromExam.BL.RepositoryInterfaces;
using CalromExam.Models.Membership;
using CalromExam.Web;
using System.Web.Mvc;

namespace CalromExam.Controllers
{
    public class MembershipController : Controller
    {
        private IMembershipRepository _membershipRepository;

        public MembershipController()
        {
            _membershipRepository = IoCManager.Resolve<IMembershipRepository>();
        }

        public ActionResult Index()
        {
            MembershipModel model = new MembershipModel()
            {
                MembershipEntities = _membershipRepository.MembershipEntities
            };

            return View(model);
        }

        public string HelloWord()
        {
            return "Hello World for Calrom Exam!!!";
        }
    }
}
