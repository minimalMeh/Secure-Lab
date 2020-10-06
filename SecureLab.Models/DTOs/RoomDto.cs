using System;

namespace SecureLab.Models.DTOs
{
    public class RoomDto
    {
        public Guid RoomId { get; set; }
        public string Number { get; set; }
        public string RoomType { get; set; }
    }
}
