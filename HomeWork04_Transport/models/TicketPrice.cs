namespace HomeWork04_Transport.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TicketPrice")]
    public partial class TicketPrice
    {
        [Key]
        [StringLength(50)]
        public string Startstation { get; set; }

        [Required]
        [StringLength(50)]
        public string Endstation { get; set; }

        public int Price { get; set; }
    }
}
