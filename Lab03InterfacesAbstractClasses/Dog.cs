using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03InterfacesAbstractClasses
{

    //Create a Dog class that implements the Animal class
    public class Dog : Animal
    {
        public Dog() { }

        //and the Eat method that prints "Dogs eat meat"
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat");
        }
    }
}
