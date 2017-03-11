using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info_Panel
{
    public enum FlightTypes
    {
        Arrival,
        Departure
    };
    class FlightModels
    {
        public int Id { get; set; }
        public string FNumber { get; set; }
        public string AirLine { get; set; }
        public string TerminalGate { get; set; }
        public string City { get; set; }
        public DateTime FTime { get; set; }
        public FlightTypes FType { get; set; }

        public FlightModels(int Id, string FNumber, string AirLine, string City, string TerminalGate, DateTime FTime, FlightTypes FType)
        {
            this.Id = Id;
            this.FNumber = FNumber;
            this.AirLine = AirLine;
            this.City = City;
            this.TerminalGate = TerminalGate;
            this.FTime = FTime;
            this.FType = FType;
        }
        public override string ToString()
        {
            return $"{Id} - {FNumber} - {AirLine} - {City} - {TerminalGate} - {FTime}";
        }
    }
}
