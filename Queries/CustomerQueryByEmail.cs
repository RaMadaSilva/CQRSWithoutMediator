using CQRWithoutMediator.Commands.Interfaces;

namespace CQRWithoutMediator.Queries
{
    public record CustomerQueryByEmail(string Email) : ICommand
    {
    }
}