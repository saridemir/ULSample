using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UL.Common.Services.Interfaces;

namespace UL.Common.Services.Implementations
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public bool WriteFizzBuzz()
        {
            return WriteFizzBuzz(1, 100);
        }
        public bool WriteFizzBuzz(int start, int finish)
        {
            return WriteFizzBuzz(start, finish, new List<(int Number, string Message)> { (3, "Fizz"), (5, "Buzz"), (15, "FizzBuzz") });
        }
        public bool WriteFizzBuzz(int start, int finish, List<(int Number, string Message)> matrix)
        {
            try
            {
                var matrixDic = matrix.OrderByDescending(f => f.Number).ToDictionary(f => f.Number, f => f.Message);

                for (int i = start; i < finish; i++)
                {
                    bool found = false;
                    foreach (var f in matrixDic.Keys)
                    {
                        if (i % f == 0)
                        {
                            Console.WriteLine(matrixDic[f]);
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            catch (Exception _e)
            {
                Console.WriteLine("Matrix has no correct format");
                return false;
            }
            return true;
        }


    }
}
