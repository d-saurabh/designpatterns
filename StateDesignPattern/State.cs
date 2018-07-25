using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
  public abstract class State
  {
    public abstract void Handle(TraficSignal context);
  }
}
