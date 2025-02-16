using System;

namespace interfaces
{
    public class TextBox : IUndoable
    {
        public TextBox()
        {
            //
        }

        void IUndoable.Error()
        {
            Console.WriteLine("TextBox.Error()");
        }

        public virtual void Undo()
        {
            Console.WriteLine("TextBox.Undo()");
        }

        public void Log()
        {
            Console.WriteLine("TextBox.Log()");
        }
    }
}