using System;
namespace inheritance
{
    public class House : Asset
    {
        private decimal mortgage;
        public decimal Mortgage => mortgage;
        public override decimal Liability => mortgage;

        public House() : base()
        {
            mortgage = 0;
        }

        public House(string name, decimal mortgage) : base(name)
        {
            this.mortgage = mortgage;
        }
    }
}
