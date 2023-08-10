using System;
namespace Stayz.Domain.Models
{
	public class Sitter
	{
		public int SitterId { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public string Bio { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
        public string Country { get; set; }
		public int Stars { get; set; }

        public List<Stay> Stays { get; set; }
	}
}

