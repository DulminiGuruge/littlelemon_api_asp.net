using System;
using Microsoft.AspNetCore.Mvc;

namespace LittleLemonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private static List<BookingModel> bookings = new List<BookingModel>();

        [HttpPost]
        public IActionResult PostBooking([FromBody] BookingModel booking)
        {
            // Perform necessary logic (e.g., store the booking information in a list)
            bookings.Add(booking);
            // For simplicity, we'll return the received data as JSON
            return Ok(booking);
        }

        [HttpGet]
        public IActionResult GetAllBookings()
        {
            // Return all bookings as JSON
            return Ok(bookings);
        }
    }
}

