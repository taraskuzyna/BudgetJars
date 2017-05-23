using System;

namespace BudgetJars.API.Outcomes
{
    public class OutcomeModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public double Amount { get; set; }

        public DateTime Date { get; set; }

        public int UserId { get; set; }

        public int JarId { get; set; }
    }
}
