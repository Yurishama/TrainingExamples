﻿using System;
using NUnit.Framework;

namespace unit_tests_csharp.P01CoreRunner
{
  public class Ex04RepeatedTests
  {
    private readonly Random _current = new Random(DateTime.UtcNow.Millisecond);

    //non-deterministic test
    [Test]//[Repeat(100)] //running multiple times helps in diagnosis:
    public void ShouldBeGreaterThan10()
    {
      //GIVEN
      int buggyVariable = _current.Next(0, 100);

      //THEN
      Assert.Greater(buggyVariable, 10); //low chance of happening
    }
  }
}
