using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;

namespace CSharp_Fundamentals;

class Program
{
    static void Main(string[] args)
    {
        int area;
        int perimeter;
        CalculateRectangle(10,20, out area, out perimeter);
        Console.WriteLine(area);
        Console.WriteLine(perimeter);  
        List<int> number = new List<int>();
    }

    public static void CalculateRectangle(int width, int height, out int area, out int perimeter)
    {
        area = width * height;
        perimeter = width * width;
    }

}
