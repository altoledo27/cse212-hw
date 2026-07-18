using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Queue contains two high priority on the middle of the queue.
    // Expected Result: B, C, D, E, A
    // Defect(s) Found: The _queue.Count -1 because itnever examined the last element of the queue. 
    //Second: The program was using >= to determinate the which will be the highst priority. This is a defect when we have the same priority, because when the first high priority element is found, and we compare again, the condition of _queue[index].Priority >=_queue[highPriorityIndex].Priority will be true and the value that is going to appear first will be C instead B. 
    //Thrird: The item is never removed because we don't have the 'Remove At' method . 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 4);
        priorityQueue.Enqueue("C", 4);
        priorityQueue.Enqueue("D", 2);
        priorityQueue.Enqueue("E", 2);

        string[] expectedResult = { "B", "C", "D", "E", "A" };

        int i = 0;
        while (i < expectedResult.Length)
        {
            Assert.AreEqual(expectedResult[i], priorityQueue.Dequeue());
            i++;
        }
    }

    [TestMethod]
    // Scenario: There are not elements on the queue
    // Expected Result: An InvalidOperationExpection is thrown
    // Defect(s) Found: The exception throws 'The queue is empty.' and the test ask for 'No value in the queue.'
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("No value in the queue.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }

    // Add more test cases as needed below.
}