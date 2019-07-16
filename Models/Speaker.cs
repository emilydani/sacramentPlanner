using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Models
{
	public class Speaker
	{
		[Required]
		[StringLength(80)]
		public string Name { get; set; }
		public int SpeakerID { get; set; }
		public int SacramentPlanID { get; set; }


		[Required]
		[StringLength(50)]
		public string Topic { get; set; }
	}
}

