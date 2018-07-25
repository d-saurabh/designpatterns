using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
  public class Family2Factory : AbstractFactory
  {
    public override IProduct CreateProductA()
    {
      return new Family2ProductA();
    }

    public override IProduct CreateProductB()
    {
      return new Family2ProductB();
    }
  }
}
