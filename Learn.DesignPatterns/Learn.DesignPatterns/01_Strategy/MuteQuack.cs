﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.DesignPatterns._01_Strategy
{
  class MuteQuack : IQuackBehavior
  {
    public void quack()
    {
      Console.WriteLine("<< Silence >>");
    }
  }
}
