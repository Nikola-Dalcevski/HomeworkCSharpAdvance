using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class03
{
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }
        public Chip DogChip { get; set; }

        public void AddChip(Chip chip)
        {
            DogChip = chip;
        }

        public static void IdentifyDog(Dog dog)
        {
            if (dog.DogChip != null) Console.WriteLine($"Now the dog {dog.Name} has owner {dog.DogChip.Owner} on the {dog.DogChip.Address} with id: {dog.DogChip.ID}");
            else Console.WriteLine($"The dog {dog.Name} is {dog.Age} years old and its {dog.Color} color");
           
        }
           
                                                 


                           

        public class Chip
        {
            public int ID { get; set; }
            public string Owner { get; set; }
            public string Address { get; set; }

            public Chip(string owner, string adress)
            {
                Owner = owner;
                Address = adress;
                Random rd = new Random();
                ID = rd.Next(1000, 9999);
                
            }
        }
    }
}
