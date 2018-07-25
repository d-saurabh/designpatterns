using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfResponsibility.Request;

namespace ChainOfResponsibility.ConcreteHandlers
{
  public class HRHanndler : Handler.Handler
  {
    public override void HandleRequest(Request.Request request)
    {
      if (request.Value == 2)
      {
        Console.WriteLine($"Request handle by HR Manager");
      }
      else
      {
        _succesor.HandleRequest(request);
      }
    }
  }
}
