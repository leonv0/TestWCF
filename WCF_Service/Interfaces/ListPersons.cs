using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.Runtime.Serialization;

namespace Interfaces
{
    [DataContract]
    public class ListPersons
    {
        //List<IPerson> _lstPers;
        
        [DataMember(Name = "PersonList")]
        List<Person> _lstPers { get; set; }

        public ListPersons()
        {
            _lstPers = new List<Person>();
        }
        public void Add(Person person)
        {
            _lstPers.Add(person);
        }
    }
}
