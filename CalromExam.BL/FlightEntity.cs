using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalromExam.BL
{
    public class FlightEntity
    {
        public int FlightDataId { get; set; }
        public string Destination { get; set; }
        public string FlightStatus { get; set; }
        public Nullable<System.DateTime> ArrivalDate { get; set; }
        public Nullable<int> FlownMiles { get; set; }
    }
}
