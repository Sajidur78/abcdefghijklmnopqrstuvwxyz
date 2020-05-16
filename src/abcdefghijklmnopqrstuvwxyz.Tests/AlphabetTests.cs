using NUnit.Framework;
using abcdefghijklmnopqrstuvwxyz;

namespace abcdefghijklmnopqrstuvwxyz.Tests
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