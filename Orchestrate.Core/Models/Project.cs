using System;
using System.Collections.Generic;
using Orchestrate.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orchestrate.Core.Models
{
    public class Project
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [ForeignKey("ProjectOwner")]
        public int ProjectOwnerID { get; set; }
        public double ProjectValue { get; set; }
        public double VelocityFactor { get; set; }
        public double HealthFactor { get; set; }

		public User ProjectOwner { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
