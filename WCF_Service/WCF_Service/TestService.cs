using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace WCF_Service
{
    public class TestService : Interfaces.ITestService
    {
        public string EchoTest(string msg)
        {
            return string.Format("Test reply: {0}", msg);
        }

        //public System.Threading.Tasks.Task<string> EchoTestAsync(string msg)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
