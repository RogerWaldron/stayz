﻿using System;
using Stayz.Domain.Models;

namespace Stayz.Api.Dtos
{
	public class StayGetDto
	{
        public int StayId { get; set; }
        public int StayNumber { get; set; }
        public string Description { get; set; }
        public double Surface { get; set; }
        public bool NeedsRepair { get; set; }
    }
}

