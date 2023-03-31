using System;



namespace LinkedList
{
    //rhis class will contain methods for find and node.
    public class ListReferencedBased:ListInterface
    {
        private Node head;

        public ListReferencedBased()
        {
            head = null;
        }

        public bool isEmpty => head == null;

        public int  size()
        {
            int count = 0;
            Node<T> current = head;
            while (current != null)
            {
                count++;
                current = current.getNext();
            }
            return count;
        }

        public void add(int index, object item)
        {
            if (index < 1 || index > size() + 1)
            {
                throw new IndexOutOfRangeException();
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

        public bool contains(object item)
        {
            throw new NotImplementedException();
        }

        public void get(int index)
        {
            if (index < 1 || index > size())
            {
                throw new IndexOutOfRangeException();
            }
            Node current = find(index);
            return current.getItem();
        }

        public void insert(object item)
        {
            throw new NotImplementedException();
        }

        public void remove(int index)
        {
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

        private Node find(int index)
        {
            if (index < 1 || index > size())
            {
                throw new IndexOutOfRangeException();
            }
            Node current = head;
            for (int i = 1; i < index; i++)
            {
                current = current.getNext();
            }
            return current;
        }

        public void add(object item)
        {
            throw new NotImplementedException();
        }
    }
}
