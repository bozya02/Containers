using Microsoft.VisualStudio.TestTools.UnitTesting;
using Containers;

namespace ContainersTests
{
    [TestClass]
    public class QueueTest
    {
        [TestMethod]
        public void IsQueueEmptyTest()
        {
            MyQueue queue = new MyQueue();

            Assert.IsTrue(queue.IsEmpty());
        }
        [TestMethod]
        public void PushQueueTest()
        {
            MyQueue queue = new MyQueue();
            queue.Push(5);
            Assert.AreEqual(queue.GetItemByIndex(0), 5);
        }
        [TestMethod]
        public void PopQueueTest()
        {
            MyQueue queue = new MyQueue();
            for (int i = 0; i < 5; i++)
                queue.Push(i);
            
            Assert.AreEqual(queue.GetItemByIndex(queue.GetLength() - 1), queue.Pop());
        }
    }
}
