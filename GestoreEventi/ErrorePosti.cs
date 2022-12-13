using System.Runtime.Serialization;

namespace GestoreEventi
{
    [Serializable]
    internal class ErrorePosti : Exception
    {
        public ErrorePosti()
        {
        }

        public ErrorePosti(string? message) : base(message)
        {
        }

        public ErrorePosti(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ErrorePosti(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}