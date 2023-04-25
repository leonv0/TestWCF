using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using Interfaces;
using System.Runtime.Serialization;

namespace WCF_Console_Client
{
    [DataContract]
    [Serializable]
    public class TestObject2 : ITestObject2
    {
        int _id;
        private string _name;
        [DataMember]
        public int Id { get; set; }/*
        { get { return _id; } 
          set {_id = value;} 
        }*/
        [DataMember]
        public string Name { get; set; }
        /*
        {
            get { return _name; }
            set
            {
                if (value == null)
                { throw new ArgumentNullException("Name not null"); }
                _name = value;
            }
        }*/
    }
}
