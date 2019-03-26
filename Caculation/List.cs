using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculation
{
    class List<T>
    {
        Node<T> head;
        public List()
        {
            head = new Node<T>();
        }
        public void Add(T item)
        {
            Node<T> temp = head;
            head.current = item;
            head.pervious = null;
            head.next = temp;
        }
        public T Remove()
        {
            Node<T> temp = head;
            head.pervious.pervious.next = null;
            head = head.pervious;
            return temp.current;
        }
        public int Count()
        {
            return Length(head);
        }
        private int Length(Node<T> item)
        {
            if(item.next == null)
            {
                return 1;
            }
            else
            {
                return Length(item.next);
            }
        }
        public T Remove(int i)
        {
            Node<T> temp = GetIndexNode(i, head);
            head.pervious.next = null;
            head = temp.pervious;
            return temp.current;
        }
        // function which takes an index and finds the node at the index
        public Node<T> GetIndexNode(int i, Node<T> head)
        {
            if(head.next == null)
            {
                Console.WriteLine("INDEX NOT VAILD NULL POINTER");
                return null;
            }
            if(i == 0)
            {
                return head;
            }
            else
            {
                return GetIndexNode(i -1, head.next);
            }
        }
        public T Peek()
        {
            return head.current;
        }
        public T Peek(int i)
        {
            return GetIndexNode(i, head).current;
        }
        
    }
}
