using System;
namespace LittleLemonApi
{
	public class BookingModel
	{
        public string? Fullname { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Occasion { get; set; }
        public int Guests { get; set; }
        public string? ReservationTime { get; set; }
        public string? ReservationDate { get; set; }
    }
}

