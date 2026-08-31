using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            mallardDuck.PerformQuack();
            mallardDuck.PerformFly();
            Duck redheadDuck = new RedheadDuck();
            Duck decoyDuck = new DecoyDuck();
            //decoyDuck.PerformQuack();
            //decoyDuck.PerformFly();
            Duck rubberDuck = new RubberDuck();
            //rubberDuck.PerformQuack();
            //rubberDuck.PerformFly();
        }
    }
}