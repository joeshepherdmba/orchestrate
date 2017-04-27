using System;
using System.Collections.Generic;
using static Orchestrate.Core.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orchestrate.Core.Models
{
    public class Task
    {
		public int ID
        {
            get;
            set;
        }
		public string Title
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public TaskStatus Status
        {
            get;
            set;
        }
    
        public Priority Priority
        {
            get;
            set;
        }

        public DateTime StartDate
        {
            get;
            set;
        }

        public DateTime DueDate
        {
            get;
            set;
        }
       
        public DateTime EndDate
        {
            get;
            set;
        }

        //Duration is measured in minutes
        public int EstDuration
        {
            get;
            set;
        }

        [ForeignKey("AssignedTo")]
        public int AssignedToUserID { get; set; }
        public virtual User AssignedTo { get; set; }

        public virtual ICollection<TimeEntry> TimeEntry
        {
            get;
            set;
        }
    }
}
