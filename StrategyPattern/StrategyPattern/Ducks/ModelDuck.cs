using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Fly;
using StrategyPattern.Quack;

namespace StrategyPattern.Ducks
{
    class ModelDuck : Duck
    {
        public ModelDuck()
        {
            setFlyBehavior(new NoFly());
            setQuackBehavior(new NoQuack());
        }

        internal override void display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
