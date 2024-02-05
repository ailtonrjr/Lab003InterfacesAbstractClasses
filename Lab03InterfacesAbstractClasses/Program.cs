using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace Lab03InterfacesAbstractClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            //To test the program, ask the user for a dog name and create a new Dog type object from the Main of the program.
            //Give the Dog object a name, colour and age
            Dog dog1 = new Dog();
            Console.WriteLine("Please insert the dog's name: ");
            string userDogsName = Console.ReadLine();
            dog1.Name = userDogsName;

            Console.WriteLine("Please insert the dog's age: ");
            string userDogsAge = Console.ReadLine();
            dog1.Age = int.Parse(userDogsAge);

            Console.WriteLine("Please insert the dog's colour: ");
            string userDogsColour = Console.ReadLine();
            dog1.Colour = userDogsColour;

            //and then execute the getter methods to print these properties .
            Console.WriteLine("Dog's information\n");
            Console.WriteLine(dog1);

            //and the Eat methods
            dog1.Eat();

            //Repeat the previous step for a Cat object.
            Cat cat1 = new Cat();

            Console.WriteLine("Please insert the cat's name: ");
            string userCatsName = Console.ReadLine();
            cat1.Name = userCatsName;

            Console.WriteLine("Please insert the cat's age: ");
            string userCatsAge = Console.ReadLine();
            cat1.Name = userCatsAge;

            Console.WriteLine("Please insert the cat's colour: ");
            string userCatsColour = Console.ReadLine();
            cat1.Name = userCatsColour;

            Console.WriteLine("Cat's information\n");
            Console.WriteLine(cat1);
            cat1.Eat();
        }
    }
}
