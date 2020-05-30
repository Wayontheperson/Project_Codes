namespace StarCraft_test
{
    public class Unit
    {
        protected int _x;
        protected int _y;

        public virtual void Move(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
}