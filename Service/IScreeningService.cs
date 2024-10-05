using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kanz_waqasahmed.Service
{
    public interface IScreeningService
    {
        List<string> GetScreeningResult(int number);
    }
}
