using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
       
        private object data { get; set; }
        private Node next { get; set; }
        public Node(object data, Node next)
        {
            this.data = data;
            this.next = next;
        }

        public object getItem()
        {
            return data;
        }
        /// <summary>
        /// This method returns a reference to the next node in the list.
        /// </summary>
        /// <returns>returns next Node</returns>
        public Node getNext()
        {
            return next;
        }
        /// <summary>
        /// Takes input NODE and then sets it as the next field of the current node to the inputed NODE.
        /// </summary>
        /// <param name="next"></param>
        public void setNext(Node next)
        {
            this.next = next;   
        }

    }
}
