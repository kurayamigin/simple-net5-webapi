using System.ComponentModel.DataAnnotations;

namespace webapi.Modules
{
    public abstract class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}