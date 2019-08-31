using System;
using System.Collections.Generic;

namespace Accounting.Core.Entities
{
    public partial class Recurrence
    {
        public int RecurrenceId { get; set; }
        public string RecurrenceDescription { get; set; }
        public string RecurrenceCategory { get; set; }
        public decimal RecurrenceAmount { get; set; }
        public string MonthlyDate { get; set; }
        public string WeeklyDay { get; set; }
        public int? MonthlyWeek { get; set; }
        public int? QuarterlyMonth { get; set; }
        public byte? WeekdayOnly { get; set; }
    }
}
