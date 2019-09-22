using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace AcccountManagement.Classes
{
    public class InSufficientBalanceException : Exception
    {
        public InSufficientBalanceException()
        {
        }

        public InSufficientBalanceException(string message) : base(message)
        {
        }

        public InSufficientBalanceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InSufficientBalanceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
