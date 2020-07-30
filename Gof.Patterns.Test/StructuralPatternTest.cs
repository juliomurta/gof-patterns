using Gof.Patterns.Structural.Adapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gof.Patterns.Test
{
    [TestClass]
    public class StructuralPatternTest
    {

        [TestMethod]
        public void Adapter_Pattern_Test()
        {
            var adaptee = new Adaptee();
            var adapter = new Adapter(adaptee);
            var expectedValue = "This is Specific request";

            Assert.AreNotEqual(adaptee.GetSpecificRequest(), expectedValue);
            Assert.AreEqual(adapter.GetRequest(), expectedValue);
        }
    }
}
