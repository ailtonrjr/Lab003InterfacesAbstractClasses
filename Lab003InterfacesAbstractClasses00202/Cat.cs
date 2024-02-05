using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab003InterfacesAbstractClasses00202
{
    //Create a Cat class that implements the above IAnimal interface.
    public class Cat : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }
        public Cat() { }

        //The Eat method should print "Cats eat mice"
        public void Eat()
        {
            Console.WriteLine("Cats ear mice");
        }

        //and the "Cry" method should print "Meow!"
        public string Cry()
        {
            return "Meow!";
        }
        public override string ToString()
        {
            return $"Cat's name: {Name}\nCat's Height: {Height}\nCat's colour: {Colour}\nCat's age: {Age}";
        }

    }
}
