using System;

namespace interfaces
{
    public interface IRedoable : IUndoable
    {
        void Redo();
    }
}