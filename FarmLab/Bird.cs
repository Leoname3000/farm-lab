
namespace FarmLab
{
    class Bird : Animal
    {
        public Bird(string name, uint age, double foodAmount, double weight, double wingspan) : base(name, age, foodAmount)
        {
            this.weight = weight;
            this.wingspan = wingspan;
        }

        double weight { get; }
        public double Weight { get { return weight; } }

        double wingspan { get; }
        public double Wingspan { get { return wingspan; } }

        public override uint FoodRation()
        {
            return 1;
        }
    }
}
