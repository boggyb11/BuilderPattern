
namespace BuilderPattern.Builders
{
    class FullBreakfastBuilder : SandwichBuilder
    {
        public FullBreakfastBuilder()
        {
            sandwich = new Sandwich("Full breakfast");
        }

        public override void AddBread()
        {
            sandwich.ingredients.Add("Brown bread");
        }

        public override void AddFilling()
        {
            sandwich.ingredients.Add("Bacon");
            sandwich.ingredients.Add("Eggs");
            sandwich.ingredients.Add("Sausage");
        }

        public override void AddSauce()
        {
            sandwich.ingredients.Add("Ketchup");
        }
    }
}
