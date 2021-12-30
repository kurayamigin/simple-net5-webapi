namespace webapi.Modules
{
    public class Status : Entity
    {
        public string Description { get; set; }

        public Status(string description)
        {
            Description = description;
        }        
        public Status(int id, string description)
        {
            Id = id;
            Description = description;
        }
    }
}