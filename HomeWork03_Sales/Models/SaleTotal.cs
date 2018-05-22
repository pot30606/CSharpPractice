namespace HomeWork03_Sales.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SaleTotal")]
    public partial class SaleTotal
    {
        [Key]
        [StringLength(50)]
        public string Sales { get; set; }

        [Column("SaleTotal")]
        public int SaleTotal1 { get; set;}
    }
}
