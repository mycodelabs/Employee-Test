namespace domain
{
    public class Employee : Entity
    {
        public virtual string Email { get; set; }

        public virtual JobTitle Title { get; set; }
    }
}
