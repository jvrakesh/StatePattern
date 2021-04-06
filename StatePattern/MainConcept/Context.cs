using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.MainConcept
{
    public class Context
    {
        private IState _state;
        public Context(IState state)
        {
            this._state = state;
        }

        public void Request()
        {
            _state.Handle(this);
        }

        public IState State { 
            get
            {
                return _state;
            } 
            set
            {
                _state = value;
                Console.WriteLine("State: " + _state.GetType().Name);
            }
        }

      
    }
}
