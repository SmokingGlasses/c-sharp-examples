using System;

namespace interfaces
{
    public class Countdown : IEnumerator
    {
        private int count = 10;
        public object Current => count;

        public Countdown()
        {
            //
        }

        public bool MoveNext() => count-- > 0;

        public void Reset()
        {
            throw new NotSupportedException();
        }
    }
}