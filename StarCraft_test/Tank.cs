namespace StarCraft_test
{
    class Tank : Unit
    {
        private bool _seiged;

        public void ToSeigeMode()
        {
            _seiged = true;
        }

        public override void Move(int x, int y)
        {
            if (_seiged)
                return;
            base.Move(x,y);
        }
    }
}