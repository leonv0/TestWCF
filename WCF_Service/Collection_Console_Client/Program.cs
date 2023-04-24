using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Console_Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestCollection data = new TestCollection
            {
                ObjectCollection = new List<ITestObject>
            {
                new TestObject { Id = 1, Name = "Send 1" },
                new TestObject { Id = 2, Name = "Send 2" },
                new TestObject { Id = 3, Name = "Send 3" }
            }
            };
            using (CollectionServiceClient client = new CollectionServiceClient())
            {
                var res = client.GetObject();
                //Console.WriteLine(res.ObjectCollection.Count.ToString());
                Console.ReadLine();
            }
        }
    }
}
