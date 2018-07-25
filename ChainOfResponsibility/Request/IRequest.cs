using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Request
{
  public interface IRequest
  {
    int Value { get;}

    string Description { get; }
  }
}
