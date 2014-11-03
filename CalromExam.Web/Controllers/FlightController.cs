using CalromExam.BL.RepositoryInterfaces;
using CalromExam.Models.Flight;
using CalromExam.Web;
using System.Web.Mvc;

namespace CalromExam.Controllers
{
    public class FlightController : Controller
    {
        private IFlightRepository _flightRepository;

        public FlightController()
        {
            _flightRepository = IoCManager.Resolve<IFlightRepository>();
        }
        public ActionResult Index()
        {           
            FlightModel model = new Models.Flight.FlightModel()
            {
                FlightEntities = _flightRepository.FlightEntities
            };

            return View(model);
        }

        public string HelloWord()
        {
            return "Hello World for Calrom Exam!!!";
        }
    }
}
