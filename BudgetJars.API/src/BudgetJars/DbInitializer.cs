using System;
using System.Linq;

namespace BudgetJars.API
{
    public static class DbInitializer
    {
        public static void Initialize(BudgetJarsDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Count() == 0)
            {
                context.Users.Add(new DAL.User()
                {
                    DateOfBirth = DateTime.Now,
                    Email = "TK@wp.pl",
                    FirstName = "Taras",
                    LastName = "Kuzyna"
                });
                context.SaveChanges();
            }
        }
    }
}
