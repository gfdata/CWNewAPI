using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CWApi.Tests
{
    [TestClass]
    public class LoggerTests
    {
        [TestMethod]
        public void CtorTest1()
        {
            var log = new SD.ConnectwiseApi.Util.Logger();
            Assert.AreEqual(true, log.IsEnabled);
            log.Write("Test 1 2 3");
            log.Flush();
            log = null;
        }
    }
}
