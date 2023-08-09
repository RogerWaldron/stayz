using System;
namespace Stayz.Domain.Models
{
	public class Reservation
	{
		public int ReservationId { get; set; }
		public required string Customer { get; set; }
        public Room? Room { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
	}
}

