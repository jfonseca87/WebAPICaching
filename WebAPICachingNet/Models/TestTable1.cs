namespace WebAPICachingNet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TestTable1
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Field1 { get; set; }

        [StringLength(50)]
        public string Field2 { get; set; }

        [StringLength(50)]
        public string Field3 { get; set; }

        [StringLength(50)]
        public string Field4 { get; set; }
    }
}
