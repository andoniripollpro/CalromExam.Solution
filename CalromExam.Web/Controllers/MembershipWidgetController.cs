using CalromExam.BL.RepositoryInterfaces;
using System.Web.Mvc;

namespace CalromExam.Web.Controllers
{
    public class MembershipWidgetController : Controller
    {
        private IMembershipRepository _membershipRepository;

        public MembershipWidgetController()
        {
            _membershipRepository = IoCManager.Resolve<IMembershipRepository>();
        }

        public ActionResult Index()
        {
            return View(_membershipRepository.MembershipEntities);
        }
    }
}
