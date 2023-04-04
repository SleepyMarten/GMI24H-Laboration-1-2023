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
        /// <summary>
        /// Get the data property of the node object.
        /// </summary>
        /// <returns>data</returns>
        public object getItem()
        {
            return data;
        }
        /// <summary>
        /// Get the next property of the node object.
        /// </summary>
        /// <returns>next Node</returns>
        public Node getNext()
        {
            return next;
        }
        /// <summary>
        /// Set the node obect as next object of the current object.
        /// </summary>
        /// <param name="next"></param>
        public void setNext(Node next)
        {
            this.next = next;   
        }

    }
}
