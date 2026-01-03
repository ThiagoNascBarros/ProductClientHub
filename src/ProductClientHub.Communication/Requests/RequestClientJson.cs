using ProductClientHub.Exceptions.Constructor;

namespace ProductClientHub.Communication.Requests
{
    public class RequestClientJson
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public RequestClientJson(string name, string email)
        {
            try
            {
                Name = name.Trim();
                Email = email.Trim();
            }
            catch (ErrorOnTrimException)
            {
                throw new ErrorOnTrimException();
            }
        }
    }
}
