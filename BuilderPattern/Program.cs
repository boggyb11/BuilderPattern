using BuilderPattern.Builders;
using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SandwichBuilder builder;

            Shop shop = new Shop();

            builder = new BltBuilder();
            shop.Make(builder);
            builder.Sandwich.ListIngredients();

            builder = new FullBreakfastBuilder();
            shop.Make(builder);
            builder.Sandwich.ListIngredients();

            builder = new CheeseHamTomatoBuilder();
            shop.Make(builder);
            builder.Sandwich.ListIngredients();

            Console.ReadKey();
        }
    }
}
