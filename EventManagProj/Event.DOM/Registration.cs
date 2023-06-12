using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.DOM
{
    public class Registration: BaseDOM
    {
        public int? ID  { get; set; }
        public string? Name { get; set; }

        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country  { get; set; }
        public string? Mobileno { get; set; }
        public string EmailID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public String? Gender  { get; set; }
        public DateTime? Birthdate { get; set; }
        public int? RoleID  { get; set; }

    }
}
