using System;
using CatCounter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatCounterTests {
    [TestClass]
    public class CatCounterTest {
        [TestMethod]
        public void TestCountCats() {

            var testString = "Cats Cats Cats, Cats, cats, cat, CatsCatcat";

            var result = Counter.CountCats(testString);

            Assert.AreEqual(9, result);
        }
    }
}
