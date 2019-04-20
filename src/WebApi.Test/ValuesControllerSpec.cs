using FluentAssertions;
using WebApi.Controllers;
using Xunit;

namespace WebApi
{
    public sealed class ValuesControllerSpec
    {
        [Fact]
        public void ShouldGet()
        {
            var sut = new ValuesController();
            sut.Get().Value.Should().NotBeNull();
        }
    }
}
