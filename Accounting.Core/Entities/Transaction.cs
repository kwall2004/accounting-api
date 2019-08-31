using System;
using System.Collections.Generic;

namespace Accounting.Core.Entities
{
    public partial class Transaction
    {
        public int TransId { get; set; }
        public DateTime TransDate { get; set; }
        public string TransDescription { get; set; }
        public string TransCategory { get; set; }
        public decimal TransAmount { get; set; }
        public byte Cleared { get; set; }
        public int Account { get; set; }
    }
}
