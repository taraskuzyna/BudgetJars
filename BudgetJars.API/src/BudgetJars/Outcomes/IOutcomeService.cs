using System.Collections.Generic;

namespace BudgetJars.API.Outcomes
{
    public interface IOutcomeService
    {
        List<OutcomeModel> GetOutcomes();

        OutcomeModel GetOutcomeById(int id);

        void AddOutcome(OutcomeModel model);

        void EditOutcome(OutcomeModel model);

        void DeleteOutcome(int id);
    }
}
