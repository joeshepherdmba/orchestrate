﻿using System;
namespace Orchestrate.Core.Models
{

    //testing branch commit
    public class Enums
    {
        public enum Priority
        {
            High,
            Medium,
            Low
        };

        public enum TaskStatus
        {
            New,
            Inprogress,
            OnHold,
            Done
        };

		public enum TimeStatus
		{
			Submitted, 
            Approved, 
            Denied
		};
    }
}
