using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternsLabb1Implementera.Observer
{
    // The Subject interface declares a set of methods for managing subscribers.
    internal class UnitManager : IObserver<Unit>
    {
        public string Name { get; set; }
        public List<Unit> Units { get; set; }
        
        private IDisposable _unsubscriber;
        
        public UnitManager(string name)
        {
            Name = name;
            Units = new();
        }

        public void BroadCastTo()
        {
            if (Units.Any())
            {
                foreach (var item in Units)
                {
                    Console.WriteLine($"║ Broadcast to {Name,-50} ║");
                }
            }
        }

        public void ListUnits()
        {
            if (Units.Any())
            {
                foreach (var item in Units)
                {
                    Console.WriteLine($"║ Requested {item.UnitName,-53} ║");
                    Console.WriteLine($"║ Broadcasted to {Name,-48} ║");
                    Console.WriteLine($"║ Time of Broadcast: {item.TimeOfRequest,-44} ║");
                }
            }
        }

        public virtual void Subscribe(UnitHandler provider)
        {
            _unsubscriber = provider.Subscribe(this);
        }
        
        public virtual void Unsubscribe()
        {
            _unsubscriber.Dispose();
            Units.Clear();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(Unit unit)
        {
            Units.Add(unit);
        }

        public void OnCompleted()
        {
            this.Unsubscribe();
        }
    }
}
