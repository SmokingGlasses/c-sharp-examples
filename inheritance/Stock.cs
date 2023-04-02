using System;

namespace inheritance
{
    public class Stock : Asset
    {
        private long sharesOwned;
        public long SharesOwned => sharesOwned;

        public Stock() : base()
        {
            sharesOwned = 0;
        }

        public Stock(string name, long sharesOwned) : base(name)
        {
            this.sharesOwned = sharesOwned;
        }
    }
}