using Moq;

namespace Tests;

public sealed class Refactor
{
    public interface IFooService
    {
    }

    public class BarService
    {
        public BarService(IFooService fooService)
        {
        }

        public async Task MethodAsync()
        {
        }
    }

    private BarService testee;

    public Refactor()
    {
        var fooMock = new Mock<IFooService>();

        this.testee = new BarService(fooMock.Object);
    }

    [Fact]
    public void Method()
    {
        // await testee.MethodAsync();
    }
}