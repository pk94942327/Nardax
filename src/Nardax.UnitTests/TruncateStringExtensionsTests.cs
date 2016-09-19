using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nardax.Tests
{
    [TestClass]
    public class TruncateStringExtensionsTests
    {
        private string _value;

        [TestInitialize]
        public void TestInitialize()
        {
            _value = "123456789";
        }

        [TestMethod]
        public void TruncateLeft_ValueIsLarger_TruncateRemovesLeftSide()
        {
            var expected = "9";

            var result = _value.TruncateLeft(1);
            
            Assert.AreEqual(expected, result);
        }

        //Här är någonting med Go banana