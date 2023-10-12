using OldMutual.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldMutual.Service
{
    public class Source : ISource 
    {
        public char GetChar() {
            char[] source = { 'a', 'b', 'c', '\n' };
            return 'a';
        }
    }
}
