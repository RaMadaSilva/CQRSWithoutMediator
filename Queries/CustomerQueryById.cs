using CQRWithoutMediator.Commands.Interfaces;

namespace CQRWithoutMediator.Queries
{
    public record CustomerQueryById(Guid Id) : ICommand
    {
    }
}