using System;
using System.Collections.Generic;

namespace Solvers
{
    public class LinkedListReverseIterator
    {
        public List<int> Reverse(LinkedListNode<int> node)
        {
            return ReverseUsingStack(node);
        }

        private List<int> ReverseUsingTwoLoops(LinkedListNode<int> node)
        {
            List<int> reverse = new List<int>();
            LinkedListNode<int> start = node;
            LinkedListNode<int> curr = null;

            while (curr != start)
            {
                LinkedListNode<int> end = start;
                while (end.Next != curr) end = end.Next;
                reverse.Add(end.Value);
                curr = end;
            }

            return reverse;
        }

        private List<int> ReverseUsingStack(LinkedListNode<int> node)
        {
            List<int> reverse = new List<int>();
            Stack<int> stack = new Stack<int>();
            LinkedListNode<int> curr = node;
            while (curr != null)
            {
                stack.Push(curr.Value);
                curr = curr.Next;
            }

            while (stack.Count > 0)
            {
                reverse.Add(stack.Pop());
            }

            return reverse;
        }
    }
}
