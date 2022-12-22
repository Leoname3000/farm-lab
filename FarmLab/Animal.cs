
namespace FarmLab
{
    abstract class Animal
    {   
        public Animal(string name, uint age, double foodAmount)
        {
            this.name = name;
            this.age = age;
            this.foodAmount = foodAmount;
        }

        protected string name;
        public string Name { get { return name; } }

        protected uint age;
        public uint Age { get { return age; } }

        protected double foodAmount;
        public double FoodAmount { get { return foodAmount; } }

        public abstract uint FoodRation();
    }
}
