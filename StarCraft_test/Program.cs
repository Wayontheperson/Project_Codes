using System;

namespace StarCraft_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit m1=new Marine();
            Tank t1=new Tank();
            t1.ToSeigeMode();
            
            Unit[] units= new Unit[2];
            units[0] = m1;
            units[1] = t1;
            GoToCenter(units);

        }

        static void GoToCenter(Unit[] units)
        {
            for (int i = 0; i < units.Length; i++)
            {
                units[i].Move(100,100);
            }
        }
        
    }
}