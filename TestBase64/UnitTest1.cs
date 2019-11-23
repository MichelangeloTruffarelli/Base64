using System;
using LibraryBase64;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestBase64
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UnitTest()
        {
            string risposta = LibraryBase64.Base64();
            Assert.AreEqual("Tmljb2xh", risposta);
        }
    }
}
