using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
  public class Family1Factory : AbstractFactory
  {
    public override IProduct CreateProductA()
    {
      return new Family1ProductA();
    }

    public override IProduct CreateProductB()
    {
      return new Family1ProductB();
    }
  }
}
