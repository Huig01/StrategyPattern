using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.Swimbehavior;

namespace StrategyPattern.Ducks
{
    internal abstract class Duck
    {
        protected QuackBehavior? quackBehavior;
        protected FlyBehavior? flyBehavior;
        protected SwimBehavior? swimBehavior;
        public abstract void Display();

        public void PerformQuack()
        {
            quackBehavior?.Quack();
        }
        public void PerformSwim()
        {
            swimBehavior?.Swim();
        }
        public void PerformFly()
        {
            flyBehavior?.Fly();
        }
    }
}
