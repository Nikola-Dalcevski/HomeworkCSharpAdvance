using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static class03.Dog;

namespace class03
{
    public static class Shelter
    {
        public static Queue<Dog> DogShelter = new Queue<Dog>();

        public static void AddDog(Dog dog)
        {
            Console.WriteLine("Dog is added in shelter");
            DogShelter.Enqueue(dog);
        }


        public static Dog  AdoptDog(string owner , string address)
        {
            Console.WriteLine("Dog is realised  from the shelter and addopted");
            Chip chip = new Chip(owner, address);
            var addoptedDog =  DogShelter.Dequeue();
            addoptedDog.AddChip(chip);
            return addoptedDog;
        }

        public static void ShowShelterDogs()
        {
            Console.WriteLine($"in this moment in shelter have {DogShelter.Count} dogs :");
          
            foreach (var dog in DogShelter)
            {
                
                Console.WriteLine($" - {dog.Name} is {dog.Race} and it's {dog.Age} years old");
            }
        }


    }
}
