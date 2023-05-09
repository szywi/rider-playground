namespace Tests;

public sealed class Run
{
    [Fact]
    public void TestPass()
    {
        Assert.Equal("Foo", "Foo");
    }

    [Fact]
    public void TestFails()
    {
        Assert.Equal("Foo", "Bar");
    }

    [Theory]
    [InlineData("Foo", "Foo")]
    [InlineData("Bar", "Bar")]
    public void Test(string result, string expected)
    {
        Assert.Equal(result, expected);
    }

    [Fact]
    public void RunUntilFailure()
    {
    }

    // Enable external source debugging
    [Fact]
    public void DebugExternalCode()
    {
        var list = new List<int> { 1, 2, 3, };

        var result = list.Sum();

        Assert.Equal(6, result);
    }

    // [Fact]
    // public void TestDrivenDevelopment()
    // {
    //     throw new NotImplementedException();
    // }
}