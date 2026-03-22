using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue three items with different priorities and dequeue them.
    // Expected Result: Items should be dequeued in the order of their priority (highest first).
    // Defect(s) Found: Dequeue was not working as intended. It was getting the second element. It also does not remove the item after finding it.
    public void TestPriorityQueue_BasicPriority()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 1);
        priorityQueue.Enqueue("Item2", 3);
        priorityQueue.Enqueue("Item3", 2);

        Assert.AreEqual("Item2", priorityQueue.Dequeue());
        Assert.AreEqual("Item3", priorityQueue.Dequeue());
        Assert.AreEqual("Item1", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with the same highest priority.
    // Expected Result: Items with the same priority should be dequeued in FIFO order.
    // Defect(s) Found: Dequeue was not working as intended. It was getting the second element. It also does not remove the item after finding it.
    public void TestPriorityQueue_SamePriorityFIFO()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 2);
        priorityQueue.Enqueue("Item2", 2);
        priorityQueue.Enqueue("Item3", 1);

        Assert.AreEqual("Item1", priorityQueue.Dequeue());
        Assert.AreEqual("Item2", priorityQueue.Dequeue());
        Assert.AreEqual("Item3", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue and dequeue items with negative priorities.
    // Expected Result: Negative priorities should be handled correctly, with less negative numbers having higher priority.
    // Defect(s) Found: Dequeue was not working as intended. It was getting the second element. It also does not remove the item after finding it.
    public void TestPriorityQueue_NegativePriority()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", -1);
        priorityQueue.Enqueue("Item2", -3);
        priorityQueue.Enqueue("Item3", -2);

        Assert.AreEqual("Item1", priorityQueue.Dequeue());
        Assert.AreEqual("Item3", priorityQueue.Dequeue());
        Assert.AreEqual("Item2", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue a mix of items with positive, negative, and zero priority.
    // Expected Result: Items should be dequeued according to their priority, with positive numbers > 0 > negative numbers.
    // Defect(s) Found: Dequeue was not working as intended. It was getting the second element. It also does not remove the item after finding it.
    public void TestPriorityQueue_MixedPriorities()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 1);
        priorityQueue.Enqueue("Item2", -1);
        priorityQueue.Enqueue("Item3", 0);

        Assert.AreEqual("Item1", priorityQueue.Dequeue());
        Assert.AreEqual("Item3", priorityQueue.Dequeue());
        Assert.AreEqual("Item2", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue an item from an empty queue.
    // Expected Result: An InvalidOperationException should be thrown with the message "The queue is empty."
    // Defect(s) Found: No defects found.
    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Expected an InvalidOperationException to be thrown.");
        }
        catch (InvalidOperationException ex)
        {
            Assert.AreEqual("The queue is empty.", ex.Message);
        }
        catch (Exception ex)
        {
            Assert.Fail($"Unexpected exception thrown: {ex.GetType().Name} - {ex.Message}");
        }
    }

}