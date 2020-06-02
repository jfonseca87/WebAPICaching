using System;
using System.Collections.Generic;

namespace WebAPICaching.Models
{
    public partial class TestTable1
    {
        public TestTable1()
        {
            TestTable2 = new HashSet<TestTable2>();
        }

        public int Id { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string Field4 { get; set; }

        public virtual ICollection<TestTable2> TestTable2 { get; set; }
    }
}
