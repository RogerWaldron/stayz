using System;
namespace Stayz.Api.Dtos
{
	public class SitterGetDto
	{
        public int SitterId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Bio { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Stars { get; set; }
	}
}

