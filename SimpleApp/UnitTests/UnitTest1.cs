using SimpleApp;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var res = Calculator.Sum(1, 2);

            Assert.Equal(3, res);
        }
    }
}
