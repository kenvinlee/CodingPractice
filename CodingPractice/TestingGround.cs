using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice
{
    class TestingGround
    {
        static void Main(string[] args)
        {
            String testInput;
            String testInput2;
            StringAlgs strAlgs = new StringAlgs();

            Console.WriteLine("Enter a string");
            testInput = Console.ReadLine();
            Console.WriteLine("Enter another string");
            testInput2 = Console.ReadLine();
            Console.WriteLine(strAlgs.isAnagram(testInput, testInput2));
            

            Console.WriteLine("Press [Enter] to exit");
            Console.Read();
        }
    }
}
