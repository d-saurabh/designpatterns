using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
  public class Algorithm3 : IStrategy
  {
    public void PerformAlgorithm()
    {
      Console.WriteLine("Alsorithm C executed");
    }
  }
}
