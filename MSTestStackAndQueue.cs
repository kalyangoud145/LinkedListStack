using LinkedListStackDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestStackAndQueue
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Converts to check element is added to stack true case.
        /// </summary>
        [TestMethod]
        public void ToCheckElementIsAddedToStackEndPosition_TrueCase()
        {
            //Arrange
            int expected1 = 60;
            int expected2 = 50;
            //Act
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(50);
            linkedListStack.Push(60);
            //Assert
            Assert.AreEqual(expected1, linkedListStack.top.data);
            Assert.AreEqual(expected2, linkedListStack.top.next.data);
        }
        /// <summary>
        /// Converts to check element is added to stack false case.
        /// </summary>
        [TestMethod]
        public void To_CheckElementIsAddedToStack_FalseCase()
        {
            //Arrange
            int expected1 = 50;
            int expected2 = 60;
            //Act
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(50);
            linkedListStack.Push(60);
            //Assert
            Assert.AreNotEqual(expected1, linkedListStack.top.data);
            Assert.AreNotEqual(expected2, linkedListStack.top.next.data);
        }
        /// <summary>
        /// To peek the element in the stack true case.
        /// </summary>
        [TestMethod]
        public void To_PeekTheElementInTheStack_TrueCase()
        {
            //Arrange
            int expected = 60;
            //Act
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(50);
            linkedListStack.Push(60);
            //Assert
            Assert.AreEqual(expected, linkedListStack.Peek());
        }
        /// <summary>
        /// To peek the element in the stack false case
        /// </summary>
        [TestMethod]
        public void To_PeekTheElementInTheStack_FalseCase()
        {
            //Arrange
            int expected = 50;
            //Act
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(50);
            linkedListStack.Push(60);
            //Assert
            Assert.AreNotEqual(expected, linkedListStack.Peek());
        }
        /// <summary>
        /// To remove the  top element from the stack  and should return next element
        /// </summary>
        [TestMethod]
        public void To_PopTheElementInTheStack_TrueCase()
        {
            //Arrange
            int expected = 60;
            //Act
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(50);
            linkedListStack.Push(60);
            linkedListStack.Push(70);
            linkedListStack.Pop();
            //Assert
            Assert.AreEqual(expected, linkedListStack.top.data);
        }
        /// <summary>
        /// Check element is added to queue valid case
        /// </summary>
        [TestMethod]
        public void ToCheckElementIsAddedToQueue_TrueCase()
        {
            //Arrange
            int expected1 = 50;
            int expected2 = 60;
            //Act
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(50);
            linkedListQueue.Enqueue(60);
            //Assert
            Assert.AreEqual(expected1, linkedListQueue.head.data);
            Assert.AreEqual(expected2, linkedListQueue.head.next.data);
        }
        /// <summary>
        /// Check element is added to queue .false case
        /// </summary>
        [TestMethod]
        public void ToCheckElementIsAddedToQueue_FalseCase()
        {
            //Arrange
            int expected1 = 60;
            int expected2 = 50;
            //Act
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(50);
            linkedListQueue.Enqueue(60);
            //Assert
            Assert.AreNotEqual(expected1, linkedListQueue.head.data);
            Assert.AreNotEqual(expected2, linkedListQueue.head.next.data);
        }
        /// <summary>
        /// Check element is removed from queue true case
        /// </summary>
        [TestMethod]
        public void ToCheckElementIsRemovedFromQueue_TrueCase()
        {
            //Arrange
            int expected1 = 60;
            //Act
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(50);
            linkedListQueue.Enqueue(60);
            linkedListQueue.DeQueue();
            //Assert
            Assert.AreEqual(expected1, linkedListQueue.head.data);
        }
        /// <summary>
        /// Check element is removed from queue false case
        /// </summary>
        [TestMethod]
        public void ToCheckElementIsRemovedFromQueue_FalseCase()
        {
            //Arrange
            int expected1 = 50;
            //Act
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(50);
            linkedListQueue.Enqueue(60);
            linkedListQueue.DeQueue();
            //Assert
            Assert.AreNotEqual(expected1, linkedListQueue.head.data);
        }

    }
}
