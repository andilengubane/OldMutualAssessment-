using OldMutual.Service;
using OldMutual.Service.Interface;
using System;

namespace OldMutual.Portal
{
    class Program
    {
       public static IDestination _destination = new Destination();
       
        static void Main(string[] args)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            Console.WriteLine("Hello World!");

            string strSource = "changed";
            char[] destination = { 'T', 'h', 'e', ' ', 'i', 'n', 'i', 't', 'i', 'a', 'l', ' ', 'a', 'r', 'r', 'a', 'y' };

            Console.WriteLine(destination);

            strSource.CopyTo(0, destination, 4, strSource.Length);
        
=======
             
            
            string strSource = "changed";
            char[] destination = { 'T', 'h', 'e', ' ', 'i', 'n', 'i', 't', 'i', 'a', 'l', ' ', 'a', 'r', 'r', 'a', 'y' };
=======
            string strSource = " change ";
            char[] destinationValue = { 'T', 'h', 'e', ' ', 'r', 'e', 's', 'u', 'l', 't', ' ', 's', 'e', 't', ' ', 'a','r','r','a','y' };
>>>>>>> development

            Console.WriteLine(_destination.SetChar(destinationValue));

            strSource.CopyTo(0, destinationValue, 3, strSource.Length);

            Console.WriteLine(destinationValue);

<<<<<<< HEAD
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
=======
            strSource = " Result Output";

            strSource.CopyTo(0, destinationValue, 3, 14);
           
            Console.WriteLine(destinationValue);
            Console.ReadKey();
>>>>>>> development
        }
    }
}
