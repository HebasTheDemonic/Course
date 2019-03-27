using System;
using System.Runtime.Serialization;

namespace BankProject
{
    [Serializable]
    internal class CannotUseNegativeAmountException : Exception
    {
        public CannotUseNegativeAmountException()
        {
        }

        public CannotUseNegativeAmountException(string message) : base(message)
        {
        }

        public CannotUseNegativeAmountException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CannotUseNegativeAmountException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}