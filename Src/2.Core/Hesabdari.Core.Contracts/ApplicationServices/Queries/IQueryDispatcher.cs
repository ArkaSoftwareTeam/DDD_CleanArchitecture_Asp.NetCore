namespace Hesabdari.Core.Contracts.ApplicationServices.Queries
{
    public interface IQueryDispatcher
    {
        Task<QueryResult<TData>> Execute<TQuery , TData>(TQuery query) where TQuery : class , IQuery<TData>;
    }
}
