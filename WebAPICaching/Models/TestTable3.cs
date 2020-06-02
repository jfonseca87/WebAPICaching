using System;
using System.Collections.Generic;

namespace WebAPICaching.Models
{
    public partial class TestTable3
    {
        public int Id { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string Field4 { get; set; }
        public int? IdTestTable2 { get; set; }

        public virtual TestTable2 IdTestTable2Navigation { get; set; }
    }
}
