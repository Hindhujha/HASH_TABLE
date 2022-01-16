using System;
namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO HASH TABLE PROBLEMS");
            MyMapNode<int, string> hash = new MyMapNode<int, string>(5);
            hash.Add(0, "TO");
            hash.Add(1, "BE");
            hash.Add(2, "OR");
            hash.Add(3, "NOT");
            hash.Add(4, "TO");
            hash.Add(5, "BE");
            string hash5 = hash.Get(5);
            Console.WriteLine("5th index value is:" + hash5);
            string hash3 = hash.Get(3);
            Console.WriteLine("3rd index value is:" + hash3);
        }
    }
}
