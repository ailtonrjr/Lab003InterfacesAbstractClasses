using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Net.NetworkInformation;
namespace Lab003InterfacesAbstractClasses00202
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //To test the program, ask the user for a dog name and create a new Dog type object from the Main of the program
            Console.WriteLine("Welcome!!!\nPlease choose a name for your dog: ");
            string userDogName = Console.ReadLine();
            Dog dog1 = new Dog();
            dog1.Name = userDogName;

            //Then ask the user to give the Dog object a name, height, colour and age
            Console.WriteLine($"Great!!! Now please choose the {userDogName}' height: ");
            string  userDogHeight = Console.ReadLine();
            dog1.Height = double.Parse(userDogHeight);

            Console.WriteLine($"Great!!! Now please choose the {userDogName}' colour: ");
            string userDogColour = Console.ReadLine();
            dog1.Colour = userDogColour;

            Console.WriteLine($"Great!!! Now please choose the {userDogName}' age: ");
            string userDogAge = Console.ReadLine();
            dog1.Age = int.Parse(userDogAge);

            //then execute the getter methods to print these properties and run the Eat and Cry methods
            Console.WriteLine("The dog's information:");
            Console.WriteLine(dog1.ToString());
            dog1.Eat();
            Console.WriteLine(dog1.Cry());

            //Repeat the previous step for a Cat object.
            Console.WriteLine("Welcome!!! Please choose a name for your cat: ");
            string userCatName = Console.ReadLine();
            Cat cat1 = new Cat();
            cat1.Name = userCatName;

            Console.WriteLine($"Great!!! Now please choose the {userCatName}' height: ");
            string userCatHeight = Console.ReadLine();
            cat1.Height = double.Parse(userCatHeight);

            Console.WriteLine($"Great!!! Now please choose the {userCatName}' colour: ");
            string userCatColour = Console.ReadLine();
            cat1.Colour = userCatColour;

            Console.WriteLine($"Great!!! Now please choose the {userCatName}' age: ");
            string userCatAge = Console.ReadLine();
            cat1.Age = int.Parse(userDogAge);

            Console.WriteLine("The cat's information:");
            Console.WriteLine(cat1.ToString());
            cat1.Eat();
            Console.WriteLine(cat1.Cry());

            //Create a list called “animals” and add some animal objects to the list 
            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(dog1);
            animals.Add(cat1);

            //Print the names of all the animals
            Console.WriteLine("These are the animals on the list:");
            foreach (IAnimal animal in animals)
            {
                Console.WriteLine(animal.Name);
            }

        }
    }
}
