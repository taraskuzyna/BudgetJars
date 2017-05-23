using AutoMapper;
using BudgetJars.API.DAL;
using BudgetJars.API.DAL.Repository;
using System.Collections.Generic;
using System.Linq;

namespace BudgetJars.API.Outcomes
{
    public class OutcomeService : IOutcomeService
    {
        private readonly IMapper mapper;
        private readonly IRepositoryFactory repositoryFactory;

        public OutcomeService(IMapper mapper, IRepositoryFactory repositoryFactory)
        {
            this.mapper = mapper;
            this.repositoryFactory = repositoryFactory;
        }

        public void AddOutcome(OutcomeModel model)
        {
            using (var repository = repositoryFactory.Create<Outcome>())
            {
                repository.Insert(mapper.Map<Outcome>(model));
            }
        }

        public void DeleteOutcome(int id)
        {
            using (var repository = repositoryFactory.Create<Outcome>())
            {
                var outcome = repository.Get(id);
                repository.Delete(outcome);
            }
        }

        public void EditOutcome(OutcomeModel model)
        {
            using (var repository = repositoryFactory.Create<Outcome>())
            {
                var outcome = repository.Get(model.Id);
                repository.Insert(mapper.Map(model, outcome));
            }
        }

        public OutcomeModel GetOutcomeById(int id)
        {
            using (var repository = repositoryFactory.Create<Outcome>())
            {
                return mapper.Map<OutcomeModel>(repository.Get(id));
            }
        }

        public List<OutcomeModel> GetOutcomes()
        {
            using (var repository = repositoryFactory.Create<Outcome>())
            {
                return repository.GetAll().Select(mapper.Map<OutcomeModel>).ToList();
            }
        }
    }
}
