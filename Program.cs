using StrategyPattern.Ducks;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            mallardDuck.PerformQuack();
            mallardDuck.PerformFly();
            mallardDuck.PerformSwim();
            Duck redheadDuck = new RedheadDuck();
            Duck decoyDuck = new DecoyDuck();
            //decoyDuck.PerformQuack();
            //decoyDuck.PerformFly();
            Duck rubberDuck = new RubberDuck();
            //rubberDuck.PerformQuack();
            //rubberDuck.PerformFly();
            Duck robotDuck = new RobotDuck();
            robotDuck.PerformSwim();
        }
    }
}