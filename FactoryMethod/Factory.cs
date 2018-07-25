using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
  /*Intent
   * Defines an interface for creating objects, 
   * but let subclasses to decide which class to instantiate
   * Refers to the newly created object through a common interface
   */

  public abstract class Factory
  {
    public abstract IProduct GetProduct();
  }
}
