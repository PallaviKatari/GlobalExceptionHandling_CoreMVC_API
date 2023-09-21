using System.Globalization;

namespace GlobalExceptionHandling_CoreMVC_API.Middleware1
{
    public class SomeException : Exception
    {
        public SomeException() : base()
        {
        }
        public SomeException(string message) : base(message)
        {
        }
        public SomeException(string message, params object[] args) : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }
}
