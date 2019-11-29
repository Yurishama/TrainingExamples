﻿using System;

namespace ProceduralStateMachine.OtherServices
{
  public class DiningRoomLight : Light
  {
    public void PowerDown()
    {
      Console.WriteLine("It's getting dark");
    }

    public void PowerUp()
    {
      Console.WriteLine("It's getting brighter");
    }
  }
}