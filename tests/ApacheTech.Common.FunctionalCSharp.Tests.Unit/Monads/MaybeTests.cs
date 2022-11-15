using System.Numerics;
using ApacheTech.Common.FunctionalCSharp.Monads;
using ApacheTech.Common.FunctionalCSharp.Monads.Extensions;

namespace ApacheTech.Common.FunctionalCSharp.Tests.Unit.Monads
{
    [TestFixture]
    public class MaybeTests
    {
        [Test]
        public void ToMaybe_ShouldReturnActualOfT_WhenInvokedOnT()
        {
            const int rawValue = 69;

            var actual = rawValue.ToMaybe();

            actual.Should().BeOfType<Actual<int>>();
        }

        [Test]
        public void Value_ShouldReturnX_WhenInvokedOnX()
        {
            const int x = 69;

            var actual = x.ToMaybe();
            
            actual.Value.Should().Be(x);
        }

        [Test]
        public void Value_ShouldBeCastToT_WhenPassedImplicitlyToT()
        {
            const int x = 69;

            static int ImplicitInvoke(int value) => value;
            var sut = x.ToMaybe();

            var actual = ImplicitInvoke(sut);

            actual.Should().Be(x);
        }

        [Test]
        public void Value_ShouldBeCastFromT_WhenPassedImplicitlyFromT()
        {
            const int x = 69;

            static int ImplicitInvoke(Maybe<int> value) => value;
            var sut = x.ToMaybe();

            var actual = ImplicitInvoke(sut);

            actual.Should().Be(x);
        }

        [Test]
        public void Bind_ShouldMapToOutputType_WhenInvoked()
        {
            const int x = 69;
            
            var sut = x.ToMaybe();
            var actual = sut.Bind(xx => xx.ToString());

            actual.Value.Should().BeOfType<string>();
        }

        [Test]
        public void Bind_ShouldInvokeMappingFunction_WhenInvoked()
        {
            const int x = 69;
            var expected = x.ToString();

            var sut = x.ToMaybe();
            var actual = sut.Bind(xx => xx.ToString());

            actual.Value.Should().Be(expected);
        }

        [Test]
        public void Bind_ShouldChainInvokeMappingFunctions_WhenInvokedMoreThanOnce()
        {
            const int x = 69;
            var expected = x.ToString().ToUpperInvariant();

            var sut = x.ToMaybe();
            var actual = sut
                .Bind(i => i.ToString())
                .Bind(s => s.ToUpperInvariant());

            actual.Value.Should().Be(expected);
        }

        [Test]
        public void Bind_ShouldShouldReturnTypeNothingOfT_WhenInvocationFails()
        {
            const int x = 69;
            var sut = x.ToMaybe();
 
            var actual = sut
                .Bind<int, float>(_ => throw new NotFiniteNumberException());

            actual.Should().BeOfType<Nothing<float>>();
        }

        [Test]
        public void Bind_ShouldShouldReturnValueDefaultOfT_WhenInvocationFails()
        {
            const int x = 69;
            const int expected = default;
            var sut = x.ToMaybe();
            
            var actual = sut
                .Bind<int, float>(_ => throw new NotFiniteNumberException());

            actual.Should().BeOfType<Nothing<float>>()
                .Which.Value.Should().Be(expected);
        }

        [Test]
        public void Bind_ShouldShouldPropagateNothingOfT_WhenInvocationFailsMidChain()
        {
            const int x = 69;
            var sut = x.ToMaybe();
            
            var actual = sut
                .Bind<int, float>(_ => throw new NotFiniteNumberException())
                .Bind(f => f + 69f);

            actual.Should().BeOfType<Nothing<float>>();
        }

        [Test]
        public void Bind_ShouldShouldPropagateValueDefaultOfT_WhenInvocationFailsMidChain()
        {
            const int x = 69;
            const double expected = default;
            var sut = x.ToMaybe();
            
            var actual = sut
                .Bind<int, float>(_ => throw new NotFiniteNumberException())
                .Bind(f => f + 6.9);

            actual.Value.Should().Be(expected);
        }

        [Test]
        [TestCase(100)]
        [TestCase(100L)]
        [TestCase(100f)]
        [TestCase(100.0)]
        public void Bind_ShouldNotFallOver_WhenInvokingWithZeroNumbers<T>(T x) where T : INumber<T>
        {
            var sut = x.ToMaybe();
            var actual = sut
                .Bind(i => i - x)  // 100 - 100 = 0
                .Bind(i => i + x); // 0 + 100 = 100

            actual.Should().BeOfType<Actual<T>>();
            actual.Value.Should().Be(x);
        }
    }
}
