using System;

namespace Investment.Core.Entities
{
    public class Entity
    {
        public Entity()
        {
            CreatedAt = DateTime.Now;
        }
        public int Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
