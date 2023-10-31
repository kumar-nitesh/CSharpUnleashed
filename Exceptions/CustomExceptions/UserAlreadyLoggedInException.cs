using System;
using System.Runtime.Serialization;

namespace CustomExceptions
{
    /// <summary>
    /// If you want your Exception class object to work across application domains, then the object must be serializable.To make your exception class 
    /// serializable mark it with Serializable attribute and provide a constructor that invokes the base Exception class constructor that takes in 
    /// SerializationInfo and StreamingContext objects as parameters.
    /// </summary>
    /// <seealso cref="System.Exception" />
    [Serializable]
    public class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException()
        {

        }

        public UserAlreadyLoggedInException(string message) : base(message)
        {

        }

        public UserAlreadyLoggedInException(string message, Exception innerException) : base(message, innerException)
        {

        }

        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
