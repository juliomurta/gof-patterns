using Gof.Patterns.Behavioural.ChainOfResponsibility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Gof.Patterns.Test
{
    [TestClass]
    public class BehaviouralPatternTest
    {
        [TestMethod]
        public void Chain_of_Responsibility_Pattern_Test()
        {
            var first = new FirstStep();
            var second = new SecondStep();
            var third = new ThirdStep();

            first.Next(second).Next(third);

            Assert.IsTrue((bool)first.Handler(NumberEnum.One));
            Assert.IsTrue((bool)first.Handler(NumberEnum.Two));
            Assert.IsTrue((bool)first.Handler(NumberEnum.Three));
            Assert.IsNull(first.Handler(NumberEnum.Four));
        }
    }
}
