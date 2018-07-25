using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
  public class Publisher : IPublisher
  {
    private List<ISubscriber> _subscribers = new List<ISubscriber>();
    private int _inventoryCount;
    public int InverntoryCount {
      get
      {
        return _inventoryCount;
      }
      set
      {
        if(value>_inventoryCount)
        {
          Notify();
        }
        _inventoryCount = value;
      }

    }

    public void Notify()
    {
      foreach (var subscriber in _subscribers)
      {
        subscriber.Update();
      }
    }

    public void Subscribe(ISubscriber subscriber)
    {
      _subscribers.Add(subscriber);
    }

    public void UnSubscribe(ISubscriber subscriber)
    {
      _subscribers.Remove(subscriber);
    }
  }
}
