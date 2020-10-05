using System;

namespace SecureLab.Application.RoomGroups.Queries
{
    public class RoomDTO
    {
        public Guid RoomId { get; set; }
        public string Number { get; set; }
        public string RoomType { get; set; }
    }
}
