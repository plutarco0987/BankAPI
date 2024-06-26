﻿using System;
using System.Collections.Generic;

namespace APIAzure.Data.BankModels
{
    public partial class BankTransaction
    {
        public int Id { get; set; }
        public int? AccountId { get; set; }
        public int? TransactionType { get; set; }
        public decimal? Amount { get; set; }
        public int? ExternalAccount { get; set; }
        public DateTime? RegDate { get; set; }

        public virtual Account? Account { get; set; }
        public virtual TransactionType? TransactionTypeNavigation { get; set; }
    }
}
