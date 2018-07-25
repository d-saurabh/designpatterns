using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
  /*Defines a one-to-many dependency between objects so that when one object changes state, 
   * all its dependents are notified and updated automatically.
   */
  public interface IPublisher
  {
    int InverntoryCount { get; set; }
    void Subscribe(ISubscriber subscriber);

    void UnSubscribe(ISubscriber subscriber);

    void Notify();
  }
}
