using System;
using System.Collections.Generic;

namespace WebApplication2.ViewModels
{
    public class IndexViewModel
    {
        public List<AccountModel> Account { get; set; } = new List<AccountModel>();

        public class AccountModel
        {
            public int ID { get; set; }
            public string Category { get; set; }
            public DateTime Date { get; set; }
            public decimal Amount { get; set; }

        }
    }
}