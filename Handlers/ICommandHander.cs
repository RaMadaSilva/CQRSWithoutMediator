using CQRWithoutMediator.Commands.Interfaces;

namespace CQRWithoutMediator.Handlers;
public interface ICommandHander<Request, Response> where Response : ICommandResult where Request : ICommand
{
    Task<Response> Handler(Request command);
}