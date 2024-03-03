using Hesabdari.Core.Domain.Entities;
using Hesabdari.Core.Domain.ValueObjects;
using System.Linq.Expressions;

namespace Hesabdari.Core.Contracts.Data.Commands
{

    /// <summary>
    /// If the data is stored normally, this interface is used to determine the main actions available in the data storage section.
    /// </summary>
    /// <typeparam name="TEntity">The class that is selected for storage</typeparam>
    public interface ICommandRepository<TEntity> : IUnitOfWork where TEntity : AggregateRoot
    {
        /// <summary>
        /// Delete Object With Identity Number
        /// </summary>
        /// <param name="Id">IdentityNumber</param>
        void Delete(long Id);


        /// <summary>
        /// Delete Object And All Children With Identity Number
        /// </summary>
        /// <param name="Id">IdentityNumber</param>
        void DeleteGraph(long Id);


        /// <summary>
        /// Receives an object and deletes it from the database
        /// </summary>
        /// <param name="entity">Object</param>
        void Delete(TEntity entity);


        /// <summary>
        /// Adds new data to the database
        /// </summary>
        /// <param name="entity">An Example of an Object that should be entered into the database</param>
        void Insert(TEntity entity);


        /// <summary>
        /// Adds new data to the database
        /// </summary>
        /// <param name="entity">An Example of an Object that should be entered into the database</param>
        /// <returns></returns>
        Task InsertAsync(TEntity entity);


        /// <summary>
        /// Finds and returns an object from the database using the identifier
        /// </summary>
        /// <param name="Id">ID of the desired object</param>
        /// <returns>A built instance of the object</returns>
        TEntity Get(long Id);
        Task<TEntity> GetAsync(long Id);
        TEntity Get(BusinessId businessId);
        Task<TEntity> GetAsync(BusinessId businessId);
        TEntity GetGraph(long id);
        Task<TEntity> GetGraphAsync(long id);
        TEntity GetGraph(BusinessId businessId);
        Task<TEntity> GetGraphAsync(BusinessId businessId);


        /// <summary>
        /// Determines whether the desired object has already been registered or not?
        /// </summary>
        /// <param name="expression">Receives an object with the ability to check the condition as input</param>
        /// <returns>True or False</returns>
        bool Exists(Expression<Func<TEntity, bool>> expression);
        Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> expression);

    }
}
