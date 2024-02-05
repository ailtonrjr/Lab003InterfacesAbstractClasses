using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Lab03InterfacesAbstractClasses
{
    public abstract class Animal
    {
        //This class has the properties: Name, Colour and Age.
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Age { get; set; }

        //The class has the following methods: 
        //A method called Eat that is an abstract method of type void.
        public abstract void Eat();
       //Default constructor for the class Animal
        public Animal(){}

        public override string ToString()
        {
            return $"The name is: {Name}\nThe colour of {Name} is: {Colour}\nThe {Name}'s Age is: {Age}";
        }
    }
}
