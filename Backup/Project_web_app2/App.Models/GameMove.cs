using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_web_app2.App.Models
{
    public class GameMove
    {
        public Guid gameId { get; set; }
        public Guid playerId { get; set; }
        public int move { get; set; }
    }
}