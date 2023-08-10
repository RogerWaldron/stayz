using System;
namespace Stayz.Domain.Models
{
	public class Stay
	{
		public int StayId { get; set; }
		public int StayNumber { get; set; }
        public string Description { get; set; }
		public int Stars { get; set; }
		public double Surface { get; set; }
		public bool NeedsRepair { get; set; }
	}
}

