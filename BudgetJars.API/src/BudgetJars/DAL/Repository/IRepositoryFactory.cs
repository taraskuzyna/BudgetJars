namespace BudgetJars.API.DAL.Repository
{
    public interface IRepositoryFactory
    {
        IRepository<T> Create<T>() where T : BaseEntity;
    }
}
