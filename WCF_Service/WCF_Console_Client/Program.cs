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
            string res = test.EchoTest("Send");
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
