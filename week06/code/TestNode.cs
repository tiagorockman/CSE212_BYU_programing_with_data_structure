using System;
using System.Collections.Generic;
using System.Text;

namespace code
{
    public class TestNode
    {
        public int Data { get; set; }

        public TestNode? Left { get; set; }
        public TestNode? Right { get; set; }

        public TestNode(int data)
        {
            Data = data;
        }
    }
}
