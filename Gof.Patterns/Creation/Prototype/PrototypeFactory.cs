using Gof.Patterns.Creation.Prototype.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Creation.Prototype
{
    public class PrototypeFactory
    {
        private ITree tree;
        private IFlower flower;
        private IFruit fruit;

        public PrototypeFactory(ITree tree, IFlower flower, IFruit fruit)
        {
            this.tree = tree;
            this.flower = flower;
            this.fruit = fruit;
        }

        public ITree MakeTree()
        {
            return (ITree) this.tree.Clone();
        }

        public IFlower MakeFlower()
        {
            return (IFlower)this.flower.Clone();
        }

        public IFruit MakeFruit()
        {
            return (IFruit)this.fruit.Clone();
        }
    }
}
