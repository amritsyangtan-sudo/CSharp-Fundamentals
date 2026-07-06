using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;

namespace CSharp_Fundamentals;

class Program
{
    static void Main(string[] args)
    {
        
    }
}

class Factory<T>
{
    public T Create(T value)
    {
        return value;
    }
}
