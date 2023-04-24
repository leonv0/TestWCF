using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.Runtime.Serialization;
using Interfaces.ImportService;

namespace Interfaces
{
    /*
    [DataContract]
    public class ListPersons
    {
        //List<IPerson> _lstPers;
        
        [DataMember(Name = "PersonList")]
        Person[] _lstPers { get; set; }

        public ListPersons()
        {
            _lstPers = Person[];
        }
        public void Add(Person person)
        {
            _lstPers.Add(person);
        }
    }
    */
    namespace ImportService
    {
        using System.Runtime.Serialization;

        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "Person", Namespace = "http://schemas.datacontract.org/2004/07/Interfaces")]
        public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private System.Nullable<System.DateTime> ArrivalField;

            private string DocumentNumberField;

            private System.Nullable<System.DateTime> Estimate_ArrivalField;

            private string Flight_NumberField;

            private System.DateTime Flight_Sheduled_DateField;

            private System.TimeSpan Flight_Sheduled_TimeField;

            private string NameField;

            private string Reservation_NumberField;

            public System.Runtime.Serialization.ExtensionDataObject ExtensionData
            {
                get
                {
                    return this.extensionDataField;
                }
                set
                {
                    this.extensionDataField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.Nullable<System.DateTime> Arrival
            {
                get
                {
                    return this.ArrivalField;
                }
                set
                {
                    this.ArrivalField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string DocumentNumber
            {
                get
                {
                    return this.DocumentNumberField;
                }
                set
                {
                    this.DocumentNumberField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.Nullable<System.DateTime> Estimate_Arrival
            {
                get
                {
                    return this.Estimate_ArrivalField;
                }
                set
                {
                    this.Estimate_ArrivalField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string Flight_Number
            {
                get
                {
                    return this.Flight_NumberField;
                }
                set
                {
                    this.Flight_NumberField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.DateTime Flight_Sheduled_Date
            {
                get
                {
                    return this.Flight_Sheduled_DateField;
                }
                set
                {
                    this.Flight_Sheduled_DateField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public System.TimeSpan Flight_Sheduled_Time
            {
                get
                {
                    return this.Flight_Sheduled_TimeField;
                }
                set
                {
                    this.Flight_Sheduled_TimeField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string Name
            {
                get
                {
                    return this.NameField;
                }
                set
                {
                    this.NameField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public string Reservation_Number
            {
                get
                {
                    return this.Reservation_NumberField;
                }
                set
                {
                    this.Reservation_NumberField = value;
                }
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name = "ListPersons", Namespace = "http://schemas.datacontract.org/2004/07/Interfaces")]
        public partial class ListPersons : object, System.Runtime.Serialization.IExtensibleDataObject
        {

            private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

            private Person[] PersonListField;

            public System.Runtime.Serialization.ExtensionDataObject ExtensionData
            {
                get
                {
                    return this.extensionDataField;
                }
                set
                {
                    this.extensionDataField = value;
                }
            }

            [System.Runtime.Serialization.DataMemberAttribute()]
            public Person[] PersonList
            {
                get
                {
                    return this.PersonListField;
                }
                set
                {
                    this.PersonListField = value;
                }
            }
        }


        
}
