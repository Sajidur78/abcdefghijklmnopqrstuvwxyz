using NUnit.Framework;
using Abcdefghijklmnopqrstuvwxyz;

namespace Abcdefghijklmnopqrstuvwxyz.Tests
{
    public class AlphabetTests
    {
        [Test]
        public void AlphabetTest()
        {
            if (AlphabetProvider.GetAlphabet() == "abcdefghijklmnopqrstuvwxyz")
                Assert.Pass();
            else
                Assert.Fail();
        }
    }
}