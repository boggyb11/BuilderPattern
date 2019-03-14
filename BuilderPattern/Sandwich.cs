using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    class Sandwich
    {
        private string _Name;
        public List<string> ingredients;

        public Sandwich(string name)
        {
            this._Name = name;
            ingredients = new List<string>();
        }

        public void ListIngredients()
        {
            Console.WriteLine($"\n{_Name}: ");
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine(ingredient);
            }
        }
    }
}
