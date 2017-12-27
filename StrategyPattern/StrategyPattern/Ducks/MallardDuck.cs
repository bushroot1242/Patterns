using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Fly;
using StrategyPattern.Quack;

namespace StrategyPattern.Ducks
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            setFlyBehavior(new FlyWithWings());
            setQuackBehavior(new SimpleQuack());
        }

       
        internal override void display()
        {
            Console.WriteLine("Hello!!! I'm a Mallard Duck");
        }
    }
}
