using System;
namespace Stayz.Domain.Models
{
	public class Sitter
	{
		public Sitter(string name, int stars, string address)
		{
			if (string.IsNullOrWhiteSpace(name))
				throw new ArgumentException("Stay name is not allowed to be null or whitespace");
		}

		public int SitterId { get; set; }
		public required string Name { get; set; }
		public int Age { get; set; }
		public required string Address { get; set; }
		public required string City { get; set; }
        public required string Country { get; set; }
		public int Stars { get; set; }
        public required List<Stay> Stays { get; set; }
	}
}

