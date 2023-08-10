using System;
namespace Stayz.Domain.Models
{
	public class Comment
	{
		public Comment()
		{
		}

		public int CommentId { get; set; }
		public Pet Pet { get; set; }
		public string Message { get; set; }
	}
}

