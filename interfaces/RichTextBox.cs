using System;

namespace interfaces
{
    public class RichTextBox : TextBox, IUndoable
    {
        public RichTextBox()
        {
            //
        }

        public void Error()
        {
            Console.WriteLine("RichTextBox.Error()");
        }

        public override void Undo()
        {
            Console.WriteLine("RichTextBox.Undo()");
        }

        public new void Log()
        {
            Console.WriteLine("RichTextBox.Log()");
        }
    }
}