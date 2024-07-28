namespace CustomerServer.Core.Domain.Exceptions;

public sealed class CustomerNotFoundException : NotFoundException
{
    public CustomerNotFoundException(int id)
    : base($"The customer with id {id} was not found.") { }
}