using _21._04._2024.Models;
using static _21._04._2024.Models.Animal;

namespace _21._04._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wolf canavar = new Wolf(10, "Toyuq", 15, Gender.male, false, 12);
            Wolf qurd = new Wolf(9, "Keci", 70, Gender.female, false, 12);
            Elephant fil = new Elephant(22, "Cirkli", 310, Gender.male, 678.1d, false);


            Meat et = new Meat(345, Meat.Type.baccon);
            Grass ot = new Grass(123, "Yonca");

            var wolfCage = new ZooCage<Wolf, Meat>(canavar, et);

            var elephantCage = new ZooCage<Elephant, Grass>(fil, ot);

            var wolfCage2 = new ZooCage<Wolf, Grass>(qurd, ot);
            canavar.Hunt<Wolf>(qurd);



        }
    }
}
