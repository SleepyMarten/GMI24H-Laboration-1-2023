using System.Reflection;

namespace LinkedList
{
    // This class will contain methods for find and node.
    public class ListReferencedBased : IListInterface
    {
        ListIndexOutOfBoundsException ex = new ListIndexOutOfBoundsException();
        private Node head;

        /// <summary>
        ///This method returns TRUE if the head is not null, else it will return FALSE.
        /// </summary>
        /// <returns>Boolean, True or False</returns>
		public bool isEmpty()
        {
            return head == null;
        }

		/// <summary>
		/// Finds the node at given index in the linked list, loop trough the nodes until found given node
		/// </summary>
		/// <param name="index"></param>
		/// <returns>Node</returns>
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
        //Method to check if index out of bound.
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
        /// <summary>
        /// Runs trough the nodes in the list and then returns the sum of the lists.
        /// each iteration makes the count variable increase.
        /// </summary>
        /// <returns>count</returns>
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
        /// <summary>
        /// Add or insert item into the list with the spesified index, throws indexOutOfBoundsTooHigh/Low depending on the index input.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="item"></param>
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
        /// <summary>
        /// Returns the item at the specified index. The method throws a indexOutOfBoundShowUser if the index is out of bounds.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Returns item from a spesified index</returns>
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

        /// <summary>
        /// Remove a node in the list from a spesific index input.
        /// </summary>
        /// <param name="index"></param>
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

        /// <summary>
        /// Removes all nodes from the list.
        /// </summary>
        public void removeAll()
        {
            head = null;
        }
        

    }

}
