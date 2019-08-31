using System;
using System.Collections.Generic;

namespace Accounting.Core.Entities
{
    public partial class Setting
    {
        public string SettingName { get; set; }
        public int Account { get; set; }
        public decimal DecimalValue { get; set; }
        public int Id { get; set; }
    }
}
