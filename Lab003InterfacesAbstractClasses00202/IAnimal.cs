using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Lab003InterfacesAbstractClasses00202
{
    //Using C# IDE, create a program that implements an IAnimal interface
    public interface IAnimal
    {
        //The interface has the properties: Name, Colour, Height and Age.
        public string Name { get; set; }
        public string Colour { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }

        //The interface has the following methods: 
        //A method called "Eat"
        public abstract void Eat();
        //A method called "Cry"
        public string Cry();
    }
}
