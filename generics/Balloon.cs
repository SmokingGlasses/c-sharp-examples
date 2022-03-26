using System;
namespace generics
{
    public class Balloon : IEquatable<Balloon>
    {
        public string Color { get; set; }
        public int CC { get; set; }

        public Balloon()
        {
            //
        }

        public bool Equals(Balloon balloon)
        {
            if (balloon == null)
            {
                return false;
            }

            return balloon.Color == Color && balloon.CC == CC;
        }
    }
}
