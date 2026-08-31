using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.Swimbehavior
{
    internal class Swim : SwimBehavior
    {
        void SwimBehavior.Swim()
        {
            Console.WriteLine("Swimming");
        }
    }
}
