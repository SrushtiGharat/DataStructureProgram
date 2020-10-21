using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructureProgram;
using System.Collections.Generic;

namespace LinkedListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenThreeNumbers_When_Added_ShouldBeAddedToTop()
        {
            LinkedList list = new LinkedList();

            list.AddNode(70);
            list.AddNode(30);
            list.AddNode(56);

            Assert.AreEqual(56, list.head.data);
        }
        [TestMethod]
        public void GivenThreeNumbers_When_Appended_ShouldBeAddedToLast()
        {
            LinkedList list = new LinkedList();

            list.AppendNode(56);
            list.AppendNode(30);
            list.AppendNode(70);

            Assert.AreEqual(56, list.head.data);
        }
        [TestMethod]
        public void GivenThreeNumbers_WhenInsertingSecondInBetween_ShouldBeAddedInBetween()
        {
            LinkedList list = new LinkedList();

            list.AppendNode(56);
            list.AppendNode(70);
            list.InsertAtPosition(30, 2);

            Assert.AreEqual(30, list.head.next.data);
        }
        [TestMethod]
        public void GivenThreeNumbers_WhenDeleteFirstNumber_ShouldReturn_RequiredResult()
        {
            LinkedList list = new LinkedList();

            list.AppendNode(56);
            list.AppendNode(30);
            list.AppendNode(70);

            Node head = list.RemoveFirstElement();

            Assert.AreEqual(30, head.data);
        }
    }
}
