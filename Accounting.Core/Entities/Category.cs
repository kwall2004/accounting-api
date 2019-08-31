using System;
using System.Collections.Generic;

namespace Accounting.Core.Entities
{
    public partial class Category
    {
        public string CategoryId { get; set; }
        public string CategoryDescription { get; set; }
        public string SuperCategory { get; set; }
    }
}
