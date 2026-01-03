namespace ProductClientHub.Exceptions.Constructor
{
    public class ErrorOnTrimException : Exception
    {
        public ErrorOnTrimException()
        {
        }

        public ErrorOnTrimException(string? message) : base(message)
        {
        }
    }
}
