using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

namespace FactorialKata.Test
{
    public class FactorialShould
    {
    
        [Test]
        [TestCase(1,0)]
        [TestCase(1,1)]
        [TestCase(2,2)]
        [TestCase(6,3)]
        [TestCase(24,4)]
        [TestCase(120,5)]
        public void return_expected_when_input_is_one(int expected, int input)
        {
            Assert.AreEqual(expected, Factorial.Calculate(input));
        }
    }
}