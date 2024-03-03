using System.Net;

namespace Hesabdari.Core.Contracts.Data.Commands
{
    /// <summary>
    ///Interface definition for the UnitOfWork template to manage transactions with the database is done in this section.
    ///The full definition of this pattern is in the P of EAA book and the basic definition can be found at the address below
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// If you need to control transactions, this method is used to start the transaction.
        /// </summary>
        void BeginTransaction();

        /// <summary>
        /// In case of manual control of the transaction, this method is used to successfully end the transaction.
        /// </summary>
        void CommitTransaction();

        /// <summary>
        /// In case of errors in the processes, this method is used to return the changes.
        /// </summary>
        void RollbackTransaction();

        /// <summary>
        /// This method is used to confirm the transaction that was created automatically by the system.
        /// </summary>
        /// <returns></returns>
        int Commit();

        /// <summary>
        /// This method is used to confirm the transaction that was created automatically by the system.
        /// </summary>
        /// <returns></returns>
        Task<int> CommitAsync();
    }
}
