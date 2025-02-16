using System;

namespace interfaces
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            RunInterfacesExample();
        }

        public static void RunInterfacesExample()
        {
            Console.WriteLine("\nInterfaces Example");

            Widget widget = new Widget();
            ((I1)widget).Foo();
            ((I2)widget).Foo();

            Console.WriteLine();

            IEnumerator enumerator = new Countdown();
            do
            {
                Console.Write(enumerator.Current + " ");
            } while (enumerator.MoveNext());

            Console.WriteLine();
            Console.WriteLine();

            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Error();                            // RichBoxText.Error()
            ((IUndoable)richTextBox).Error();               // RichBoxText.Error()

            Console.WriteLine();

            richTextBox.Undo();                             // RichBoxText.Undo()
            ((IUndoable)richTextBox).Undo();                // RichBoxText.Undo();
            ((TextBox)richTextBox).Undo();                  // RichBoxText.Undo();

            Console.WriteLine();

            richTextBox.Log();                              // RichBoxText.Log();
            ((IUndoable)richTextBox).Log();                 // RichBoxText.Log();
            ((TextBox)richTextBox).Log();                   // TextBox.Log();

            Console.WriteLine();

            S s = new S();
            s.Foo();                                        // No boxing

            I i = s;
            i.Foo();                                        // Box occurs when casting to interface
        }

        public struct S : I
        {
            public void Foo()
            {
                Console.WriteLine("Foo()");
            }
        }
    }
}