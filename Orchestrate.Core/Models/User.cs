using System.Collections.Generic;

namespace Orchestrate.Core.Models
{
	public class User
	{
		public int ID { get; set; }
		public string LastName { get; set; }
		public string FirstMidName { get; set; } 

        public ICollection<Task> Tasks { get; set; }
        public ICollection<TimeEntry> TimeEntries { get; set; }
	}
}