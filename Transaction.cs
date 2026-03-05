using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINANCETRAKER2
{
    internal class Transaction
    {
        public DateTime Date {get; set;}
        public string IncomeName { get; set; }
        public decimal incomeAmount { get; set; }
        public string ExpensesName { get; set; }
        public string expensesCat { get; set; }
        public decimal expenseAmount { get; set; }

        public decimal runningBalance { get; set; }

    }
}
