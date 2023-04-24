using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IListPersons
    {
        IPerson[] lstPers { get; set; }
    }
}
