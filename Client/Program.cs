using ChainOfResponsibility.ConcreteHandlers;
using ChainOfResponsibility.Handler;
using ChainOfResponsibility.Request;
using Observer;
using Strategy;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ElevatorDesignPattern;
using StateDesignPattern;

namespace Client
{
  class Program
  {
    static void Main(string[] args)
    {
      #region Chain of Responsibility
      //Request request = new Request(3, "Need approval from HR");
      //Handler leader = new LeadHandler();
      //Handler manager = new ManagerHandler();
      //Handler hr = new HRHanndler();

      //leader.SetSuccessor(manager);
      //manager.SetSuccessor(hr);

      //leader.HandleRequest(request);
      #endregion

      #region Observer
      //IPublisher publisher = new Publisher();
      //ISubscriber subscriber1 = new Subscriber1();
      //ISubscriber subscriber2 = new Subscriber2();

      //publisher.Subscribe(subscriber1);
      //publisher.Subscribe(subscriber2);

      //publisher.InverntoryCount++;
      #endregion

      #region Strategy
      //IStrategy strategy = new Algorithm1();
      //Context context = new Context(strategy);
      //context.ContextMethod();

      //strategy = new Algorithm2();
      //context = new Context(strategy);
      //context.ContextMethod();

      //strategy = new Algorithm3();
      //context = new Context(strategy);
      //context.ContextMethod();
      #endregion

      #region Facade
      //Facade.Facade facade = new Facade.Facade();
      //facade.Interface1Method();
      //facade.Interface2Method();
      //facade.Interface3Method();
      #endregion

      #region State
      //// Setup context in a state
      //TraficSignal c = new TraficSignal(new Red());

      //// Issue requests, which toggles state
      //c.Request();
      //c.Request();
      //c.Request();
      //c.Request();
      //c.Request();
      //c.Request();
      //c.Request();
      //c.Request();
      //c.Request();
      #endregion

      #region Elevator Design Pattern
      Start:
      Console.WriteLine("Welcome to Saurabh's Elevator");
      Console.WriteLine("How many floors does you building has: ");
      int floor;
      string floorString;
      string QUIT = "q";
      Elevator elevator;

      floorString = Console.ReadLine();

      if (Int32.TryParse(floorString, out floor))
      {
        elevator = new Elevator(floor);
      }
      else
      {
        Console.WriteLine("Thats not a valid input");
        Console.Beep();
        Console.Clear();
        goto Start;
      }

      string input = string.Empty;

      while (!input.Equals(QUIT))
      {
        Console.WriteLine("Enter the floor you want to go");
        input = Console.ReadLine();

        if (Int32.TryParse(input, out floor))
          elevator.FloorPressed(floor);
        else if (input == QUIT)
          Console.WriteLine("GoodBye!");
        else
          Console.WriteLine("You have pressed an incorrect floor, Please try again");
      }


      #endregion

      Console.WriteLine();
    }
  }
}
