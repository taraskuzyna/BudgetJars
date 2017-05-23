using System;

namespace BudgetJars.API.DAL
{
    public class Outcome : BaseEntity
    {
        public string Title { get; set; }

        public double Amount { get; set; }

        public DateTime Date { get; set; }

        public int UserId { get; set; }

        public int JarId { get; set; }

        public virtual User User { get; set; }

        public virtual Jar Jar { get; set; }
    }
}
