using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
  public class Green:State
  {
    public override void Handle(TraficSignal context)
    {
      context.State = new Orange();
    }
  }
}
