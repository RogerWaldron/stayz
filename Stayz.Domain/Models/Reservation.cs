using System;
namespace Stayz.Domain.Models
{
	public class Reservation
	{
		public int ReservationId { get; set; }
		public required string Customer { get; set; }
        public Stay? Stay { get; set; }
		public DateTime? StartDate { get; set; }
		public DateTime? EndDate { get; set; }
	}
}

