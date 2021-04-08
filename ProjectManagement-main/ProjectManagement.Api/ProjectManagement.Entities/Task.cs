using ProjectManagement.Entities.Enums;
using System;
using System.Collections.Generic;

namespace ProjectManagement.Entities
{
    public class Task : BaseEntity
    {

        public long ProjectID { get; set; }

        public string Detail { get; set; }

        public TaskStatus Status { get; set; }

        public long? AssignedToUserID { get; set; }

        public DateTime CreatedOn { get; set; }

        public virtual User AssignedToUser { get; set; }

        public virtual Project Project { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Task task &&
                   ID == task.ID &&
                   ProjectID == task.ProjectID &&
                   Detail == task.Detail &&
                   Status == task.Status &&
                   AssignedToUserID == task.AssignedToUserID &&
                   CreatedOn == task.CreatedOn;
        }

        public override int GetHashCode()
        {
            int hashCode = -1422345826;
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + ProjectID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Detail);
            hashCode = hashCode * -1521134295 + Status.GetHashCode();
            hashCode = hashCode * -1521134295 + AssignedToUserID.GetHashCode();
            hashCode = hashCode * -1521134295 + CreatedOn.GetHashCode();
            return hashCode;
        }
    }
}
