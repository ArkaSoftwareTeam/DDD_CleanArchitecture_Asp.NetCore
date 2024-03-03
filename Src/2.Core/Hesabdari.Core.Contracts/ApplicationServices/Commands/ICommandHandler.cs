namespace Hesabdari.Core.Contracts.ApplicationServices.Commands
{
    public interface ICommandHandler<TCommand , TData> where TCommand : ICommands<TData>
    {
        Task<CommandResult<TData>> Handle(TCommand request);
    }


    public interface ICommandHandler<TCommand> where TCommand : ICommands
    {
        Task<CommandResult> Handle(TCommand request);
    }
}
