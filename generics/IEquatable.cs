using System;
namespace generics
{
    public interface IEquatable<T>
    {
        bool Equals(T obj);
    }
}
