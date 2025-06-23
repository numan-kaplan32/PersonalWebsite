using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Props;

namespace Web.Model.TablesClass
{
  public class Personal : CoreEntity
    {
        public string Surname { get; set; } = string.Empty;
        public string PersonalDesc { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; } 
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string ProfilePicture { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
