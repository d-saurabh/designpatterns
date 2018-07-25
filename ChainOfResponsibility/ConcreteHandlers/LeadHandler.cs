using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfResponsibility.Request;

namespace ChainOfResponsibility.ConcreteHandlers
{
  public class LeadHandler : Handler.Handler
  {
    public override void HandleRequest(Request.Request request)
    {
      if(request.Value==0)
      {
        Console.WriteLine($"Request handle by Lead");
      }
      else
      {
        _succesor.HandleRequest(request);
      }
    }
  }
}
