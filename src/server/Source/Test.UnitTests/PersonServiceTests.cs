using System;
using Test.Services;
using Xunit;

namespace Test.UnitTests
{
    public class PersonServiceTests
    {
        [Fact]
        public void WhenGetDataIsCalledThenItShouldReturnData()
        {
            var service = new PersonDataStore();

            Assert.NotNull(service.GetData());
        }
    }
}
