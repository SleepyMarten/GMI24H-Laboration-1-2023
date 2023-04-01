using System;
using System.Reflection;

namespace LinkedList
{
    // This class will contain methods for find and node.
    public class ListReferencedBased : IListInterface
    {
        ListIndexOutOfBoundsException ex = new ListIndexOutOfBoundsException();
        private Node head;

		/// <summary>
		///This methon return TRUE if the head was't null, else it return FALSE
		/// </summary>
		public bool isEmpty()
        {
            return head == null;
        }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
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
              //break;
            }
            return current;
        }
        void outOfBound(int index)
        {
            if (index < 1 || index > size() + 1)
            {
                ex.indexOutOfBoundTooHigh();
            }
            if (index > size() + 1)
            {
                ex.indexOutOfBoundTooLow();
            }

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
            outOfBound(index);
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
            outOfBound(index);
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
