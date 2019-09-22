using System;
using System.Runtime.Serialization;

namespace AcccountManagement.Classes
{
    [Serializable]
    public class NegativeAmountException : Exception
    {
        public NegativeAmountException()
        {
        }

        public NegativeAmountException(string message) : base(message)
        {
        }

        public NegativeAmountException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NegativeAmountException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}