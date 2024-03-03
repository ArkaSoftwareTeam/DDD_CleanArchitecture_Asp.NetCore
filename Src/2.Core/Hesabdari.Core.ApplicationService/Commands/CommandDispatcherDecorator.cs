using Hesabdari.Core.Contracts.ApplicationServices.Commands;
using System.Windows.Input;

namespace Hesabdari.Core.ApplicationService.Commands
{
    public abstract class CommandDispatcherDecorator:ICommandDispatcher
    {
        #region Fields
        protected ICommandDispatcher _commandDispatcher;
        public abstract int Order { get; }
        #endregion

        #region Constructors
        public CommandDispatcherDecorator()
        {
        }

        #endregion
        public void SetCommandDispatcher(ICommandDispatcher commandDispatcher)
        {
            _commandDispatcher = commandDispatcher;
        }
        #region Abstract Send Commands
        public abstract Task<CommandResult> Send<TCommand>(TCommand command) where TCommand : class, ICommands;

        public abstract Task<CommandResult<TData>> Send<TCommand, TData>(TCommand command) where TCommand : class, ICommands<TData>;
        #endregion
    }
}
