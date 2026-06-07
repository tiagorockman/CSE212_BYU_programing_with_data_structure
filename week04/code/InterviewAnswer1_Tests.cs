using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace code
{
    [TestClass]
    public class InterviewAnswer1_Tests
    {
        /*
              * xplain how you would use a linked list internally to 
              * implement a Stack. Make sure to explain the way
              * you would use the linked list AND the time complexity 
              * associated with each of the following operations:
              * Push Pop GetTop IsEmpty
              */

        /*
   head
   ↓
  +----+    +----+    +----+
  | 30 | -> | 20 | -> | 10 | -> null
  +----+    +----+    +----+
  */


        [TestMethod]
        public void GetTopCheck() {
            InterviewAnswer1 stack = new InterviewAnswer1();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            Assert.AreEqual(30, stack.GetTop()); // 30

        }

        [TestMethod]
        public void PopCheck()
        {
            InterviewAnswer1 stack = new InterviewAnswer1();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            Assert.AreEqual(30, stack.Pop());    // 30

        }

        [TestMethod]
        public void IsEmptyCheckFalse()
        {
            InterviewAnswer1 stack = new InterviewAnswer1();

            stack.Push(10);
            Assert.IsFalse(stack.IsEmpty()); // False
        }

        [TestMethod]
        public void IsEmptyCheckTrue()
        {
            InterviewAnswer1 stack = new InterviewAnswer1();
            stack.Push(10);
            stack.Push(20);
            Assert.AreEqual(20, stack.Pop()); // 20)
            Assert.AreEqual(10, stack.Pop()); // 10)
            Assert.IsTrue(stack.IsEmpty()); // True

        }
    } 
}
