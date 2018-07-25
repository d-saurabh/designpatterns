using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
  public class TraficSignal
  {
    private State _state;

    public State State
    {
      get { return _state; }
      set
      {
        _state = value;
        Console.WriteLine("State: " +
          _state.GetType().Name);
      }
    }

    public TraficSignal(State state)
    {
      _state = state;
    }

    public void Request()
    {
      _state.Handle(this);
    }
  }
}
