using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class03

{
    class Program
    {
        static void Main(string[] args)
        {
            Dog jecky = new Dog() { Name = "Jacky", Color = "White", Age = 4 };
            Dog.Chip chip = new Dog.Chip("Vukasin", "11 Oktomvri");
            Dog.IdentifyDog(jecky);
            jecky.AddChip(chip);
            Dog.IdentifyDog(jecky);
            
            
            Dog flock = new Dog() { Name = "Flock", Color = "Brown", Age = 4 , Race = "Shephard"};
            Dog liska = new Dog() { Name = "Liska", Color = "Black", Age = 2,  Race = "Rotfailer"};
            Dog aron = new Dog() { Name = "Aron", Color = "Black", Age = 5, Race = "Poodle" };
            Shelter.AddDog(flock);
            Shelter.AddDog(liska);
            Shelter.AddDog(aron);
            Shelter.ShowShelterDogs();

            Dog addopted1 = Shelter.AdoptDog("Nikola", "11Oktomvri");
            Dog.IdentifyDog(addopted1);              
            Shelter.ShowShelterDogs();



        



            Console.ReadLine();
        }
    }
}
