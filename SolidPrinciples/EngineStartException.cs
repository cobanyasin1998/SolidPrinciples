using System;
using System.Runtime.Serialization;

namespace SolidPrinciples
{
    [Serializable]
    public class EngineStartException : Exception
    {
        public EngineStartException()
        {
        }

        public EngineStartException(string message) : base(message)
        {
        }

        public EngineStartException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EngineStartException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}