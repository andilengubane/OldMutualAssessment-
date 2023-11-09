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
            char[] destinationValue = { 'T', 'h', 'e', ' ', 'r', 'e', 's', 'u', 'l', 't', ' ', 's', 'e', 't', ' ', 'a','r','r','a','y' };

            Console.WriteLine(_destination.SetChar(destinationValue));

            strSource.CopyTo(0, destinationValue, 3, strSource.Length);

            Console.WriteLine(destinationValue);


            strSource = " Result Output";

            strSource.CopyTo(0, destinationValue, 3, 14);
           
            Console.WriteLine(destinationValue);
            Console.ReadKey();

        }
    }
}
