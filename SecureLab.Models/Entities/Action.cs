using System;

namespace SecureLab.Domain.Entities
{
    public class Action
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public virtual  User User { get; set; }
        public Guid RoomId { get; set; }
        public virtual Room Room { get; set; }
        public string ActionType { get; set; }
        public DateTime ActionStart { get; set; }
        public DateTime ActionEnd { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
