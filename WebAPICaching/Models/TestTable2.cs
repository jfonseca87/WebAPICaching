using System;
using System.Collections.Generic;

namespace WebAPICaching.Models
{
    public partial class TestTable2
    {
        public TestTable2()
        {
            TestTable3 = new HashSet<TestTable3>();
        }

        public int Id { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string Field4 { get; set; }
        public int? IdTestTable1 { get; set; }

        public virtual TestTable1 IdTestTable1Navigation { get; set; }
        public virtual ICollection<TestTable3> TestTable3 { get; set; }
    }
}
