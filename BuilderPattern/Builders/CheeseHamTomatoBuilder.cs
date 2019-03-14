using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Builders
{
    class CheeseHamTomatoBuilder : SandwichBuilder
    {
        public CheeseHamTomatoBuilder()
        {
            sandwich = new Sandwich("Cheese Ham & Tomato");
        }

        public override void AddBread()
        {
            sandwich.ingredients.Add("White Bread");
        }

        public override void AddFilling()
        {
            sandwich.ingredients.Add("Cheese");
            sandwich.ingredients.Add("Ham");
            sandwich.ingredients.Add("Tomato");
        }

        public override void AddSauce()
        {
            
        }
    }
}
