using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab003InterfacesAbstractClasses00202
{
    //Create a Dog class that implements the IAnimal interface.
    //The Eat method should print “Dogs eat meat” and the “Cry” method should print “Woof!”
    public class Dog : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }
        
        //Default constructor
        public Dog() { }

        //The Eat method should print "Dogs eat meat"
        public void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }

        //and the "Cry" method should print "Woof!"
        public string Cry()
        {
            return "Woof!";
        }
        public override string ToString()
        {
            return $"Dog's name: {Name}\nDog's Height: {Height}\nDog's colour: {Colour}\nDog's age: {Age}";

        }
    }
}
