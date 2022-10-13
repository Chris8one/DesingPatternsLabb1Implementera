using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternsLabb1Implementera.Observer
{
    internal class Unit
    {
        public string UnitName { get; set; }
        public string OperatorInstance { get; set; }
        public DateTime TimeOfRequest { get; set; }
        public Unit(string unitName, string operatorInstance, DateTime timeOfRequest)
        {
            {
                UnitName = unitName;
                OperatorInstance = operatorInstance;
                TimeOfRequest = timeOfRequest;
            }
        }
    }
}
