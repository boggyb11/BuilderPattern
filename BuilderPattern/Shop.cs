
namespace BuilderPattern
{
    class Shop
    {
        public void Make(SandwichBuilder sandwichBuilder)
        {
            sandwichBuilder.AddBread();
            sandwichBuilder.AddFilling();
            sandwichBuilder.AddSauce();
        }
    }
}
