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

        public Node getNext()
        {
            return next;
        }

        public void setNext(Node next)
        {
            this.next = next;   
        }

    }
}
