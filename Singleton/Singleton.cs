using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
  /* Intent
   * Ensure that only one instance of a class is created.
   * Provide a global point of access to the object.
   */
  public class Singleton
  {
    private static Singleton _instance;
    private static object _lockObj = new object();
    private Singleton()
    {

    }
    //Early instantiation
    private static Singleton _instance_early = new Singleton();
    public static Singleton GetEarlyInstance => _instance_early;

    //Lazy instantiation 
    public static Singleton GetInstance()
    {
      if (_instance == null)
      {
        lock (_lockObj)
        {
          if (_instance == null)
          {
            _instance = new Singleton();
          }
        }
      }
      return _instance;
    }
  }
}
