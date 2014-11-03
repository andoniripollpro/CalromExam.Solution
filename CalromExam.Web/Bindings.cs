using CalromExam.BL.RepositoryInterfaces;
using CalromExam.Controllers;
using CalromExam.DAL.Repositiries;
using Ninject.Modules; 

namespace CalromExam.Web
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            //this.Kernel.Components.Add<INinjectHttpApplicationPlugin, NinjectMvcHttpApplicationPlugin>();
            Bind<IMembershipRepository>().To<MembershipRepository>();
            Bind<IFlightRepository>().To<FlightRepository>();
        }
    }
}