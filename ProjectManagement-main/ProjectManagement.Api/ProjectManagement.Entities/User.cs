using System.Collections.Generic;

namespace ProjectManagement.Entities
{
    public class User : BaseEntity
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public virtual IEnumerable<Task> Tasks { get; set; }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   ID == user.ID &&
                   FirstName == user.FirstName &&
                   LastName == user.LastName &&
                   Email == user.Email;
        }

        public override int GetHashCode()
        {
            int hashCode = -988666077;
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FirstName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LastName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            return hashCode;
        }
    }
}
