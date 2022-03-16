using Microsoft.VisualStudio.TestTools.UnitTesting;
using Containers;

namespace ContainersTests
{
    [TestClass]
    public class ContainerTest
    {
        [TestMethod]
        public void TestArrayLength()
        {
            DynArray array = new DynArray();
            Assert.AreEqual(array.GetLength(), 0);

            array = new DynArray(10);
            Assert.AreEqual(array.GetLength(), 10);
        }

        [TestMethod]
        public void TestArrayInsert()
        {
            DynArray array = new DynArray();
            array.Insert(10, 6);
            Assert.AreEqual(array.GetItemByIndex(6), 10);
        }

        [TestMethod]
        public void TestArrayPushBack()
        {
            DynArray array = new DynArray();
            array.PushBack(8);
            Assert.AreEqual(array.GetItemByIndex(array.GetLength() - 1), 8);
        }

        [TestMethod]
        public void TestArrayDelete()
        {
            DynArray array = new DynArray();
            for (int i = 0; i < 5; i++)
                array.PushBack(i);
            Assert.AreEqual(array.GetItemByIndex(2), array.Delete(2));
        }

        [TestMethod]
        public void TestArrayPopBack()
        {
            DynArray array = new DynArray();
            for (int i = 0; i < 5; i++)
                array.PushBack(i);
            Assert.AreEqual(array.GetItemByIndex(array.GetLength() - 1), array.PopBack());
        }
    }
}
