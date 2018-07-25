using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
  /*Define a family of algorithms, encapsulate each one, and make them interchangeable. 
   * Strategy lets the algorithm vary independently from clients that use it.
   */
  public interface IStrategy
  {
    void PerformAlgorithm();
  }
}
