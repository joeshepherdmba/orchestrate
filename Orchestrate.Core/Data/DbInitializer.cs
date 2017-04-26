using System;
using System.Linq;
using Orchestrate.Core.Models;
using static Orchestrate.Core.Models.Enums;

namespace Orchestrate.Core.Data
{
    public class DbInitializer
    {
        public static void Initialize(ProjectContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;
            }

            var users = new User[]
            {
	            new User{ FirstMidName="Joe", LastName="Shepherd"},
	            new User { FirstMidName = "Melissa", LastName = "Shepherd" },
	            new User { FirstMidName = "Meredith", LastName = "Alonso" },
	            new User { FirstMidName = "Arturo", LastName = "Anand" },
	            new User { FirstMidName = "Gytis", LastName = "Barzdukas" },
	            new User { FirstMidName = "Yan", LastName = "Li" },
	            new User { FirstMidName = "Peggy", LastName = "Justice" },
	            new User { FirstMidName = "Laura", LastName = "Norman" },
	            new User { FirstMidName = "Nino", LastName = "Olivetto", }
            };

            foreach(User u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();

            var user = context.Users.FirstOrDefault((u => u.FirstMidName == "Joe"));
            var projectOwner = context.Users.FirstOrDefault((o => o.FirstMidName == "Melissa"));
            var approver = context.Users.FirstOrDefault((a => a.FirstMidName == "Yan"));

            //Add Projects
			var projects = new Project[]
			{
                new Project{ Title="New website", Description="Out with the old and in with the new", ProjectOwner=projectOwner, ProjectValue=5, HealthFactor=9, VelocityFactor=8},
                new Project{ Title="iOS App Refactor", Description="Lots of bad code to fix", ProjectOwner=projectOwner, ProjectValue=2, HealthFactor=9, VelocityFactor=7}
			};

			foreach (Project p in projects)
			{
				context.Projects.Add(p);
			}
			context.SaveChanges();


            //Add Tasks
            var tasks = new TaskModel[]
            {
                new TaskModel{ Title="Review Current Website Design", Description="Review design", AssignedTo=user, DueDate=DateTime.Now, StartDate = DateTime.Now,
                    EndDate = DateTime.Now, EstDuration=15, Priority=Priority.Medium, Status=TaskStatus.New}
            };

			foreach (TaskModel t in tasks)
			{
				context.Tasks.Add(t);
			}
			context.SaveChanges();

        }
    }
}
