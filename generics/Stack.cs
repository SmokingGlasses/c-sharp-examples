using System;
namespace generics
{
    public class Stack<T>
    {
        private int size;
        private int position;
        private T[] data;

        public Stack(int size)
        {
            this.size = size;
            data = new T[size];
        }

        public void Push(T obj) => data[position++] = obj;
        public T this[int index] => data[index];
        public T Pop() => data[--position];

        public Stack<T> Clone()
        {
            Stack<T> clone = new Stack<T>(this.size);

            //

            return clone;
        }
    }
}
