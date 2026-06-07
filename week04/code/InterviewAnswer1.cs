using System;
using System.Collections.Generic;
using System.Text;

namespace code
{
    public class NodeStack
    {
        public int Value { get; set; }
        public NodeStack Next { get; set; }

        public NodeStack(int value)
        {
            Value = value;
            Next = null;
        }
    }

    public class InterviewAnswer1
    {
        private NodeStack head; // Top of the stack

        // Push - O(1)
        public void Push(int value)
        {
            NodeStack newNode = new NodeStack(value);

            newNode.Next = head;
            head = newNode;
        }

        // Pop - O(1)
        public int Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty");

            int value = head.Value;
            head = head.Next;

            return value;
        }

        // GetTop / Peek - O(1)
        public int GetTop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty");

            return head.Value;
        }

        // IsEmpty - O(1)
        public bool IsEmpty()
        {
            return head == null;
        }



      
    }
}
