using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternsLabb1Implementera.Factory
{
    internal class PoliceUnits : IUnit
    {
        public string GetUnitName()
        {
            return "Police Units";
        }
    }
}
