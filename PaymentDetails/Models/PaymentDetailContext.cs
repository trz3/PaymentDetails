using Microsoft.EntityFrameworkCore;

namespace PaymentDetails.Models
{
    public class PaymentDetailContext : DbContext
    {


        public PaymentDetailContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}
