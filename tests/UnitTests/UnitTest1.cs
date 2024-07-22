namespace UnitTests;

using Xtuker.TestNugetCI;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("Hello world!", new Hello().Say());
    }
}