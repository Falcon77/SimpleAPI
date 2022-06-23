using System;
using Xunit;
using SimpleAPI.Controllers;
using Microsoft.Extensions.Logging;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
    private static readonly ILogger<WeatherForecastController> logger;
    WeatherForecastController controller = new WeatherForecastController(logger);
        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Fermin Suero Sr", returnValue.Value);
            
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
