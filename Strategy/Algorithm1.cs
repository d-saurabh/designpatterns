using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
  public class Algorithm1 : IStrategy
  {
    public void PerformAlgorithm()
    {
      Console.WriteLine("Alsorithm A executed");
    }
  }
}
