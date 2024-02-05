using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03InterfacesAbstractClasses
{
    //Create a Cat class that implements the above Animal class 
    public class Cat : Animal
    {
        public Cat() { }

        //and the Eat method that prints "Cats eat mice"
        public override void Eat()
        {
            Console.WriteLine("Cats eat mice");
        }
    }
}
