using Microsoft.AspNetCore.Mvc;

namespace BudgetJars.API.Outcomes
{
    [Route("api/[controller]")]
    public class OutcomeController : Controller
    {
        private readonly IOutcomeService service;

        public OutcomeController(IOutcomeService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetOutcomes());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(service.GetOutcomeById(id));
        }

        [HttpPost]
        public void Post([FromBody]OutcomeModel model)
        {
            service.AddOutcome(model);
        }

        [HttpPut]
        public void Put([FromBody]OutcomeModel model)
        {
            service.EditOutcome(model);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.DeleteOutcome(id);
        }
    }
}
