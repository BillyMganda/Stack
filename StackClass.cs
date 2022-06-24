using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Language.StackFunctions
{
    public class StackClass
    {        
        //push
        public void pushFunction()
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            Console.WriteLine("This is the result of push function "+myStack); //it will return stack elements 1,2,3,4
        }
        //pop
        public void popFunction()
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            while (!myStack.IsEmpty())
            {
                Console.WriteLine(myStack.Pop()); //it will return stack elements 1,2,3
            }
        }
        //isEmty
        public bool isEmptyFunction()
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            if (myStack.IsEmpty())
            {
                return true;
            }
            else
            {
                return false; //the result will be false since the stack is not empty
            }
        }
        //peek
        public void peekFunction()
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            if (!myStack.IsEmpty())
            {
                myStack.peek(); //the result will be element 4 since it was added last
            }
            else
            {
                Console.WriteLine("Do nothing");
            }
        }        
    }
}
