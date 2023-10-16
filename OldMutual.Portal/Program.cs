using System;

namespace OldMutual.Portal
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Console.WriteLine("Hello World!");

            string strSource = "changed";
            char[] destination = { 'T', 'h', 'e', ' ', 'i', 'n', 'i', 't', 'i', 'a', 'l', ' ', 'a', 'r', 'r', 'a', 'y' };

            Console.WriteLine(destination);

            strSource.CopyTo(0, destination, 4, strSource.Length);
        
=======
             
            
            string strSource = "changed";
            char[] destination = { 'T', 'h', 'e', ' ', 'i', 'n', 'i', 't', 'i', 'a', 'l', ' ', 'a', 'r', 'r', 'a', 'y' };


            IDestination.SetChar(destination);
            // Print the char array
            Console.WriteLine(destination);

            // Embed the source string in the destination string
            strSource.CopyTo(0, destination, 4, strSource.Length);

            // Print the resulting array
>>>>>>> development
            Console.WriteLine(destination);

            strSource = "A different string";

<<<<<<< HEAD
            strSource.CopyTo(2, destination, 3, 9);

            Console.WriteLine(destination);
=======
            // Embed only a section of the source string in the destination
            strSource.CopyTo(2, destination, 3, 9);

            // Print the resulting array
            Console.WriteLine(destination);

>>>>>>> development
        }
    }
}
