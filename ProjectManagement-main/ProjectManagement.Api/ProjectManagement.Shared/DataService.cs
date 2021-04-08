using ProjectManagement.Entities;
using ProjectManagement.Entities.Enums;
using System;
using System.Collections.Generic;

namespace ProjectManagement.Shared
{
    public class DataService
    {
        public static void SeedData(PMContext context)
        {
            using (context)
            {
                context.Users.AddRange(InitializeUsers());
                context.Projects.AddRange(InitializeProjects());
                context.Tasks.AddRange(InitializeTasks());
                context.SaveChanges();
            }
        }

        private static List<User> InitializeUsers()
        {
            return new List<User>
            {
                new User
                    {
                        ID = 1,
                        FirstName = "John",
                        LastName = "Doe",
                        Email = "john.doe@test.com"
                    },
                new User
                 {
                    ID = 2,
                    FirstName = "John",
                    LastName = "Skeet",
                    Email = "john.skeet@test.com"
                },
                new User
                {
                    ID = 3,
                    FirstName = "Robert",
                    LastName = "Martin",
                    Email = "robert.martin@test.com"
                },
                new User
                {
                    ID = 4,
                    FirstName = "Martin",
                    LastName = "Fowler",
                    Email = "martin.fowler@test.com"
                }
            };
        }

        private static List<Project> InitializeProjects()
        {
            return new List<Project>
            {
                new Project
                {
                    ID = 1,
                    Name = "TestProject 1",
                    Detail = "This is a test Project",
                    CreatedOn = DateTime.Now
                },
                new Project
                {
                    ID = 2,
                    Name = "TestProject 2",
                    Detail = "This is a test Project",
                    CreatedOn = DateTime.Now
                },
                new Project
                {
                    ID = 3,
                    Name = "TestProject 3",
                    Detail = "This is a test Project",
                    CreatedOn = DateTime.Now
                },
                new Project
                {
                    ID = 4,
                    Name = "TestProject 4",
                    Detail = "This is a test Project",
                    CreatedOn = DateTime.Now
                }
            };
        }

        private static List<Task> InitializeTasks()
        {
            return new List<Task>
            {
                new Task
                {
                    ID = 1,
                    ProjectID = 1,
                    Status = TaskStatus.QA,
                    AssignedToUserID = 1,
                    Detail = "This is a test task",
                    CreatedOn = DateTime.Now
                },
                new Task
                {
                    ID = 2,
                    ProjectID = 1,
                    Status = TaskStatus.Completed,
                    AssignedToUserID = 2,
                    Detail = "This is a test task",
                    CreatedOn = DateTime.Now
                },
                new Task
                {
                    ID = 3,
                    ProjectID = 2,
                    Status = TaskStatus.InProgress,
                    AssignedToUserID = 2,
                    Detail = "This is a test task",
                    CreatedOn = DateTime.Now
                }
            };
        }
    }
}
