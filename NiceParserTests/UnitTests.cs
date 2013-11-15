using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NiceParser;

namespace NiceParserTests
{
    [TestClass]
    public class NiceParserTests
    {
        [TestMethod]
        public void Evaluate2plus2()
        {
            var expression = "2a2";
            var result = NiceCalculator.Evaluate(expression);
            Assert.AreEqual<int>(4, result);
        }
        [TestMethod]        
        public void Evaluate2plus10()
        {
            var expression = "2a10";
            var result = NiceCalculator.Evaluate(expression);
            Assert.AreEqual<int>(12, result);
        }
        [TestMethod]
        public void Evaluate2minus10()
        {
            var expression = "2b10";
            var result = NiceCalculator.Evaluate(expression);
            Assert.AreEqual<int>(-8, result);
        }
        [TestMethod]
        public void Evaluate2minus10plus15()
        {
            var expression = "2b10a15";
            var result = NiceCalculator.Evaluate(expression);
            Assert.AreEqual<int>(7, result);
        }
        [TestMethod]
        public void Evaluate2times3()
        {
            var expression = "2c3";
            var result = NiceCalculator.Evaluate(expression);
            Assert.AreEqual<int>(6, result);
        }
        [TestMethod]
        public void Evaluate3a2c4()
        {
            var expression = "3a2c4";
            var result = NiceCalculator.Evaluate(expression);
            Assert.AreEqual<int>(20, result);
        }
        [TestMethod]
        public void Evaluate9dividedBy3()
        {
            var expression = "9d3";
            var result = NiceCalculator.Evaluate(expression);
            Assert.AreEqual<int>(3, result);
        }
        [TestMethod]
        public void Evaluate32a2d2()
        {
            var expression = "32a2d2";
            var result = NiceCalculator.Evaluate(expression);
            Assert.AreEqual<int>(17, result);
        }
        [TestMethod]
        public void Evaluate500a10b66c32()
        {
            var expression = "500a10b66c32";
            var result = NiceCalculator.Evaluate(expression);
            Assert.AreEqual<int>(14208, result);
        }
        [TestMethod]
        public void Evaluate3timesBracketed2plus3()
        {
            var expression = "3ce2a3f";
            var result = NiceCalculator.Evaluate(expression);
            Assert.AreEqual<int>(15, result);
        }
        [TestMethod]
        public void Evaluate3ae4c66fb32()
        {
            var expression = "3ae4c66fb32";
            var result = NiceCalculator.Evaluate(expression);
            Assert.AreEqual<int>(235, result);
        }
        [TestMethod]
        public void Evaluate3c4d2aee2a4c41fc4f()
        {
            var expression = "3c4d2aee2a4c41fc4f";
            var result = NiceCalculator.Evaluate(expression);
            Assert.AreEqual<int>(990, result);
        }


    }
}
