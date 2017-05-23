using System.Collections.Generic;

namespace BudgetJars.API.DAL
{
    public class Jar : BaseEntity
    {
        public string Name { get; set; }

        public double? Percentage { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public ICollection<Outcome> Outcomes { get; set; }
    }
}
