using System;
using static Orchestrate.Core.Models.Enums;

namespace Orchestrate.Core.Models
{
	public class TimeEntry
	{
        public int ID { get; set; }
        public string Notes { get; set; }
        public User User { get; set; }
        public int Minutes { get; set; }
        public DateTime Timestamp { get; set; }
        public User Approver { get; set; }
        public TimeStatus Status { get; set; }
        public int TaskID { get; set; }

        public Task Task { get; set; }
    }
}