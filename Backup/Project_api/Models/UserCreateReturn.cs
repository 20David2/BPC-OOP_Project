using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_api.Models
{
    public class UserCreateReturn
    {
        public bool state { get; set; }
        public Guid playerId { get; set; }
        public string message { get; set; }
    }
}