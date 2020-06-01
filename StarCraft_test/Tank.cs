namespace StarCraft_test
{
    class Tank : Unit
    {
        private bool _seiged;

        public void ToSeigeMode()
        {
            _seiged = true;
        }

        public override string GetName()
        {
            return "Tank";
        }
        public virtual void Move(int x, int y)
        {
            if (_seiged = true)
                return;
            
            base.Move(x,y);
        }
        
    }
}