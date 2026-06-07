using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace code
{
    [TestClass]
    public class InterviewAnswer2_Tests
    {
        [TestMethod]
        public void EnqueueTest()
        {
            InterviewAnswer2 queue = new InterviewAnswer2();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Assert.AreEqual(3, queue.Size());


            /*


            head                    tail
             ↓                        ↓
            +----+    +----+    +----+
            | 10 | -> | 20 | -> | 30 | -> null
            +----+    +----+    +----+
            If I call Dequeue(), the value 10 is removed:

            head           tail
             ↓               ↓
            +----+    +----+
            | 20 | -> | 30 | -> null
            +----+    +----+
            */
        }

        [TestMethod]
        public void HeadTailTest()
        {
            InterviewAnswer2 queue = new InterviewAnswer2();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            queue.Dequeue(); // Dequeue 10
            Assert.AreEqual(20, queue.Peek());
            Assert.AreEqual(30, queue.Tail());

        }

        [TestMethod]
        public void DequeueTest()
        {
            InterviewAnswer2 queue = new InterviewAnswer2();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            Assert.AreEqual(10, queue.Dequeue());
        }

        [TestMethod]
        public void EmptyQueueTest()
        {
            InterviewAnswer2 queue = new InterviewAnswer2();
            Assert.ThrowsException<InvalidOperationException>(() => queue.Dequeue());
            Assert.ThrowsException<InvalidOperationException>(() => queue.Peek());
            Assert.ThrowsException<InvalidOperationException>(() => queue.Tail());

        }
        [TestMethod]
        public void EmptyAfterDequeueTest()
        {
            InterviewAnswer2 queue = new InterviewAnswer2();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            Assert.AreEqual(10, queue.Dequeue());
            Assert.AreEqual(20, queue.Dequeue());
            Assert.AreEqual(30, queue.Dequeue());
            Assert.IsTrue(queue.IsEmpty());
        }

    }
}
