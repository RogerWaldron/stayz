using System;
namespace Stayz.Domain.Models
{
	public class Hotel
	{
		public Hotel(string name, int stars, string address)
		{
			if (string.IsNullOrWhiteSpace(name))
				throw new ArgumentException("Hotel name is not allowed to be null or whitespace");
		}

		public int HotelId { get; set; }
		public required string Name { get; set; }
		public required string Address { get; set; }
		public required string City { get; set; }
        public required string Country { get; set; }
		public int Stars { get; set; }
        public required List<Room> Rooms { get; set; }
	}
}

