using AutoMapper;
using BudgetJars.API.DAL;
using BudgetJars.API.DAL.Repository;
using System.Collections.Generic;
using System.Linq;

namespace BudgetJars.API.Incomes
{
    public class IncomeService : IIncomeService
    {
        private readonly IMapper mapper;
        private readonly IRepositoryFactory repositoryFactory;

        public IncomeService(IMapper mapper, IRepositoryFactory repositoryFactory)
        {
            this.mapper = mapper;
            this.repositoryFactory = repositoryFactory;
        }

        public void AddIncome(IncomeModel model)
        {
            using (var repository = repositoryFactory.Create<Income>())
            {
                repository.Insert(mapper.Map<Income>(model));
            }
        }

        public void DeleteIncome(int id)
        {
            using (var repository = repositoryFactory.Create<Income>())
            {
                var income = repository.Get(id);
                repository.Delete(income);
            }
        }

        public void EditIncome(IncomeModel model)
        {
            using (var repository = repositoryFactory.Create<Income>())
            {
                var income = repository.Get(model.Id);
                repository.Update(mapper.Map(model, income));
            }
        }

        public IncomeModel GetIncomeById(int id)
        {
            using (var repository = repositoryFactory.Create<Income>())
            {
                return mapper.Map<IncomeModel>(repository.Get(id));
            }
        }

        public List<IncomeModel> GetIncomes()
        {
            using (var repository = repositoryFactory.Create<Income>())
            {
                return repository.GetAll().Select(mapper.Map<IncomeModel>).ToList();
            }
        }
    }
}
