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
            string strSource = " change ";
            char[] destinationValue = { 'T', 'h', 'e', ' ', 'i', 'n', 'i', 't', 'i', 'a', 'l', ' ','a', 'r', 'r', 'a', 'y' };

            Console.WriteLine(_destination.SetChar(destinationValue));

            strSource.CopyTo(0, destinationValue, 4, strSource.Length);

            Console.WriteLine(destinationValue);

<<<<<<< HEAD

            strSource = " Result Output";
=======
            strSource = "A different string";

            strSource.CopyTo(2, destinationValue, 3, 9);
>>>>>>> development

            Console.WriteLine(destinationValue);
            Console.ReadKey();

        }
    }
}
