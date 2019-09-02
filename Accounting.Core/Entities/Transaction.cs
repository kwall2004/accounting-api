using System;
using System.ComponentModel.DataAnnotations;

namespace Accounting.Core.Entities
{
    public partial class Transaction
    {
        [Key]
        public int TransId { get; set; }
        public DateTime TransDate { get; set; }
        public string TransDescription { get; set; }
        public string TransCategory { get; set; }
        public decimal TransAmount { get; set; }
        public byte Cleared { get; set; }
        public int Account { get; set; }
    }
}
