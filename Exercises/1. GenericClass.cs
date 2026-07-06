// class Program
// {
//     static void Main(string[] args)
//     {
//         Register<int> number = new Register<int>();
//         number.Add(1);
//         number.Add(5);
//         number.Add(6);

//         List<int> results = number.ShowResult();
//         foreach(var a in results)
//         {
//             System.Console.WriteLine(a);
//         }
//     }


// }

// class Register<T>
// {
//     public List<T> list = new List<T>();

//     public void Add(T item)
//     {
//         list.Add(item);
//     }

//     public List<T> ShowResult()
//     {
//         return list;
//     }
// }