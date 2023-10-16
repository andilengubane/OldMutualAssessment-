using OldMutual.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldMutual.Service
{
    public class Copier
    {
        private readonly IDestination destination1;
        private readonly ISource source;

        public Copier(ISource _source, IDestination _destination)
        {
            destination1 = _destination;
            source = _source;
        }

        public void Copy() { 
        
        }
    }
}
