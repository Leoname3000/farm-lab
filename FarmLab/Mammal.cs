
namespace FarmLab
{
    class Mammal : Animal
    {
        public Mammal(string name, uint age, double foodAmount, double weight) : base(name, age, foodAmount) 
        {
            this.weight = weight;
        }

        double weight;
        public double Weight { get { return weight; } }

        public override uint FoodRation()
        {
            if (weight < 5.0)
                return 1;
            else if (weight < 10.0)
                return 2;
            else
                return 3;
        }
    }
}
