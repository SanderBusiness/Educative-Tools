using FluentAssertions;

namespace Test;

public class FluentAssertionsTests
{
    [Fact]
    public void True()
    {
        true.Should().BeTrue();
    }
}