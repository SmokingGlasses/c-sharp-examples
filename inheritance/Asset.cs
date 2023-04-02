using System;

namespace inheritance
{
    public class Asset
    {
        private string name;
        public string Name => name;
        public virtual decimal Liability => 0;

        public Asset()
        {
            name = "Unknown";
        }

        public Asset(string name)
        {
            this.name = name;
        }
    }
}