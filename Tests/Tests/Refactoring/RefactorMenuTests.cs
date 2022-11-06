using Moq;

namespace Tests.Refactoring;

public sealed class RefactorMenuTests
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

    public RefactorMenuTests()
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