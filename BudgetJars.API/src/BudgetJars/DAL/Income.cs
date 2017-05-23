using System;

namespace BudgetJars.API.DAL
{
    public class Income : BaseEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public double Amount { get; set; }

        public DateTime Date { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
