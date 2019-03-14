
namespace BuilderPattern
{
    class BltBuilder : SandwichBuilder
    {
        public BltBuilder()
        {
            sandwich = new Sandwich("BLT");
        }

        public override void AddBread()
        {
            sandwich.ingredients.Add("White Bread");
        }

        public override void AddFilling()
        {
            sandwich.ingredients.Add("Bacon");
            sandwich.ingredients.Add("Lettuce");
            sandwich.ingredients.Add("Tomato");
        }

        public override void AddSauce()
        {
            sandwich.ingredients.Add("Ketchup");
        }
    }
}
