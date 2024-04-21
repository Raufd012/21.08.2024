

namespace _21._04._2024.Models
{
    internal class Elephant : Animal
    {
        private double _weight;

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        private bool _istranied;

        public bool IsTrained
        {
            get { return _istranied; }
            set { _istranied = value; }
        }


        public Elephant(int avglifetime, string breed, int healtpoint, Gender gender, double weight, bool istrained) : base(avglifetime, breed, healtpoint, gender)
        {
            Weight = weight;
            IsTrained = istrained;
        }

    }
}
