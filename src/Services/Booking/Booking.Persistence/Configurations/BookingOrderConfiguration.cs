﻿using Booking.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Persistence.Configurations
{
    public class BookingOrderConfiguration : IEntityTypeConfiguration<BookingOrder>
    {
        public void Configure(EntityTypeBuilder<BookingOrder> builder)
        {
            
            /*builder.HasKey(e => e.BookingOrderId);

            builder.Property(e => e.BookingOrderId).
                HasColumnName("BookingOrderID").HasMaxLength(32);

            builder.Property(e => e.NotificationId)
                .HasColumnName("NotificationID")
                .HasMaxLength(32);

            builder.Property(e => e.CustomerId)
               .HasColumnName("CustomerID")
               .HasMaxLength(32);

            builder.Property(e => e.PaymentId)
              .HasColumnName("PaymentID")
              .HasMaxLength(32);         */
        }
    }
}
