using System;
namespace inheritance
{
    public class Shop : AbstractBusiness
    {
        private long sharesOwned;
        private decimal currentPrice;

        //  Override like a virtual method
        public override decimal NetValue => currentPrice * sharesOwned;

        public Shop(long sharesOwned, decimal currentPrice)
        {
            this.sharesOwned = sharesOwned;
            this.currentPrice = currentPrice;
        }

        //  Override like a virtual method
        public override decimal GetNetValue()
        {
            return currentPrice * sharesOwned;
        }
    }
}
