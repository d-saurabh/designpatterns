using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfResponsibility.Request;

namespace ChainOfResponsibility.Handler
{
  public abstract class Handler
  {
    protected Handler _succesor;

    public void SetSuccessor(Handler handler)
    {
      _succesor = handler;
    }

    public abstract void HandleRequest(Request.Request request);
  }
}
