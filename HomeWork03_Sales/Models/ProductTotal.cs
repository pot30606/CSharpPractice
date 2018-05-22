namespace HomeWork03_Sales.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductTotal")]
    public partial class ProductTotal
    {
        [Key]
        [StringLength(50)]
        public string Product { get; set; }

        [Column("ProductTotal")]
        public int ProductTotal1 { get; set; }
    }
}
