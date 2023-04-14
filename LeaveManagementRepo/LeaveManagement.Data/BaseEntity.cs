namespace LeaveManagement.Data
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        // This is a class that cant be instantiated which every other class will inherit from, these classes create database by code
    }
}
