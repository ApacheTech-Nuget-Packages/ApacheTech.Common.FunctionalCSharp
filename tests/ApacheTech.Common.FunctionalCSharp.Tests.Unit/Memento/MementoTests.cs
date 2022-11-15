using ApacheTech.Common.FunctionalCSharp.Memento;

// ReSharper disable ConvertToLocalFunction

namespace ApacheTech.Common.FunctionalCSharp.Tests.Unit.Memento
{
    [TestFixture]
    public class MementoTests
    {
        [Test]
        public void ToMemento_ShouldReturnMementoisedType_WhenInvoked()
        {
            Func<int, string> function = i => i.ToString();
            var expected = typeof(Memento<int, string>);

            var sut = function.ToMemento();

            sut.Should().BeOfType(expected);
        }

        [Test]
        public void CachedValues_ShouldBeEmpty_WhenClassIsInstantiated()
        {
            Func<int, string> function = i => i.ToString();

            var sut = function.ToMemento();

            sut.CachedValues.Should().BeEmpty();
        }

        [Test]
        public void Invoke_ShouldReturnExpectedOutput_WhenPassedDeterministicInput()
        {
            Func<int, string> function = i => i.ToString();
            var expected = function(69);

            var sut = function.ToMemento();
            var actual = sut.Invoke(69);
            
            actual.Should().Be(expected);
        }

        [Test]
        public void Memento_ShouldBeCastFromEquivalentFunc_WhenPassedImplicitly()
        {
            static string ImplicitInvoke(Memento<int, string> memento, int input)
                => memento.Invoke(input);

            Func<int, string> function = i => i.ToString();
            var expected = function(69);

            var actual = ImplicitInvoke(function, 69);
            
            actual.Should().Be(expected);
        }

        [Test]
        public void Memento_ShouldBeCastToEquivalentFunc_WhenPassedImplicitly()
        {
            static string ImplicitInvoke(Func<int, string> memento, int input) 
                => memento.Invoke(input);

            Func<int, string> function = i => i.ToString();
            var expected = function(69);

            var sut = function.ToMemento();
            var actual = ImplicitInvoke(sut, 69);

            actual.Should().Be(expected);
        }

        [Test]
        public void Invoke_ShouldReturnCachedOutput_WhenPassedDeterministicInputTwice()
        {
            Func<int, string> function = i => i.ToString();
            var expected = function(69);

            var sut = function.ToMemento();
            var actual = sut.Invoke(69);

            // First Call.
            sut.CachedValues.Should().Contain(69, expected);
            actual.Should().Be(expected);

            // Change cached value for testing.
            const string cachedValue = "CachedValue";
            sut.CachedValues[69] = cachedValue;

            // Second Call.
            var subsequent = sut.Invoke(69);
            subsequent.Should().Be(cachedValue);
        }

        [Test]
        public void Invoke_ShouldCacheOutput_WhenPassedValidInput()
        {
            Func<int, string> function = i => i.ToString();
            var expected = function(69);

            var sut = function.ToMemento();
            var actual = sut.Invoke(69);
            
            sut.CachedValues.Should().Contain(69, expected);
            actual.Should().Be(expected);
        }

        [Test]
        public void Invoke_ShouldThrowException_WhenInvocationFails()
        {
            Func<int, string> function = _ => throw new TestSuiteException("Bad Path");

            var sut = function.ToMemento();
            
            sut.Invoking(x => x.Invoke(69))
                .Should()
                .Throw<TestSuiteException>()
                .WithMessage("Bad Path");
        }

        [Test]
        public void Invoke_ShouldThrowArgumentException_WhenInternalAttemptFails()
        {
            Func<int, string> function = _ => throw new TestSuiteException("Bad Path");

            var sut = function.ToMemento();

            sut.Invoking(x => x.Invoke(69))
                .Should()
                .Throw<TestSuiteException>()
                .WithMessage("Bad Path");
        }
    }
}
