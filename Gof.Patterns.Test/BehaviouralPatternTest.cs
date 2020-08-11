using Gof.Patterns.Behavioural.ChainOfResponsibility;
using Gof.Patterns.Behavioural.Memento;
using Gof.Patterns.Behavioural.Observer;
using Gof.Patterns.Behavioural.State;
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

        [TestMethod]
        public void Memento_Pattern_Test()
        {
            var originator = new Originator("super-super-super-super");
            var caretaker = new Caretaker(originator);

            var obj1 = caretaker.Backup();
            Assert.AreEqual("super-super-super-super", obj1.GetState());

            originator.DoSomething();
            var obj2 = caretaker.Backup();
            Assert.AreNotEqual("super-super-super-super", obj2.GetState());

            var obj3 = caretaker.Undo();
            Assert.AreEqual("super-super-super-super", obj3.GetState());
        }

        [TestMethod]
        public void Observer_Pattern_Test()
        {
            var subject = new Subject();
            var observer = new ConcreteObserver();

            subject.Attach(observer);

            Assert.IsTrue(observer.IsActive);

            subject.ChangeStates();

            Assert.IsFalse(observer.IsActive);

        }

        [TestMethod]
        public void State_Pattern_Test()
        {
            var lamp = new MyLamp(new LampOn());
            Assert.AreEqual(typeof(LampOn), lamp.State.GetType());

            lamp.ChangeState();
            Assert.AreEqual(typeof(LampOff), lamp.State.GetType());            

            lamp.ChangeState();
            Assert.AreEqual(typeof(LampOn), lamp.State.GetType());
        }
    }
}
