using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Fly
{
    class ReactiveFlying : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("WwwwZHZHZHZHZHZH... like a rocket");
        }
    }
}
