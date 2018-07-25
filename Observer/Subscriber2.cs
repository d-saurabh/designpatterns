using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
  public class Subscriber2:ISubscriber
  {
    public void Update()
    {
      Console.WriteLine($"Notification received for inventory update to {nameof(Subscriber2)}");
    }
  }
}
