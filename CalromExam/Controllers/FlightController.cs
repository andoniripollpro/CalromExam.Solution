using CalromExam.DAL.Repositiries;
using CalromExam.Models.Flight;
using System.Web.Mvc;

namespace CalromExam.Controllers
{
    public class FlightController : Controller
    {
        public ActionResult Index()
        {
            //TODO: Iversion of control using Ninject
            FlightRepositoy flightRepository = new FlightRepositoy();
            FlightModel model = new Models.Flight.FlightModel()
            {
                FlightEntities = flightRepository.FlightEntities
            };

            return View(model);
        }

        public string HelloWord()
        {
            return "Hello World for Calrom Exam!!!";
        }
    }
}
