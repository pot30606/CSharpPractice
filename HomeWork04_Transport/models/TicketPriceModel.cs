namespace HomeWork04_Transport.models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TicketPriceModel : DbContext
    {
        public TicketPriceModel()
            : base("name=TicketPriceModel")
        {
        }

        public virtual DbSet<TicketPrice> TicketPrice { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
