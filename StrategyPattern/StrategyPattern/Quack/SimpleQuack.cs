using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Quack
{
    class SimpleQuack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack - quack");
        }
    }
}
