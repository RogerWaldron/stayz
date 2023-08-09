using System;
namespace Stayz.Domain.Models
{
	public class Hotel
	{
		public int HotelId { get; set; }
		public required string Name { get; set; }
		public required string Address { get; set; }
		public required string City { get; set; }
        public required string Country { get; set; }
		public int Stars { get; set; }
        public required List<Room> Rooms { get; set; }
	}
}

