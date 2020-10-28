using TDDDojo.Domain;
using FluentAssertions;
using Xunit;

namespace tests
{
    public class SolutionStructureSpec
    {
        [Fact]
        public void Ensure_test_can_references_domain()
        {
            new Class1().Should().NotBeNull();
        }
    }
}
