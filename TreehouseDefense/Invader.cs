namespace TreehouseDefense
{
    class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;

        public MapLocation Location
        {
            get
            {
                return _path.GetLocationAt(_pathStep);
            }
        }

        private int _health = 2;
        
        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }

        public bool HasScored { get { return _pathStep >= _path.Length; } }

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
