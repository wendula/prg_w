using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zviratka
{
    internal class Program
    {
        class Animal
        {
            public string name;
            public int maxAge;
            public virtual void make_noise()
            {
                Console.WriteLine("*animal noises*");
            }
        }
        class Dog : Animal
        {
            public string breed;
            public override void make_noise()
            {
                Console.WriteLine("*woof woof*");
            }
        }
        class Cat : Animal
        {
            public string fur_color;
            public override void make_noise()
            {
                Console.WriteLine("*meow meow*");
            }
        }
        static void Main(string[] args)
        {
            Animal newAnimal = new Animal();
            newAnimal.make_noise();

            Dog newDog = new Dog();
            newDog.name = "Fido";
            newDog.maxAge = 14;
            newDog.breed = "jack russel terier";
            Console.WriteLine($"{newDog.name} is a {newDog.breed} and can turn {newDog.maxAge} years old.");
            newDog.make_noise();
            Cat newCat = new Cat();
            newCat.name = "Eduardo";
            newCat.fur_color = "grey";
            Console.WriteLine($"{newCat.name} has {newCat.fur_color} colored fur.");

            Console.ReadKey();
        }
    }
}
