namespace CustomerServer.Core.Domain.Exceptions;

public abstract class NotFoundException : Exception
{
    protected NotFoundException(string message) : base(message) { }
}