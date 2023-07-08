﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walking_Tour_API.Core.Models.Domain
{
	[NotMapped]
	public class Difficulty
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
	}
}
