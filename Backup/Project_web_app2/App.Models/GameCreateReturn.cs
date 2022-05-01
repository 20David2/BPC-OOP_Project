using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_web_app2.App.Models
{
    public class GameCreateReturn
    {
        public bool state { get; set; }
        public Guid gameId { get; set; }
        public string message { get; set; }
    }
}