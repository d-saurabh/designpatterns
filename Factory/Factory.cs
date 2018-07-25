using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
  /*Intent
   * creates objects without exposing the instantiation logic to the client.
   * refers to the newly created object through a common interface
   */
  public class Factory
  {
    public IProduct GetProduct(int id)
    {
      switch (id)
      {
        case 1:
          return new Product1();
        case 2:
          return new Product2();
        case 3:
          return null;
      }
      return null;
    }
  }
}
