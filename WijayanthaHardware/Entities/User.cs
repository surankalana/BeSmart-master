using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WijayanthaHardware.Entities
{
    [Table("User", Schema = "Security")]
    public class User
    {
        public int UserId { get; set; }
        public string Username   { get; set; }
        public string Password { get; set; }
        public int Status { get; set; }
    }
}