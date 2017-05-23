﻿using System;

namespace BudgetJars.API.Incomes
{
    public class IncomeModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public double Amount { get; set; }

        public DateTime Date { get; set; }

        public int UserId { get; set; }
    }
}
