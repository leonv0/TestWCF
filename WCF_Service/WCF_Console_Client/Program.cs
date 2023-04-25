using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Console_Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestServiceClient test = new TestServiceClient();
            //string res = test.EchoTest("Send");
            //Console.WriteLine(res);
            WCF_Service.TestObject2 param = new WCF_Service.TestObject2 { Id = 2, Name = "Send 2" };
            var res2 = test.GetObject();
            Console.WriteLine(res2.Name.ToString());
            var res3 = test.SaveObject(param);
            Console.WriteLine(res3.Name.ToString());
            Console.ReadLine();
        }
    }
}
