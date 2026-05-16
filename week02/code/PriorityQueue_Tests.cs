using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue three items with different priorities: "low"(1), "high"(3), "mid"(2)
    // Expected Result: Dequeue returns "high", then "mid", then "low"
    // Defect(s) Found: Item was never removed after dequeue (missing RemoveAt).
    //                  Loop used Count-1, skipping the last element.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("low", 1);
        priorityQueue.Enqueue("high", 3);
        priorityQueue.Enqueue("mid", 2);

        Assert.AreEqual("high", priorityQueue.Dequeue());
        Assert.AreEqual("mid", priorityQueue.Dequeue());
        Assert.AreEqual("low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue two items with the same priority: "first"(2), "second"(2)
    // Expected Result: "first" is returned before "second" (FIFO for equal priorities)
    // Defect(s) Found: Using >= instead of > caused the last duplicate to win instead of the first.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("first", 2);
        priorityQueue.Enqueue("second", 2);

        Assert.AreEqual("first", priorityQueue.Dequeue());
        Assert.AreEqual("second", priorityQueue.Dequeue());
    }


    [TestMethod]
    // Scenario: Dequeue from an empty queue
    // Expected Result: InvalidOperationException with message "The queue is empty."
    // Defect(s) Found: None — this was already implemented correctly.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }

    [TestMethod]
    // Scenario: Enqueue "last"(5) at the end; it should still be dequeued first
    // Expected Result: "last" comes out first since Count-1 bug would have skipped it
    // Defect(s) Found: Loop stopping at Count-1 caused the last-enqueued item to never
    //                  be considered as the highest priority candidate.
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("a", 1);
        priorityQueue.Enqueue("b", 2);
        priorityQueue.Enqueue("last", 5); // highest priority, added last

        Assert.AreEqual("last", priorityQueue.Dequeue());
    }
}