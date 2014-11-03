using System.Collections.Generic;

namespace CalromExam.BL.RepositoryInterfaces
{
    public interface IFlightRepository
    {
        List<FlightEntity> FlightEntities { get; }
    }
}
