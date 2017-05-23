using System;
using System.Collections.Generic;

namespace BudgetJars.API.DAL
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        public ICollection<Jar> Jars { get; set; }

        public ICollection<Income> Incomes { get; set; }

        public ICollection<Outcome> Outcomes { get; set; }
    }
}
