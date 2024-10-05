using kanz_waqasahmed.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace kanz_waqasahmed.Test
{
    public class ScreeningServiceTests
    {
        [Fact]
        public void Test_NumberDivisibleBy3_ReturnsKanz()
        {
            var service = new ScreeningService();
            var result = service.GetScreeningResult(9);
            Assert.Contains("Kanz", result);
        }

        [Fact]
        public void Test_NumberDivisibleBy5_ReturnsWay()
        {
            var service = new ScreeningService();
            var result = service.GetScreeningResult(10);
            Assert.Contains("Way", result);
        }

        [Fact]
        public void Test_NumberDivisibleByBoth_ReturnsKanzWay()
        {
            var service = new ScreeningService();
            var result = service.GetScreeningResult(15);
            Assert.Contains("KanzWay", result);
        }

        [Fact]
        public void Test_NumberNotDivisibleBy3Or5_ReturnsNumber()
        {
            var service = new ScreeningService();
            var result = service.GetScreeningResult(7);
            Assert.Contains("7", result);
        }
    }
}
