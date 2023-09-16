using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UL.Common.Services.Implementations;
using UL.Common.Services.Interfaces;
using static System.Net.Mime.MediaTypeNames;

namespace UL.UnitTests.UnitTest
{
    [TestClass]
    public class FizzBuzzServiceUnitTest
    {
        
        private readonly IFizzBuzzService fizzBuzzService;
        public FizzBuzzServiceUnitTest()
        {

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices(services => { services.AddTransient<IFizzBuzzService, FizzBuzzService>(); })
                .Build();

            fizzBuzzService = host.Services.GetRequiredService<IFizzBuzzService>();
          
        }
        [TestMethod]
        public void WriteFizzBuzzTest()
        {
            var currentConsoleOut = Console.Out;
            using (var consoleOutput = new ConsoleOutput())
            {
                fizzBuzzService.WriteFizzBuzz();
                Assert.AreEqual("1\r\n2\r\nFizz\r\n4\r\nBuzz\r\nFizz\r\n7\r\n8\r\nFizz\r\nBuzz\r\n11\r\nFizz\r\n13\r\n14\r\nFizzBuzz\r\n16\r\n17\r\nFizz\r\n19\r\nBuzz\r\nFizz\r\n22\r\n23\r\nFizz\r\nBuzz\r\n26\r\nFizz\r\n28\r\n29\r\nFizzBuzz\r\n31\r\n32\r\nFizz\r\n34\r\nBuzz\r\nFizz\r\n37\r\n38\r\nFizz\r\nBuzz\r\n41\r\nFizz\r\n43\r\n44\r\nFizzBuzz\r\n46\r\n47\r\nFizz\r\n49\r\nBuzz\r\nFizz\r\n52\r\n53\r\nFizz\r\nBuzz\r\n56\r\nFizz\r\n58\r\n59\r\nFizzBuzz\r\n61\r\n62\r\nFizz\r\n64\r\nBuzz\r\nFizz\r\n67\r\n68\r\nFizz\r\nBuzz\r\n71\r\nFizz\r\n73\r\n74\r\nFizzBuzz\r\n76\r\n77\r\nFizz\r\n79\r\nBuzz\r\nFizz\r\n82\r\n83\r\nFizz\r\nBuzz\r\n86\r\nFizz\r\n88\r\n89\r\nFizzBuzz\r\n91\r\n92\r\nFizz\r\n94\r\nBuzz\r\nFizz\r\n97\r\n98\r\nFizz\r\n", consoleOutput.GetOuput());
            }

            Assert.AreEqual(currentConsoleOut, Console.Out);
            
        }
        [TestMethod]
        public void WriteFizzBuzzOtherTest()
        {
            var currentConsoleOut = Console.Out;
            using (var consoleOutput = new ConsoleOutput())
            {
                fizzBuzzService.WriteFizzBuzz(1,10);
                Assert.AreEqual("1\r\n2\r\nFizz\r\n4\r\nBuzz\r\nFizz\r\n7\r\n8\r\nFizz\r\n", consoleOutput.GetOuput());
            }

            Assert.AreEqual(currentConsoleOut, Console.Out);

        }
    }
}
