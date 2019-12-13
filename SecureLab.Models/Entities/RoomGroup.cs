using System;

namespace SecureLab.Domain.Entities
{
    public class RoomGroup
    {
        public Guid RoomId { get; set; }
        public virtual Room Room { get; set; }
        public Guid GroupId { get; set; }
        public virtual Group Group { get; set; }
    }
}
