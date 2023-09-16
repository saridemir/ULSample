using System.Numerics;
using UL.Common.Services.Interfaces;
using UL.Core.ULMath;

namespace UL.Common.Services.Implementations
{
    public class FactorialService : IFactorialService
    {
        //private readonly ILogger<FactorialService> _logger;

        //public FactorialService(ILogger<FactorialService> logger)
        //{
        //    _logger = logger;
        //}
        public bool FindFactorial(string? input)
        {
            BigInteger n;
            if (BigInteger.TryParse(input, out n))
            {
                try
                {
                    Console.WriteLine($"Factorial of this number is : {n.Fak()}");
                    return true;
                }
                catch (Exception _e)
                {
                    //_logger.LogError(_e);
                    Console.WriteLine(_e.Message);
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Invalid input , Enter only number");
                return false;
            }
        }
    }
}