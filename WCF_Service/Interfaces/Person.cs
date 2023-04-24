using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    [DataContract]
    [Serializable]
    public class Person : Interfaces.IPerson
    {
        [DataMember]
        public string Flight_Number { get; set; }
        [DataMember]
        public TimeSpan Flight_Sheduled_Time { get; set; }
        [DataMember]
        public DateTime Flight_Sheduled_Date { get; set; }
        [DataMember]
        public DateTime? Estimate_Arrival { get; set; }
        [DataMember]
        public DateTime? Arrival { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Reservation_Number { get; set; }
        [DataMember]
        public string DocumentNumber { get; set; }

    }
}
 

