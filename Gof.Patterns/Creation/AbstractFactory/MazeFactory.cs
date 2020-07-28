using Gof.Patterns.Creation.AbstractFactory.Abstract;
using Gof.Patterns.Creation.AbstractFactory.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Creation.AbstractFactory
{
    public static class MazeFactory
    {
        public static Maze CreateMaze()
        {
            return new ConcreteMaze();
        }

        public static Room CreateRoom()
        {
            return new ConcreteRoom();
        }

        public static Wall CreateWall()
        {
            return new ConcreteWall();
        }

        public static Door CreateDoor()
        {
            return new ConcreteDoor();
        }
    }
}
