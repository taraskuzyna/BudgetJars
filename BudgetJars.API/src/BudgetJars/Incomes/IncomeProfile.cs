using AutoMapper;
using BudgetJars.API.DAL;

namespace BudgetJars.API.Incomes
{
    public class IncomeProfile : Profile
    {
        public IncomeProfile()
        {
            CreateMap<IncomeModel, Income>()
                .ForMember(dst => dst.User, opt => opt.Ignore());

            CreateMap<Income, IncomeModel>();
        }
    }
}
