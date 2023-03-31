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
            Console.WriteLine("ERROR || Index out of bound || ERROR");
        }

        public void indexOutOfBoundShowUser()
        {
            Console.WriteLine("ERROR || Inputed index number does not exist || ERROR");
        }

        public void wrongInputFormat()
        {
            Console.WriteLine("ERROR || INVALID INPUT FORMAT || ERROR");
        }        
        
        public void indexOutOfBoundTooHigh()
        {
            Console.WriteLine("ERROR || INVALID INDEX NUMBER, THE NUMBER INPUTED WAS TOO HIGH AND OUT OF BOUND. . INPUT A VALID INDEX NUMBER  || ERROR");
        }

        public void indexOutOfBoundTooLow()
        {
            Console.WriteLine("ERROR || INVALID INDEX NUMBER, THE NUMBER INPUTED WAS TOO LOW AND OUT OF BOUND. . INPUT A VALID INDEX NUMBER  || ERROR");
        }
        public void inputCannotBeNull()
        {
            Console.WriteLine("ERROR || INPUT CANNOT BE EMPTY/NULL  || ERROR");
        }
    }
}
