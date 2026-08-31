using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interfaces.Swimbehavior;

namespace StrategyPattern.Ducks
{
    internal class RobotDuck : Duck
    {
        public RobotDuck()
        {
            swimBehavior = new Diving();            
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Robot Duck BZZZZZ");
        }
    }
}
