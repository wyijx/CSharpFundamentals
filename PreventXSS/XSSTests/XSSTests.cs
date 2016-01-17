using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PreventXSS;

namespace XSSTests {
    [TestClass]
    public class XSSTests {
        [TestMethod]
        public void TestSanitizeHTML() {

            var janitor = new XSSDefender();
            var badScript = "<script>evil</script>";
            string[] whiteList = { "b", "strong", "i", 
            };

            badScript = janitor.SanitizeHTML(badScript, whiteList);

            Assert.AreEqual(@"&lt;script&gt;evil&lt;script&gt;", badScript);
        }
        [TestMethod]
        public void TestSanitizeWithBoldHTML() {

            var janitor = new XSSDefender();
            var badScript = "<b><script>evil</script></b>";
            string[] whiteList = { "b", "strong", "i",
            };

            badScript = janitor.SanitizeHTML(badScript, whiteList);

            Assert.AreEqual(@"<b>&lt;script&gt;evil&lt;script&gt;</b>", badScript);
        }
        [TestMethod]
        public void TestSanitizeWithBoldandItalicsHTML() {

            var janitor = new XSSDefender();
            var badScript = "<i><b><script>evil</script></b></i>";
            string[] whiteList = { "b", "strong", "i",
            };

            badScript = janitor.SanitizeHTML(badScript, whiteList);

            Assert.AreEqual(@"<i><b>&lt;script&gt;evil&lt;script&gt;</b></i>", badScript);
        }
    }
}
