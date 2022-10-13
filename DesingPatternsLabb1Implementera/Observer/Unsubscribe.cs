using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternsLabb1Implementera.Observer
{
    internal class Unsubscribe : IDisposable
    {
        private readonly List<IObserver<Unit>> _observers;
        private readonly IObserver<Unit> _observer;

        public Unsubscribe(List<IObserver<Unit>> observers, IObserver<Unit> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
            {
                _observers.Remove(_observer);
            }
        }
    }
}
