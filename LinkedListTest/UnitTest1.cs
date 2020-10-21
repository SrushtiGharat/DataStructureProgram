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
    }
}
