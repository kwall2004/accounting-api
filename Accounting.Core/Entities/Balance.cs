using System;
using System.Collections.Generic;

namespace Accounting.Core.Entities
{
    public partial class Balance
    {
        public DateTime BalanceDate { get; set; }
        public decimal BalanceAmount { get; set; }
        public int Id { get; set; }
    }
}
