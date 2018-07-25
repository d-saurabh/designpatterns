using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
  public class Context
  {
    IStrategy _strategy;

    public Context(IStrategy strategy)
    {
      this._strategy = strategy;
    }

    public void ContextMethod()
    {
      _strategy.PerformAlgorithm();

    }
  }
}
