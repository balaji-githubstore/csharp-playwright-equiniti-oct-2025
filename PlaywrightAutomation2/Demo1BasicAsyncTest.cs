using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;

namespace EQ.PlaywrightAutomation
{
    public class Demo1BasicAsyncTest
    {
        public async Task SayHello()
        {
            Console.WriteLine("before saying hello");
            await Task.Delay(5000);
            Console.WriteLine("hello!!!");
            Console.WriteLine("---------------------------");
        }

        [Test]
        public async Task RunTestAsync()
        {
            await SayHello();
            await SayHello();
        }


        public async Task<string> GetNameAsync()
        {
            Console.WriteLine("before return name");
            await Task.Delay(5000);
            return "Jack";
        }

        [Test]
        public async Task Run2TestAsync()
        {
            var demoVariable= GetNameAsync();
            //some other activity

            var demo2 = await demoVariable;

            Console.WriteLine(demoVariable);
        }
    }
}
