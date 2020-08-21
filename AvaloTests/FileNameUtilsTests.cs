using Microsoft.VisualStudio.TestTools.UnitTesting;
using Avalo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalo.Tests {
    [TestClass()]
    public class FileNameUtilsTests {
        [TestMethod()]
        public void exchangeFolderNameTest() {
            var folder = FileNameUtils.exchangeFolderName("test-<yyyyMMdd>");
            var now = DateTime.Now.ToString("yyyyMMdd");
            Assert.AreEqual("test-" + now, folder);
        }
    }
}