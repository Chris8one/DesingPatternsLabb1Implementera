using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternsLabb1Implementera
{
    // Singleton Design Pattern to create only one instance of the PoliceOfficer class
    internal class PoliceOfficers
    {
        private static readonly PoliceOfficers instance = new PoliceOfficers();
        private List<string> officers = new List<string>();

        private PoliceOfficers()
        {
            officers.Add("Cpl. Chris Munson");
            officers.Add("PO. Jason Voorhees");
        }

        public static PoliceOfficers GetInstance()
        {
            return instance;
        }

        public string GetOfficer(string officer)
        {
            string officerChoice = officers.Where(o => o.Contains(officer)).FirstOrDefault();

            return officerChoice;
        }
            
    }
}
