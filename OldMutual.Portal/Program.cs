using System;

namespace OldMutual.Portal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string strSource = "changed";
            char[] destination = { 'T', 'h', 'e', ' ', 'i', 'n', 'i', 't', 'i', 'a', 'l', ' ', 'a', 'r', 'r', 'a', 'y' };

            Console.WriteLine(destination);

            strSource.CopyTo(0, destination, 4, strSource.Length);
        
            Console.WriteLine(destination);

            strSource = "A different string";

            strSource.CopyTo(2, destination, 3, 9);

            Console.WriteLine(destination);
        }
    }
}
