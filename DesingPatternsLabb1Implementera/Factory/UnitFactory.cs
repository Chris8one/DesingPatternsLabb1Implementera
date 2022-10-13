using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternsLabb1Implementera.Factory
{
    // Factory Design Pattern to choose which unit to create
    internal class UnitFactory
    {
        public static IUnit GetUnit(string unit)
        {
            IUnit Unit = null;

            if (unit == "Police Units")
            {
                Unit = new PoliceUnits();
            }
            else if (unit == "All Units")
            {
                Unit = new AllUnits();

            }
            else if (unit == "Medics")
            {
                Unit = new Medic();

            }
            else if (unit == "K-9 Unit")
            {
                Unit = new K9Unit();
            }
            else if (unit == "Air Support")
            {
                Unit = new AirSupport();
            }
            else if (unit == "S.W.A.T-Team")
            {
                Unit = new SWAT();
            }
            
            return Unit;
        }
    }
}
