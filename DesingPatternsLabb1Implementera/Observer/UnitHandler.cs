using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternsLabb1Implementera.Observer
{
    // The Subject interface declares a set of methods for managing subscribers.
    internal class UnitHandler : IObservable<Unit>
    {
        private readonly List<IObserver<Unit>> _observers;
        public List<Unit> Units { get; set; }

        public UnitHandler()
        {
            _observers = new();
            Units = new();
        }

        public IDisposable Subscribe(IObserver<Unit> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);

                foreach (var units in Units)
                {
                    observer.OnNext(units);
                }
            }
            return new Unsubscribe(_observers, observer);
        }

        public void AddUnit(Unit unit)
        {
                Units.Add(unit);

                foreach (var observer in _observers)
                {
                    observer.OnNext(unit);
                }
        }
        public void ClearUnits()
        {
            Units.Clear();
        }
    }
}
