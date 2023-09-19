using CQRWithoutMediator.Commands.Interfaces;

namespace CQRWithoutMediator.Queries
{
    public sealed record CustomerQueryResult(Guid Id,
            string Name,
            string Email) : ICommandResult;
}
