using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.assignment4
{
    class StackException : Exception
    {
        public StackException(string message) : base(message)
        {
        }
    }
}
