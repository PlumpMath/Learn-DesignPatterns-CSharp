﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.DesignPatterns._01_Strategy
{
  abstract class Duck
  {
    public IFlyBehavior flyBehavior { get; set; }
    public IQuackBehavior quackBehavior { get; set; }
    
    public abstract void display();

    public void PerformFly()
    {
      flyBehavior.fly();
    }

    public void PerformQuack()
    {
      quackBehavior.quack();
    }

    public void Swin()
    {
      Console.WriteLine("All ducks float, even decoys!");
    }
  }
}
