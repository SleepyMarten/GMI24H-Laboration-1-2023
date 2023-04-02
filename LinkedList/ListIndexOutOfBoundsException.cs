using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class ListIndexOutOfBoundsException
    {

        public void indexOutOfBound()
        {
            Console.WriteLine("ERROR || Index out of bound");
        }

        public void indexOutOfBoundShowUser()
        {
            Console.WriteLine("ERROR || Inputed index number does not exist");
        }

        public void wrongInputFormat()
        {
            Console.WriteLine("ERROR || INVALID INPUT FORMAT");
        }        
        
        public void indexOutOfBoundTooHigh()
        {
            Console.WriteLine("ERROR || INVALID index number, the INPUT was TOO HIGH!");
        }

        public void indexOutOfBoundTooLow()
        {
            Console.WriteLine("ERROR || INVALID index number, the INPUT was TOO LOW!");
        }
        public void inputCannotBeEmptyOrNull()
        {
            Console.WriteLine("ERROR || INPUT CANNOT BE EMPTY/NULL  || ERROR");
        }
    }
}
