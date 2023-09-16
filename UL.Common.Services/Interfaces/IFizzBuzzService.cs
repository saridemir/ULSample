using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UL.Common.Services.Interfaces
{
    public interface IFizzBuzzService
    {
        bool WriteFizzBuzz();
        bool WriteFizzBuzz(int start, int finish);
        bool WriteFizzBuzz(int start, int finish, List<(int Number, string Message)> matrix);
    }
}
