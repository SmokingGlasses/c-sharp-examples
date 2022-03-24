using System;
namespace interfaces
{
    public interface IUndoable
    {
        void Undo();
        void Log();
        void Error();
    }
}
