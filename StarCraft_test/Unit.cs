using System;

namespace StarCraft_test
{
    abstract class Unit
    {
        protected int _x;
        protected int _y;

        public virtual void Move(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public  void SayHello()
        {
            string name = GetName();
            Console.WriteLine($"Unit Name is {name}. ");
        }

        public abstract string GetName();
        
    }
}