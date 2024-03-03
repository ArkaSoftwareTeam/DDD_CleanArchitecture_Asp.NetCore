using Hesabdari.Core.Contracts.Data.Commands;
using Hesabdari.Core.Domain.Entities;
using Hesabdari.Core.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Hesabdari.Infrastructure.Data.SQLCommands
{
    public class BaseCommandRepository<TEntity, TDbContext> : ICommandRepository<TEntity>, IUnitOfWork
        where TEntity : AggregateRoot
        where TDbContext : BaseCommandDbContext
    {

        #region Constractor
        protected readonly TDbContext _dbContext;

        public BaseCommandRepository(TDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion


        #region Read Methods
        public TEntity Get(long Id)
        {
            return _dbContext.Set<TEntity>().Find(Id)!;
        }
        public TEntity Get(BusinessId businessId)
        {
            return _dbContext.Set<TEntity>().FirstOrDefault(x => x.BusinessId == businessId)!;
        }

        public async Task<TEntity> GetAsync(long Id)
        {
            var result = await _dbContext.Set<TEntity>().FindAsync(Id);
            return result!;
        }

        public async Task<TEntity> GetAsync(BusinessId businessId)
        {
            var result = await _dbContext.Set<TEntity>().FirstOrDefaultAsync(x => x.BusinessId == businessId);
            return result!;
        }
        #endregion

        #region Read Single Item With Graph Methods
        public TEntity GetGraph(long id)
        {
            var graphPath = _dbContext.GetIncludePaths(typeof(TEntity));
            IQueryable<TEntity> query = _dbContext.Set<TEntity>().AsQueryable();
            var temp = graphPath.ToList();
            foreach (var item in graphPath)
            {
                query = query.Include(item);
            }
            return query.FirstOrDefault(c => c.Id.Equals(id))!;
        }
        public TEntity GetGraph(BusinessId businessId)
        {
            var graphPath = _dbContext.GetIncludePaths(typeof(TEntity));
            IQueryable<TEntity> query = _dbContext.Set<TEntity>().AsQueryable();
            var temp = graphPath.ToList();
            foreach (var item in graphPath)
            {
                query = query.Include(item);
            }
            return query.FirstOrDefault(c => c.BusinessId == businessId)!;
        }
        public async Task<TEntity> GetGraphAsync(long id)
        {
            var graphPath = _dbContext.GetIncludePaths(typeof(TEntity));
            IQueryable<TEntity> query = _dbContext.Set<TEntity>().AsQueryable();
            foreach (var item in graphPath)
            {
                query = query.Include(item);
            }
            var result = await query.FirstOrDefaultAsync(c => c.Id.Equals(id));
            return result!;
        }
        public async Task<TEntity> GetGraphAsync(BusinessId businessId)
        {
            var graphPath = _dbContext.GetIncludePaths(typeof(TEntity));
            IQueryable<TEntity> query = _dbContext.Set<TEntity>().AsQueryable();
            foreach (var item in graphPath)
            {
                query = query.Include(item);
            }
            var result = await query.FirstOrDefaultAsync(c => c.BusinessId == businessId);
            return result!;
        }
        #endregion

        #region Insert Methods

        public void Insert(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
        }

        public async Task InsertAsync(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
        }
        #endregion

        #region Deleted Methods

        public void Delete(long Id)
        {
            var entity = _dbContext.Set<TEntity>().Find(Id);
            _dbContext.Set<TEntity>().Remove(entity!);
        }

        public void Delete(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
        }

        public void DeleteGraph(long Id)
        {
            var entity = GetGraph(Id);
            if (entity is not null && !entity.Id.Equals(default))
                _dbContext.Set<Entity>().Remove(entity);
        }
        #endregion

        #region Exists Methods
        public bool Exists(Expression<Func<TEntity, bool>> expression)
        {
            return _dbContext.Set<TEntity>().Any(expression);
        }

        public async Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await _dbContext.Set<TEntity>().AnyAsync(expression);
        }
        #endregion

        #region Transactions Managments Methods
  

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }

        public Task<int> CommitAsync()
        {
            return _dbContext.SaveChangesAsync();
        }
        public void BeginTransaction()
        {
            _dbContext.BeginTransaction();
        }
        public void CommitTransaction()
        {
            _dbContext.CommitTransaction();
        }

        public void RollbackTransaction()
        {
            _dbContext.RollbackTransaction();
        }
        #endregion

    }


    //public class BaseCommandRepository<TEntity, TDbContext> : BaseCommandRepository<TEntity, TDbContext, long>
    //where TEntity : AggregateRoot
    //where TDbContext : BaseCommandDbContext
    //{
    //    public BaseCommandRepository(TDbContext dbContext) : base(dbContext)
    //    {
    //    }
    //}
}
