
namespace BuilderPattern
{
    abstract class SandwichBuilder
    {
        protected Sandwich sandwich;

        public Sandwich Sandwich
        {
            get { return sandwich; }
        }

        public abstract void AddBread();
        public abstract void AddFilling();
        public abstract void AddSauce();
    }
}
