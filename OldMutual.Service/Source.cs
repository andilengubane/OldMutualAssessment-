using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using OldMutual.Service.Interface;

namespace OldMutual.Service
{
    public class Source : ISource 
    {
        public char[] GetChar() {
            char[] source = { 'a', 'b', 'c', '\n' };
            return source;
        }
    }
}
