using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;

namespace CSharp_Fundamentals;

class Program
{
    static void Main(string[] args)
    {
        int age = 20;
        int number = 50;
        IncreaseAge(ref number);
        Console.WriteLine(age);
        Console.WriteLine(number);
        
    }

    public static void IncreaseAge(ref int age)
    {
        age++;
       // Console.WriteLine("age of method " + age);
    }
}
