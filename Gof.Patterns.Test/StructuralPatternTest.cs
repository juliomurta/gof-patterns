using Gof.Patterns.Structural.Adapter;
using Gof.Patterns.Structural.Bridge;
using Gof.Patterns.Structural.Composite;
using Gof.Patterns.Structural.Decorator;
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

        [TestMethod]
        public void Bridge_Pattern_Test()
        {
            var abstraction = new Abstraction(new ImplementationA());
            Assert.AreEqual("Abstract: A", abstraction.Operation());

            abstraction = new ExtendedAbstraction(new ImplementationB());
            Assert.AreEqual("Extended Abstract: B", abstraction.Operation());
        }

        [TestMethod]
        public void Composite_Pattern_Test()
        {
            var box1 = new Box();
            box1.Add(new Product());
            box1.Add(new Product());

            var box2 = new Box();
            box2.Add(new Product());
            box2.Add(box1);

            var box3 = new Box();
            box3.Add(new Product());
            box3.Add(new Product());
            box3.Add(new Product());
            box3.Add(box2);

            var box4 = new Box();
            box4.Add(box3);

            Assert.AreEqual(60, box4.Sum());
        }

        [TestMethod]
        public void Decorator_Pattern_Test()
        {
            var coffee = new Coffee();
            var coffeeWithMilk = new CoffeeWithMilk(coffee);
            var cappuccino = new Cappuccino(coffee);

            Assert.AreEqual("Coffee", coffee.Description());
            Assert.AreEqual("I'm Coffee with milk", coffeeWithMilk.Description());
            Assert.AreEqual("I'm Coffee Cappuccino", cappuccino.Description());
        }
    }
}
