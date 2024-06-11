﻿using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BookingReservationRepository : IBookingReservationRepository
    {
        private readonly FuminiHotelManagementContext _context;

        public BookingReservationRepository(FuminiHotelManagementContext context)
        {
            _context = context;
        }
        public IEnumerable<BookingReservation> GetBookingReservationByCustomerID(int CustomerID)
        {
            return _context.BookingReservations.Where(b => b.CustomerId == CustomerID).ToList();
        }
    }
}
