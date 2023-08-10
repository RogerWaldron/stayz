using System;
namespace Stayz.Domain.Models
{
	public class Stay
	{
		public int StayId { get; set; }
		public int StayNumber { get; set; }
        public string Description { get; set; }
		public double Surface { get; set; }
		public DateTime? BookedFrom { get; set; }
		public DateTime? BookedTill { get; set; }
		public bool NeedsRepair { get; set; }

		public int SitterId { get; set; }
		public Sitter Sitter { get; set; }
    }
}

