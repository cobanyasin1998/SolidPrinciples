using System;
using System.Runtime.Serialization;

namespace SolidPrinciples
{
    [Serializable]
    public class AirPressureException : Exception
    {
        public AirPressureException()
        {
        }

        public AirPressureException(string message) : base(message)
        {
        }

        public AirPressureException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AirPressureException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}