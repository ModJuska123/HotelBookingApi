namespace HotelBookingApi.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Initialize property
        public string Location { get; set; } = string.Empty; // Initialize property
        public string Picture { get; set; } = string.Empty; // Initialize property
    }
}
