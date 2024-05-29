namespace HotelBookingApi.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string RoomType { get; set; } = string.Empty; // Initialize property
        public int NumberOfNights { get; set; }
        public bool IncludeBreakfast { get; set; }
    }
}
