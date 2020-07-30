using System;
using Gof.Patterns.Creation.AbstractFactory;
using Gof.Patterns.Creation.AbstractFactory.Concrete;
using Gof.Patterns.Creation.Builder;
using Gof.Patterns.Creation.FactoryMethod.Entities;
using Gof.Patterns.Creation.FactoryMethod.Entities.Maison;
using Gof.Patterns.Creation.FactoryMethod.Entities.Office;
using Gof.Patterns.Creation.Prototype;
using Gof.Patterns.Creation.Prototype.Entities;
using Gof.Patterns.Creation.Singleton;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gof.Patterns.Test
{
    [TestClass]
    public class CreationPatternTest
    {
        [TestMethod]
        public void Abstract_Factory_Test()
        {
            var maze = MazeFactory.CreateMaze();
            var door = MazeFactory.CreateDoor();
            var room = MazeFactory.CreateRoom();
            var wall = MazeFactory.CreateWall();

            Assert.IsInstanceOfType(maze, typeof(ConcreteMaze));
            Assert.IsInstanceOfType(door, typeof(ConcreteDoor));
            Assert.IsInstanceOfType(room, typeof(ConcreteRoom));
            Assert.IsInstanceOfType(wall, typeof(ConcreteWall));
        }

        [TestMethod]
        public void Builder_Pattern_Test()
        {
            var builder = new MealBuilder();

            var vegMeal = builder.PrepareVegMeal();
            var vegItems = vegMeal.GetItems();

            Assert.IsInstanceOfType(vegItems[0], typeof(VegBurger));
            Assert.IsInstanceOfType(vegItems[1], typeof(Coke));


            var chickenMeal = builder.PrepareNonVegMeal();
            var chickenItems = chickenMeal.GetItems();

            Assert.IsInstanceOfType(chickenItems[0], typeof(ChickenBurger));
            Assert.IsInstanceOfType(chickenItems[1], typeof(Pepsi));
        }

        [TestMethod]
        public void Factory_Method_Test()
        {
            var factory = new Factory();
            var maisonFactory = new MaisonFactory();
            var officeFactory = new OfficeFactory();

            var door = factory.MakeDoor();
            var wall = factory.MakeWall();

            var maisonDoor = maisonFactory.MakeDoor();
            var maisonWall = maisonFactory.MakeWall();

            var officeDoor = officeFactory.MakeDoor();
            var officeWall = officeFactory.MakeWall();

            Assert.IsInstanceOfType(door, typeof(Door));
            Assert.IsInstanceOfType(wall, typeof(Wall));

            Assert.IsInstanceOfType(maisonDoor, typeof(MaisonDoor));
            Assert.IsTrue(maisonDoor.GetType().BaseType == typeof(Door));

            Assert.IsInstanceOfType(maisonWall, typeof(MaisonWall));
            Assert.IsTrue(maisonWall.GetType().BaseType == typeof(Wall));

            Assert.IsInstanceOfType(officeDoor, typeof(OfficeDoor));
            Assert.IsTrue(officeDoor.GetType().BaseType == typeof(Door));

            Assert.IsInstanceOfType(officeWall, typeof(OfficeWall));
            Assert.IsTrue(officeWall.GetType().BaseType == typeof(Wall));
        }

        [TestMethod]
        public void Prototype_Pattern_Test()
        {
            var factoryOne = new PrototypeFactory(new Ype(), new Rose(), new Apple());
            var factoryTwo = new PrototypeFactory(new Pine(), new Lothus(), new Papaya());

            var ype = factoryOne.MakeTree();
            var rose = factoryOne.MakeFlower();
            var apple = factoryOne.MakeFruit();

            var pine = factoryTwo.MakeTree();
            var lothus = factoryTwo.MakeFlower();
            var papaya = factoryTwo.MakeFruit();

            Assert.AreEqual(ype.Warning, "Eu sou um ypê-roxo!");
            Assert.IsInstanceOfType(ype, typeof(Ype));

            Assert.AreEqual(rose.Warning, "Eu sou uma Rosa");
            Assert.IsInstanceOfType(rose, typeof(Rose));

            Assert.AreEqual(apple.Warning, "Eu sou uma Maçã!");
            Assert.IsInstanceOfType(apple, typeof(Apple));

            Assert.AreEqual(pine.Warning, "Eu sou um pinheiro!");
            Assert.IsInstanceOfType(pine, typeof(Pine));

            Assert.AreEqual(lothus.Warning, "Eu sou uma flor de lótus!");
            Assert.IsInstanceOfType(lothus, typeof(Lothus));

            Assert.AreEqual(papaya.Warning, "Eu sou um mamão!");
            Assert.IsInstanceOfType(papaya, typeof(Papaya));
        }

        [TestMethod]
        public void Singleton_Pattern_Test()
        {
            Assert.IsNotNull(MyInstance.Instance());
        }
    }
}
