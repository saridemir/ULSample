using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using UL.Common.Services.Implementations;
using UL.Common.Services.Interfaces;

namespace UL.UnitTests.UnitTest
{
    [TestClass]
    public class FactorialServiceUnitTest
    {
        private readonly IFactorialService factorialService;
        public FactorialServiceUnitTest()
        {

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices(services => { services.AddTransient<IFactorialService, FactorialService>(); })
                .Build();

            factorialService = host.Services.GetRequiredService<IFactorialService>();

        }
        [TestMethod]
        public void RandomNumberTest()
        {
            Random random = new Random();
            const string chars = "0123456789";
            var randomNumber = new string(Enumerable.Repeat(chars, 5)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            Assert.IsTrue(factorialService.FindFactorial(randomNumber));
        }
        [TestMethod]
        public void NegativeNumberTest()
        {
            Random random = new Random();
            const string chars = "0123456789";
            var randomNumber = new string(Enumerable.Repeat(chars, 5)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            Assert.IsFalse(factorialService.FindFactorial("-" + randomNumber));
        }
        [TestMethod]
        public void VeryBigNumberTest()
        {
            Random random = new Random();
            const string chars = "0123456789";
            var randomNumber = new string(Enumerable.Repeat(chars, 10000)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            Assert.IsFalse(factorialService.FindFactorial("-" + randomNumber));
        }

    }
}