﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TawGatherMembersInfo.Models
{
	public class PersonCommendation
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public long PersonCommendationId { get; set; }

		public virtual DateTime Date { get; set; }
		public virtual Person Person { get; set; }
		public virtual Commendation Commendation { get; set; }
		public virtual ICollection<PersonCommendationComment> Comments { get; set; }
	}
}