using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    //[System.ServiceModel.ServiceContractAttribute(ConfigurationName = "ICSVImport")]
    public interface ICSVImport
    {
        //[System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICSVImport/EchoTest", ReplyAction = "http://tempuri.org/ICSVImport/EchoTestResponse")]

        void SaveCSV(Person pers);
    }
    
}
