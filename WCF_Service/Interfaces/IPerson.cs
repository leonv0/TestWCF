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

    public interface IPerson
    {
        string Flight_Number { get; set; }
        TimeSpan Flight_Sheduled_Time { get; set; }
        DateTime Flight_Sheduled_Date { get; set; }
        DateTime? Estimate_Arrival { get; set; }
        DateTime? Arrival { get; set; }
        string Name { get; set; }
        string Reservation_Number { get; set; }
        string DocumentNumber { get; set; }
    }


}
