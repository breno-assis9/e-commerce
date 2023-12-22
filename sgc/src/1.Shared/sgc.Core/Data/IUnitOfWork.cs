namespace sgc.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
