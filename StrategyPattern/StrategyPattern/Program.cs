using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Ducks;
using StrategyPattern.Fly;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> pond = new List<Duck>();//пруд с уточками
            pond.Add(new MallardDuck());
            pond.Add(new ModelDuck());

            foreach(Duck duck in pond)
            {
                duck.display();
                duck.performQuack();
                duck.performFly();
                Console.WriteLine("");
            }
            Console.WriteLine("Load force");
            Console.WriteLine("Ready to start!");
            Console.WriteLine("");
            Duck forced = new ModelDuck();
            forced.setFlyBehavior(new ReactiveFlying());

            forced.display();
            forced.performQuack();
            forced.performFly();

            Console.ReadKey();

        }


    }
}
