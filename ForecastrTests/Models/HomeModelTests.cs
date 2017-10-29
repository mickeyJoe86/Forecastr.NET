using Xunit;
using Forecastr.Models;

namespace Forecastr.Tests
{
    public class HomeModelTests
    {
        [Fact()]
        public void HomeModelTest()
        {
            string name = "Test Name";
            var target = new HomeModel(name);
            Assert.Equal(target.Name, name);
        }
    }
}