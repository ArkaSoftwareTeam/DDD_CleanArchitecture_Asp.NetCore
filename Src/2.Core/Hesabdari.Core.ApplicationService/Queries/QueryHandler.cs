using Hesabdari.Core.Contracts.ApplicationServices.Common;
using Hesabdari.Core.Contracts.ApplicationServices.Queries;
using Hesabdari.Utilities.Services;

namespace Hesabdari.Core.ApplicationService.Queries
{
    public abstract class QueryHandler<TQuery, TData> : IQueryHandler<TQuery, TData>
        where TQuery : class, IQuery<TData>
    {
        protected readonly HesabdariServices _HesabdariServices;
        protected readonly QueryResult<TData> result = new();
        protected virtual Task<QueryResult<TData>> ResultAsync(TData data, ApplicationServiceStatus status)
        {
            result._data = data;
            result.Status = status;
            return Task.FromResult(result);
        }
        protected virtual QueryResult<TData> Result(TData data, ApplicationServiceStatus status)
        {
            result._data = data;
            result.Status = status;
            return result;
        }
        protected virtual Task<QueryResult<TData>> ResultAsync(TData data)
        {
            var status = data != null ? ApplicationServiceStatus.Ok : ApplicationServiceStatus.NotFound;
            return ResultAsync(data, status);
        }
        protected virtual QueryResult<TData> Result(TData data)
        {
            var status = data != null ? ApplicationServiceStatus.Ok : ApplicationServiceStatus.NotFound;
            return Result(data, status);
        }

        public QueryHandler(HesabdariServices HesabdariServices)
        {
            _HesabdariServices = HesabdariServices;
        }

        //protected void AddMessage(string message)
        //{
        //    result.AddMessage(_HesabdariServices.Translator[message]);
        //}

        //protected void AddMessage(string message, params string[] arguments)
        //{
        //    result.AddMessage(_HesabdariServices.Translator[message, arguments]);
        //}
        public abstract Task<QueryResult<TData>> Handle(TQuery query);
    }

    
}
