using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    internal class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(e => new { e.Seat, e.FlightKey, e.PassengerKey });
            builder.HasOne(e => e.Flight).WithMany(e => e.Tickets).HasForeignKey(e => e.FlightKey);
            builder.HasOne(e => e.Passenger).WithMany(e => e.Tickets).HasForeignKey(e => e.PassengerKey);
        }
    }
}
