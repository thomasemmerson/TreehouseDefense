namespace TreehouseDefense
{
    class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;
        private int _health;

        public MapLocation Location
        {
            get
            {
                return _path.GetLocationAt(_pathStep);
            }
        }
        
        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }

        public bool HasScored
        {
            get
            {
                if (_pathStep >= _path.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool IsNeutralised
        {
            get { return Health <= 0; }
        }

        public bool IsActive
        {
            get { return (!IsNeutralised || HasScored); }
        }

        public Invader(Path path)
        {
            _path = path;
            _health = 2;
        }

        public void Move()
        {
            _pathStep += 1;
        }

        public void DecreaseHealth(int factor)
        {
            Health -= factor;
        }

    }
}
