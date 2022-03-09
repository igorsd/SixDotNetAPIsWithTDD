using Xunit;

namespace CloudCustomers.UnitTests.Systems.Controllers;

public class TestUsersController
{
    [Fact]
    public void Test1()
    {

    }
    [Theory]
    [InlineData("foo", 1)]
    [InlineData("bar", 2)]
    public void Test2(string input, int bar)
    {

    }
}