using System;
namespace Containers
{
    public class MyStack
    {
        DynArray arr;

        public MyStack()
        {
            arr = new DynArray();
        }

        public bool IsEmpty()
        {
            return arr.GetLength() == 0;
        }

        public void Push(int value)
        {
            arr.PushBack(value);
        }

        public int Pop()
        {
            return arr.PopBack();
        }

        public void Print()
        {
            arr.Print();
        }
    }
}
