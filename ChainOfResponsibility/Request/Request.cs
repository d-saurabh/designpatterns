using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Request
{
  public class Request : IRequest
  {
    private int _value;
    private string _description;
    public string Description => _description;

    public int Value => _value;
    public Request(int value,string description)
    {
      _value = value;
      _description = description;
    }
  }
}
