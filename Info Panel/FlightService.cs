using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;


namespace Info_Panel
{
    class FlightService
    {
        private  List<FlightModels> flights = new List<FlightModels>();
        
        public void AddFlight(FlightModels flight)
        {
            flights.Add(flight);
        }

        public void RemoveFlight()
        {
           
        }

        public void EditFlight(FlightModels flight)
        {

        }

        void Show()
        {
            ICollection<FlightModels> t;
            ICollection<FlightModels> v;
            foreach (var flight in flights)
            {
                switch (flight.FType)
                {
                        case FlightTypes.Arrival:
                        t.Add(flight);
                        break;
                }
            }

        }

    }
    
}
