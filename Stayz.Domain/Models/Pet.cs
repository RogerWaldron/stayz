using System;
namespace Stayz.Domain.Models
{
	public class Pet
	{
		public Pet()
		{
		}

		public int PetId { get; set; }
		public int OwnerId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int Age { get; set; }
		public string ImgUrl { get; set; }

		public ICollection<Comment> Comments { get; set; }
		//public int CategoryId { get; set; }
		//public string Category Category { get; set; }
	}
}

