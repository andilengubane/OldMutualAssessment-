using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using OldMutual.Service.Interface;

namespace OldMutual.Service
{
    public class Destination : IDestination
    {
        public void SetChar(char[] character)
        {
            char[] destination = { 'a', 'b', 'c' };
        } 
    }
}
