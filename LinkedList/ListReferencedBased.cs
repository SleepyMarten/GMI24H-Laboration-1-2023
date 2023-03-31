using System;
using System.Reflection;

namespace LinkedList
{
    // This class will contain methods for find and node.
    public class ListReferencedBased : ListInterface
    {
        ListIndexOutOfBoundsException ex = new ListIndexOutOfBoundsException();
        private Node head;
        private Node find(int index)
        {
            if (index < 1 || index > size())
            {
                ex.indexOutOfBound();
            }
            Node current = head;
            for (int i = 1; i < index; i++)
            {
                current = current.getNext();
            }
            return current;
        }

        public int size()
        {
            int count = 0;
            Node current = head;
            while (current != null)
            {
                count++;
                current = current.getNext();
            }
            return count;
        }

        public void insert(int index, object item)
        {
            if (index < 1 || index > size() + 1)
            {
                ex.indexOutOfBound();
            }
            if (index == 1)
            {
                head = new Node(item, head);
            }
            else
            {
                Node previous = find(index - 1);
                Node newNode = new Node(item, previous.getNext());
                previous.setNext(newNode);
            }
        }


        public object get(int index)
        {
            if (index < 1 || index > size())
            {
                ex.indexOutOfBoundShowUser();
                return null;
            }

            Node current = head;
            for (int i = 1; i < index; i++)
            {
                current = current.getNext();
                
            }
            return current.getItem();
        }


        public void remove(int index)
        {
            if (size == null)
            {
                throw new Exception("List is empty.");
            }
            if (index < 1 || index > size())
            {
                throw new IndexOutOfRangeException();
            }
            if (index == 1)
            {
                head = head.getNext();
            }
            else
            {
                Node previous = find(index - 1);
                previous.setNext(previous.getNext().getNext());
            }
        }

        public void removeAll()
        {
            head = null;
        }

    }

}
