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
            //PARAGRAPH
            hash.Add(6, "PARANOIDS");
            hash.Add(7, "ARE");
            hash.Add(6, "NOT");
            hash.Add(8, "PARANOID");
            hash.Add(9, "BECAUSE");
            hash.Add(10, "THEY");
            hash.Add(11, "KEEP");
            hash.Add(12, "PUTTING");
            hash.Add(13, "THEMSELVES");
            hash.Add(14, "DELIBERATELY");
            hash.Add(15, "INTO");
            hash.Add(16, "PARANOID");
            hash.Add(17, "AVOIDABLE");
            hash.Add(18, "SITUATIONS");
            string hash10 = hash.Get(5);
            Console.WriteLine("10th index value is:" + hash10);
            string hash15 = hash.Get(3);
            Console.WriteLine("15th index value is:" + hash15);
            //REMOVE A WORD IN A PARAGRAHP
            hash.Remove(17);
            string hash17 = hash.Get(17);
            Console.WriteLine("17th index value is removed" + hash17);



        }
    }
}
