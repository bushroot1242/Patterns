using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Quack;
using StrategyPattern.Fly;



namespace StrategyPattern.Ducks
{
    public abstract class Duck
    {
        public Duck()
        {

        }

        private FlyBehavior flyBehavior;


        private QuackBehavior quackBehavior;
        internal void performQuack()
        {
            quackBehavior.quack();
        }
        internal void performFly()
        {
            flyBehavior.fly();
        }
        internal void swim()
        {
            Console.WriteLine("That water so cold!");
        }
        internal abstract void display();

        internal void setFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }

        internal void setQuackBehavior(QuackBehavior qb)
        {
            quackBehavior = qb;
        }
    }
}
