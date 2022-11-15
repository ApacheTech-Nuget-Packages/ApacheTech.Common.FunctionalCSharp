using ApacheTech.Common.FunctionalCSharp.Monads;
using ApacheTech.Common.FunctionalCSharp.Monads.Extensions;

namespace ApacheTech.Common.FunctionalCSharp.Tests.Unit.Monads
{
    [TestFixture]
    public class IdentityTests
    {
        [Test]
        public void ToIdentity_ShouldReturnIdentityOfT_WhenInvokedOnT()
        {
            const int rawValue = 69;

            var actual = rawValue.ToIdentity();

            actual.Should().BeOfType<Identity<int>>();
        }

        [Test]
        public void Value_ShouldReturnX_WhenInvokedOnX()
        {
            const int x = 69;

            var actual = x.ToIdentity();
            
            actual.Value.Should().Be(x);
        }

        [Test]
        public void Value_ShouldBeCastToT_WhenPassedImplicitlyToT()
        {
            const int x = 69;

            static int ImplicitInvoke(int value) => value;
            var sut = x.ToIdentity();

            var actual = ImplicitInvoke(sut);

            actual.Should().Be(x);
        }

        [Test]
        public void Value_ShouldBeCastFromT_WhenPassedImplicitlyFromT()
        {
            const int x = 69;

            static int ImplicitInvoke(Identity<int> value) => value;

            var actual = ImplicitInvoke(x);

            actual.Should().Be(x);
        }

        [Test]
        public void Bind_ShouldMapToOutputType_WhenInvoked()
        {
            const int x = 69;
            
            var sut = x.ToIdentity();
            var actual = sut.Bind(xx => xx.ToString());

            actual.Value.Should().BeOfType<string>();
        }

        [Test]
        public void Bind_ShouldInvokeMappingFunction_WhenInvoked()
        {
            const int x = 69;
            var expected = x.ToString();

            var sut = x.ToIdentity();
            var actual = sut.Bind(xx => xx.ToString());

            actual.Value.Should().Be(expected);
        }

        [Test]
        public void Bind_ShouldChainInvokeMappingFunctions_WhenInvokedMoreThanOnce()
        {
            const int x = 69;
            var expected = x.ToString().ToUpperInvariant();

            var sut = x.ToIdentity();
            var actual = sut
                .Bind(i => i.ToString())
                .Bind(s => s.ToUpperInvariant());

            actual.Value.Should().Be(expected);
        }
    }
}
