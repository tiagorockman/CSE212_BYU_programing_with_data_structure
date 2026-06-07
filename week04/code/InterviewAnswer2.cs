using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace code
{  
    
    public class NodeQueue
        {
            public int Value { get; set; }
            public NodeQueue? Next { get; set; }

            public NodeQueue(int value)
            {
                Value = value;
                Next = null;
            }
        }
    public class InterviewAnswer2
    {
        private NodeQueue? head;  // Front of queue
        private NodeQueue? tail;  // End of queue
        private int count;  // Track size

        public InterviewAnswer2()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public int Peek() //gets head value without removing it
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty");
           
            return head!.Value;
        }

        public int Tail() //gets tail value without removing it
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty");

            return tail!.Value;
        }

        // Enqueue - O(1)
        //create a new node and attach it to the current tail.
        //Then I update the tail reference to point to the new node.
        public void Enqueue(int value)
        {
            NodeQueue newNode = new NodeQueue(value);

            if (IsEmpty())
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail!.Next = newNode;
                tail = newNode;
            }

            count++;
        }

        // Dequeue - O(1)
        //To dequeue an element, takes the value from the head node and move the head reference to head.Next.
        //If removing the last element causes the queue to become empty, set both head and tail to null.
        public int Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty");

            int value = head!.Value;

            head = head.Next;

            count--;

            // Queue became empty
            if (head == null)
                tail = null;

            return value;
        }

        // Size - O(1)
        public int Size()
        {
            return count;
        }

        // IsEmpty - O(1)
        public bool IsEmpty()
        {
            return count == 0;
        }
    }
}
