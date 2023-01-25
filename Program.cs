
//using System;
//namespace Cmehtod
//{
//    public class Program
//    {
//        static void Main()
//        {
//            var animal1 = new Animal();
//            animal1.name = "Archi";
//            animal1.breed = "dog";
//            animal1.color = "brown";
//            animal1.age = 5;
//            Console.WriteLine(animal1.GetDetails());

//            var animal2 = new Animal();
//            animal2.name = "lucy";
//            animal2.breed = "cat";
//            animal2.color = "yellow";
//            animal2.age = 3;
//            Console.WriteLine(animal2.GetDetails());

//        }
//    }
//}

using System;
namespace Cmethod
{
    public class Program
    {
        static void Main()
        {
            Building building3 = new Building("Chinar plaza",100,400);
            Console.WriteLine(building3.GetDetails());
        }
    }
}

