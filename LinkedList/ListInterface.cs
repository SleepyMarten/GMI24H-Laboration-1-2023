using Prometheus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    //Interface, keeping tabs on contracts within the linked list's ADT-Operations.
    public interface ListInterface
    {
        //Refer to Chapter 3, s.113.
        //bool isEmpty { get; } // Determines whether a list is empty.
        //int Size { get; } // Returns the number of items that are in a list.
        int size(); //Check the list size
        void insert(int index,object item); // Inserting item to list
        //void insert(object item); // Inserts item at position index of a list
        void remove(int index); //Removes the item at position index of a list
        void removeAll(); //remove all items in the list.
        object get(int index); // Returns the item at position index of a list
    }
}
