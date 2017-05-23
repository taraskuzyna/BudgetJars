using System.Collections.Generic;

namespace BudgetJars.API.Incomes
{
    public interface IIncomeService
    {
        List<IncomeModel> GetIncomes();

        IncomeModel GetIncomeById(int id);

        void AddIncome(IncomeModel model);

        void EditIncome(IncomeModel model);

        void DeleteIncome(int id);
    }
}
