using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Empowered.Enumerable.Tests
{
    [TestClass]
    public class Fork_Should
    {
        [TestMethod]
        public void CorrectlySeparateEvenAndOddNumbers()
        {
            var source = new[] {1, 1, 2, 8, 3, 5, 200, 101};

            var (even, odd) = source.Fork(n => n % 2 == 0);
            
            Assert.IsTrue(even.SequenceEqual(new []{ 2, 8, 200}));
            Assert.IsTrue(odd.SequenceEqual(new []{ 1, 1, 3, 5, 101}));
        }
    }
}