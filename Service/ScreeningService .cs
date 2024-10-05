using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kanz_waqasahmed.Service
{
    public class ScreeningService : IScreeningService
    {
        public List<string> GetScreeningResult(int number)
        {
            var result = new List<string>();

            result.Add((number % 3 == 0 && number % 5 == 0) ? "KanzWay" :
                       (number % 3 == 0) ? "Kanz" :
                       (number % 5 == 0) ? "Way" :
                       number.ToString());

            return result;
        }
    }
}
