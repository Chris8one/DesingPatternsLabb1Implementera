using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternsLabb1Implementera
{
    // Singleton Design Pattern to create only one instance of the Options class is created
    internal class Options
    {
        private static readonly Options instance = new Options();
        private List<string> options = new List<string>();
        
        private Options()
        {
            options.Add("Speeding Ticket");
            options.Add("Littering Ticket");
            options.Add("APB Suspect");
            options.Add("APB Vehicle");
            options.Add("APB Receipt");
            options.Add("Shots Fired");
            options.Add("K-9 Unit");
            options.Add("Air Support");
            options.Add("S.W.A.T-Team");
        }

        public static Options GetInstance()
        {
            return instance;
        }

        public string GetOption(string option)
        {
            string optionChoice = options.Where(o => o.Contains(option)).FirstOrDefault();

            return optionChoice;
        }
    }
}
