namespace ApacheTech.Common.FunctionalCSharp.Tests.Unit
{
    /// <summary>
    ///     Represents an expected error, passed from, and thrown by the test-suite, in order to test "Bad Path" results within monadic functions.
    /// </summary>
    /// <seealso cref="Exception" />
    [Serializable]
    public class TestSuiteException : Exception
    {
        /// <summary>
        ///     Initialises a new instance of the <see cref="TestSuiteException"/> class.
        /// </summary>
        public TestSuiteException() { }

        /// <summary>
        ///     Initialises a new instance of the <see cref="TestSuiteException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public TestSuiteException(string message) : base(message) { }
    }
}