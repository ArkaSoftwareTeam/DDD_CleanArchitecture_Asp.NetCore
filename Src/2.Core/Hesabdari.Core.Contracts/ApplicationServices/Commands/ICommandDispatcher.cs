namespace Hesabdari.Core.Contracts.ApplicationServices.Commands
{
    public interface ICommandDispatcher
    {
        Task<CommandResult> Send<TCommand>(TCommand command) where TCommand : class, ICommands;

        Task<CommandResult<TData>> Send<TCommand, TData>(TCommand command) where TCommand: class, ICommands<TData>;

    }
}
