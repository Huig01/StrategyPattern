using System.Security.Cryptography.X509Certificates;
using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            //performDuck(mallardDuck);
            //mallardDuck.PerformQuack();
            //mallardDuck.PerformFly();
            //mallardDuck.PerformSwim();
            Duck redheadDuck = new RedheadDuck();
            //performDuck(redheadDuck);
            Duck decoyDuck = new DecoyDuck();
            //decoyDuck.PerformQuack();
            //decoyDuck.PerformFly();
            Duck rubberDuck = new RubberDuck();
            //rubberDuck.PerformQuack();
            //rubberDuck.PerformFly();
            Duck robotDuck = new RobotDuck();
            //robotDuck.Display();
            //robotDuck.PerformSwim();
            Duck model = new ModelDuck();
            //model.PerformFly();
            //model.SetFlyBehavior(new FlyRocketPowered());
            //model.PerformFly();           
        }
        //public static void performDuck(Duck duck)
        //{
        //    duck.Display();
        //    duck.PerformSwim();
        //    duck.PerformFly();
        //    duck.PerformQuack();

        //    duck.SetFlyBehavior(new FlyRocketPowered());            
        //}
    }
}