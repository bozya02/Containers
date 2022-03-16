using System;
namespace Containers
{
    public class MyQueue
    {
        DynArray arr;

        public MyQueue()
        {
            arr = new DynArray();
        }

        public bool IsEmpty()
        {
            return arr.GetLength() == 0;
        }

        public void Push(int value)
        {
            arr.Insert(value, 0);
        }

        public int Pop()
        {
            return arr.PopBack();
        }

        public void Print()
        {
            arr.Print();
        }
        public int GetItemByIndex(int index)
        {
            return arr.GetItemByIndex(index);
        }

        public int GetLength()
        {
            return arr.GetLength();
        }
    }
}
