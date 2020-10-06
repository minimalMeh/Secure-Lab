using System;
using System.Collections.Generic;
using System.Text;

namespace SecureLab.Models.DTOs
{
    public class UserDto
    {
        public Guid? Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Information { get; set; }
    }
}
