using Shared.Exceptions;

namespace Application.Exceptions
{
    public class PageNotFoundException : BaseAppException
    {
        public override int StatusCode => 404;
        public override string Title => "Page not found";
        public override string Type => "https://httpstatuses.com/404";

        public PageNotFoundException() : base("The requested page does not exist.") {}
        public PageNotFoundException(string? message) : base(message) {}
        public PageNotFoundException(IEnumerable<string> errors, string message) : base(errors, message) {}
        public PageNotFoundException(string? message, Exception? innerException) : base(message, innerException) { }
    }
}
