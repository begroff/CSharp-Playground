using System;
using System.Text;

namespace ThirtyDaysOfCode.Day16
{
    public class InvalidStringException : Exception
    {
        public InvalidStringException()
        {

        }

        public InvalidStringException(string message) : base(message)
        {

        }
    }
}