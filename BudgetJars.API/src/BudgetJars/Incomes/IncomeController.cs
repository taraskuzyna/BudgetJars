using Microsoft.AspNetCore.Mvc;

namespace BudgetJars.API.Incomes
{
    [Route("api/[controller]")]
    public class IncomeController : Controller
    {
        private readonly IIncomeService service;

        public IncomeController(IIncomeService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetIncomes());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(service.GetIncomeById(id));
        }

        [HttpPost]
        public void Post([FromBody]IncomeModel model)
        {
            service.AddIncome(model);
        }

        [HttpPut]
        public void Put([FromBody]IncomeModel model)
        {
            service.EditIncome(model);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.DeleteIncome(id);
        }
    }
}
