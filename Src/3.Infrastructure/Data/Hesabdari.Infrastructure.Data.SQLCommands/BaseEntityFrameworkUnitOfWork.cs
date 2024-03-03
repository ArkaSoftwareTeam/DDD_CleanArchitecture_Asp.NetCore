using Hesabdari.Core.Contracts.Data.Commands;
namespace Hesabdari.Infrastructure.Data.SQLCommands
{
    public class BaseEntityFrameworkUnitOfWork<TDbContext> : IUnitOfWork where TDbContext:BaseCommandDbContext
    {

        #region Constactor
        protected readonly TDbContext _dbContext;

        public BaseEntityFrameworkUnitOfWork(TDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        public void BeginTransaction()
        {
            _dbContext.BeginTransaction();
        }

        public int Commit()
        {
            var result = _dbContext.SaveChanges();
            return result;
        }

        public async Task<int> CommitAsync()
        {
            var result = await _dbContext.SaveChangesAsync();
            return result;
        }

        public void CommitTransaction()
        {
            _dbContext.CommitTransaction();
        }

        public void RollbackTransaction()
        {
            _dbContext.RollbackTransaction();
        }
    }
}
