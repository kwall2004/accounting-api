using System;
using System.Collections.Generic;

namespace Accounting.Core.Entities
{
    public partial class Recurrencenew
    {
        public int RecurrenceId { get; set; }
        public string RecurrenceDescription { get; set; }
        public string RecurrenceCategory { get; set; }
        public decimal RecurrenceAmount { get; set; }
        public int? WeeklyFrequency { get; set; }
        public string WeeklyDay { get; set; }
        public int? MonthlyFrequency { get; set; }
        public int? MonthlyDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
