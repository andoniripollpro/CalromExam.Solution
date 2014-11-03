using CalromExam.BL;
using CalromExam.BL.RepositoryInterfaces;
using System.Collections.Generic;

namespace CalromExam.DAL.Repositiries
{
    public class FlightRepository : IFlightRepository
    {
        public List<FlightEntity> FlightEntities
        {
            get
            {
                List<FlightEntity> flightEntities = new List<FlightEntity>();
                CalromExamEntities calromExamEntities = new CalromExamEntities();
                AutoMapper.Mapper.CreateMap<FlightData, FlightEntity>();

                foreach (FlightData oneFlightData in calromExamEntities.FlightData)
                {
                    flightEntities.Add(AutoMapper.Mapper.Map<FlightEntity>(oneFlightData));
                }

                return flightEntities;
            }
        }
    }
}
