using Hesabdari.Core.Contracts.ApplicationServices.Common;

namespace Hesabdari.Core.Contracts.ApplicationServices.Commands
{
    public class CommandResult:ApplicationServiceResult
    {
    }


    public class CommandResult<TData> : ApplicationServiceResult
    {
        public TData? _data;
        public TData? Data { get {  return _data; } }
    }

}
