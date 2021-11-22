using System;

namespace Investment.Core.Entities
{
    public class Entity
    {
        public Entity()
        {
            CreatedAt = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
