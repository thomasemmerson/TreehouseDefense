namespace TreehouseDefense
{
    class Tower
    {
        private readonly MapLocation _location;

        private const int _range = 1;
        private const int _power = 1;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            int index = 0;

            while (index < invaders.Length)
            {
                Invader invader = invaders[index];

                if(invader.IsActive && _location.InRangeOf(invader.Location, 1))
                {
                    invader.DecreaseHealth(_power);
                    break;
                }
                index++;
            }
        }

    }
}
