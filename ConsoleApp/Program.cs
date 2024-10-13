using HasAIDiscountStrategyClassLibrary;
using StrategyConcreteClasses;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shopping shopping = new Shopping();
            
            shopping.setDiscountStrategy(new FixedDiscountStrategy());
            Console.WriteLine(shopping.calculatePrice(100));

            shopping.setDiscountStrategy(new NoDiscountStrategy());
            Console.WriteLine(shopping.calculatePrice(100));

            shopping.setDiscountStrategy(new PercentageDiscountStrategy(30));
            Console.WriteLine(shopping.calculatePrice(100));

        }
    }
}
