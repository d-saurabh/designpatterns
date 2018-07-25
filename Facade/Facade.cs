using Facade.SubSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
  public class Facade: Interface1,Interface2,Interface3
  {
    Interface1 interface1;
    Interface2 interface2;
    Interface3 interface3;
    public Facade()
    {
      interface1 = new Class1();
      interface2 = new Class2();
      interface3 = new Class3();
    }

    public void Interface1Method()
    {
      interface1.Interface1Method();
    }

    public void Interface2Method()
    {
      interface2.Interface2Method();
    }

    public void Interface3Method()
    {
      interface3.Interface3Method();
    }
  }
}
