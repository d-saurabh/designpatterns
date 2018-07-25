using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorDesignPattern
{
  public class Elevator
  {
    #region Private variables

    private int _maxFloorNumber;
    private int _currentFloor = 1;
    private ElevatorStatus _status;
    private bool[] _floorReady;
    #endregion

    #region Property

    public ElevatorStatus ElevatorStatus
    {
      get { return _status; }
      set { _status = value; }
    }

    #endregion

    #region Constructor

    public Elevator(int maxFloor)
    {
      _floorReady = new bool[maxFloor + 1];
      _maxFloorNumber = maxFloor;
    }
    #endregion

    #region Public methods 

    public void FloorPressed(int floor)
    {
      if (floor > _maxFloorNumber)
      {
        Console.WriteLine("Floor doesn't exists...");
        return;
      }

      _floorReady[floor] = true;

      switch (ElevatorStatus)
      {
        case ElevatorStatus.UP:
          MoveUp(floor);
          break;

        case ElevatorStatus.DOWN:
          MoveDown(floor);
          break;

        case ElevatorStatus.STOPPED:
          if (floor > _currentFloor)
            MoveUp(floor);
          else if (floor == _currentFloor)
            StayIdeal();
          else
            MoveDown(floor);
          break;
      }
      Console.WriteLine("Now Waiting...");
    }

    public void MoveUp(int floor)
    {
      for (int i = _currentFloor; i <= _maxFloorNumber; i++)
      {
        if(_floorReady[i])
          Stop(floor);
        else
          continue;
      }
    }

    public void MoveDown(int floor)
    {
      for (int i = _currentFloor; i >= 1; i--)
      {
        if (_floorReady[i])
          Stop(floor);
        else
          continue;
      }
    }

    public void StayIdeal()
    {
      Console.WriteLine("You are at the same floor");
    }
    #endregion

    #region Private methods

    private void Stop(int floor)
    {
      _floorReady[floor] = false;
      _status = ElevatorStatus.STOPPED;
      _currentFloor = floor;
    }
    #endregion

  }
}
