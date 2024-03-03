using Hesabdari.Core.Contracts.ApplicationServices.Common;

namespace Hesabdari.Core.Contracts.ApplicationServices.Queries
{
    public class QueryResult<TData>:ApplicationServiceResult
    {
        public TData? _data;
        public TData? Data { get { return _data; } }
    }
}
