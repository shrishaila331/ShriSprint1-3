using System;
using System.Collections.Generic;

namespace ProjectManagement.Entities
{
    public class Project : BaseEntity
    {
        public Project()
        {
            this.Tasks = new List<Task>();
        }

        public string Name { get; set; }

        public string Detail { get; set; }

        public DateTime CreatedOn { get; set; }

        public virtual IEnumerable<Task> Tasks { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Project project &&
                   ID == project.ID &&
                   Name == project.Name &&
                   Detail == project.Detail &&
                   CreatedOn == project.CreatedOn;
        }

        public override int GetHashCode()
        {
            int hashCode = -2056286480;
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Detail);
            hashCode = hashCode * -1521134295 + CreatedOn.GetHashCode();
            return hashCode;
        }
    }
}
