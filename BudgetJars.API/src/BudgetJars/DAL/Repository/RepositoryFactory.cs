namespace BudgetJars.API.DAL.Repository
{
    public class RepositoryFactory : IRepositoryFactory
    {
        private readonly BudgetJarsDbContext context;

        public RepositoryFactory(BudgetJarsDbContext context)
        {
            this.context = context;
        }

        public IRepository<T> Create<T>() where T : BaseEntity
        {
            return new Repository<T>(context);
        }
    }
}
