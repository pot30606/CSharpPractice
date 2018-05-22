namespace HomeWork03_Sales.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalesSaleProduct")]
    public partial class SalesSaleProduct
    {
        [Key]
        [StringLength(50)]
        public string SalesName { get; set; }

        public string Product { set; get; }

        public int ProductNumber { set; get; }
    }
}
